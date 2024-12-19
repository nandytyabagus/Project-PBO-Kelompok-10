using Projek_SimBuku.Views.Dashboard;
using Projek_SimBuku.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projek_SimBuku.Views.Buku;
using System.Data;
using Projek_SimBuku.Model;
using MailKit;
using Projek_SimBuku.Views.Admin.Buku;
using Npgsql;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Projek_SimBuku.Controller.C_Buku;

namespace Projek_SimBuku.Controller
{
    public class C_Buku : Connector
    {
        C_Homepage c_hompage;
        Buku Vbuku;
        CRUtambah vCRUtambah;
        M_Buku m_Buku;
        public C_Buku(C_Homepage homepage, Buku buku)
        {
            c_hompage = homepage;
            Vbuku = buku;

        }
        public void genre(CRUtambah view)
        {
            DataTable data = Execute_With_Return("SELECT * FROM genre");
            view.BoxGenre.DataSource = data;
            view.BoxGenre.DisplayMember = "genre";
            view.BoxGenre.ValueMember = "id_genre";
            view.BoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void Load()
        {
            Vbuku.TabelBuku.DataSource = null;
            Vbuku.TabelBuku.Columns.Clear();

            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn
            {
                Name = "Delete",
                UseColumnTextForButtonValue = true,
                Text = "Delete"
            };

            DataGridViewButtonColumn Edit = new DataGridViewButtonColumn
            {
                Name = "Edit",
                UseColumnTextForButtonValue = true,
                Text = "Edit"
            };
            DataGridViewButtonColumn Detail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                UseColumnTextForButtonValue = true,
                Text = "Detail"
            };
            Vbuku.TabelBuku.DataSource = GetListBuku();

            Vbuku.TabelBuku.Columns["Id_Buku"].Visible = false;
            Vbuku.TabelBuku.Columns["keterangan"].Visible = false;
            Vbuku.TabelBuku.Columns["gambar"].Visible = false;
            Vbuku.TabelBuku.Columns["Judul_buku"].HeaderText = "Judul";
            Vbuku.TabelBuku.Columns["Tahun_Terbit"].HeaderText = "Tahun Terbit";
            Vbuku.TabelBuku.Columns["Stok"].HeaderText = "Jumlah";
            Vbuku.TabelBuku.Columns["Pengarang"].HeaderText = "Pengarang";
            Vbuku.TabelBuku.Columns["Genre"].HeaderText = "Genre";
            Vbuku.TabelBuku.Columns["Penerbit"].HeaderText = "Penerbit";

            Vbuku.TabelBuku.Columns.Add(Detail);
            Vbuku.TabelBuku.Columns.Add(Edit);
            Vbuku.TabelBuku.Columns.Add(Delete);

            Vbuku.TabelBuku.Columns["Detail"].HeaderText = "";
            Vbuku.TabelBuku.Columns["Edit"].HeaderText = "";
            Vbuku.TabelBuku.Columns["Delete"].HeaderText = "";

            Vbuku.TabelBuku.Refresh();
        }


        public List<M_Buku> GetListBuku()
        {
            List<M_Buku> bukuList = new List<M_Buku>();
            DataTable data = Execute_With_Return("SELECT Buku.Id_Buku, Buku.Judul_Buku, Buku.Tahun_Terbit, Buku.Stok, Buku.Gambar, Buku.keterangan, Buku.pengarang, Buku.penerbit, genre.genre  FROM Buku JOIN Genre ON Buku.Id_Genre = Genre.Id_Genre;");

            foreach (DataRow row in data.Rows)
            {
                M_Buku m_buku = new M_Buku
                {
                    Id_Buku = Convert.ToInt32(row["Id_Buku"]),
                    Judul_buku = row["Judul_Buku"].ToString(),
                    Tahun_Terbit = Convert.ToInt32(row["Tahun_Terbit"]),
                    Stok = Convert.ToInt32(row["Stok"]),
                    Gambar = row["Gambar"] != DBNull.Value ? (byte[])row["Gambar"] : new byte[0],
                    keterangan = row["keterangan"].ToString(),
                    Pengarang = row["pengarang"].ToString(),
                    Genre = row["Genre"].ToString(),
                    Penerbit = row["Penerbit"].ToString()
                };

                bukuList.Add(m_buku);
            }
            return bukuList;
        }

        public void Tambahbuku(CRUtambah view)
        {
            DataBaru data = new DataBaru()
            {
                judul = view.judul.Text,
                tahun_terbit = int.Parse(view.tahunterbit.Text),
                gambar = (byte[]) new ImageConverter().ConvertTo(view.pictureBox1.Image, typeof(byte[])),
                stok = int.Parse(view.Jumlah.Text),
                keterangan = view.keterangan.Text,
                Pengarang = view.pengarang.Text,
                Penerbit = view.penerbit.Text,
                Genre = (int)view.BoxGenre.SelectedValue,
            };
            try
            {
                insert(data);
                Load();
            }
            catch { }
        }
        public void EditBuku(CRUtambah view,int id)
        {
            DataBaru data = new DataBaru()
            {
                judul = view.judul.Text,
                tahun_terbit = int.Parse(view.tahunterbit.Text),
                gambar = (byte[])new ImageConverter().ConvertTo(view.pictureBox1.Image, typeof(byte[])),
                stok = int.Parse(view.Jumlah.Text),
                keterangan = view.keterangan.Text,
                Pengarang = view.pengarang.Text,
                Penerbit = view.penerbit.Text,
                Genre = (int)view.BoxGenre.SelectedValue,
            };
            try
            {
                Update(data,id);
                Load();
            }
            catch { }
        }

        public void DeleteBuku(int id)
        {
            Delete(id);
            Load();
        }
        public void SearchBuku(string keyword)
        {
            var filteredData = GetListBuku().Where(b => 
            b.Judul_buku.Contains(keyword, StringComparison.OrdinalIgnoreCase) || 
            b.Pengarang.Contains(keyword, StringComparison.OrdinalIgnoreCase) || 
            b.Genre.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            b.Penerbit.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            b.Stok.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();


            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn
            {
                Name = "Delete",
                UseColumnTextForButtonValue = true,
                Text = "Delete"
            };

            DataGridViewButtonColumn Edit = new DataGridViewButtonColumn
            {
                Name = "Edit",
                UseColumnTextForButtonValue = true,
                Text = "Edit"
            }; 
            DataGridViewButtonColumn Detail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                UseColumnTextForButtonValue = true,
                Text = "Detail"
            };

            Vbuku.TabelBuku.DataSource = null;
            Vbuku.TabelBuku.Columns.Clear();
            Vbuku.TabelBuku.DataSource = filteredData;

            Vbuku.TabelBuku.Columns["Id_Buku"].Visible = false;
            Vbuku.TabelBuku.Columns["keterangan"].Visible = false;
            Vbuku.TabelBuku.Columns["gambar"].Visible = false;
            Vbuku.TabelBuku.Columns["Judul_buku"].HeaderText = "Judul";
            Vbuku.TabelBuku.Columns["Tahun_Terbit"].HeaderText = "Tahun Terbit";
            Vbuku.TabelBuku.Columns["Stok"].HeaderText = "Jumlah";
            Vbuku.TabelBuku.Columns["Pengarang"].HeaderText = "Pengarang";
            Vbuku.TabelBuku.Columns["Genre"].HeaderText = "Genre";
            Vbuku.TabelBuku.Columns["Penerbit"].HeaderText = "Penerbit";

            Vbuku.TabelBuku.Columns.Add(Detail);
            Vbuku.TabelBuku.Columns.Add(Edit);
            Vbuku.TabelBuku.Columns.Add(Delete);

            Vbuku.TabelBuku.Columns["Detail"].HeaderText = "";
            Vbuku.TabelBuku.Columns["Edit"].HeaderText = "";
            Vbuku.TabelBuku.Columns["Delete"].HeaderText = "";

            Vbuku.TabelBuku.Refresh();
        }
        public void insert(object item)
        {
            DataBaru dataBaru = item as DataBaru;
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "INSERT INTO Buku (Judul_Buku, Tahun_Terbit, Stok, keterangan, Pengarang, id_Genre, Penerbit, gambar) VALUES (@Judul_Buku, @Tahun_Terbit, @Stok, @Keterangan, @Pengarang, @id_Genre, @Penerbit, @foto)";

                cmd.Parameters.AddWithValue("@Judul_Buku", dataBaru.judul);
                cmd.Parameters.AddWithValue("@Tahun_Terbit", dataBaru.tahun_terbit);
                cmd.Parameters.AddWithValue("@Stok", dataBaru.stok);
                cmd.Parameters.AddWithValue("@Keterangan", dataBaru.keterangan);
                cmd.Parameters.AddWithValue("@Pengarang", dataBaru.Pengarang);
                cmd.Parameters.AddWithValue("@id_Genre", dataBaru.Genre);
                cmd.Parameters.AddWithValue("@Penerbit", dataBaru.Penerbit);
                cmd.Parameters.AddWithValue("@foto", NpgsqlTypes.NpgsqlDbType.Bytea, dataBaru.gambar);

                Execute_No_Return(cmd);
            }
        }
        public void Delete(int id)
        {
            Execute_No_Return($"DELETE FROM Buku WHERE Id_Buku = {id}");
        }
        public void Update(object obj, int id)
        {
            DataBaru dataBaru = obj as DataBaru;
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = $"UPDATE Buku SET Judul_Buku = @Judul_Buku, Tahun_Terbit = @Tahun_Terbit, Stok = @Stok, keterangan = @Keterangan, Pengarang = @Pengarang, id_Genre = @id_Genre, Penerbit = @Penerbit, gambar = @foto WHERE Id_Buku = {id}";

                cmd.Parameters.AddWithValue("@Judul_Buku", dataBaru.judul);
                cmd.Parameters.AddWithValue("@Tahun_Terbit", dataBaru.tahun_terbit);
                cmd.Parameters.AddWithValue("@Stok", dataBaru.stok);
                cmd.Parameters.AddWithValue("@Keterangan", dataBaru.keterangan);
                cmd.Parameters.AddWithValue("@Pengarang", dataBaru.Pengarang);
                cmd.Parameters.AddWithValue("@id_Genre", dataBaru.Genre);
                cmd.Parameters.AddWithValue("@Penerbit", dataBaru.Penerbit);
                cmd.Parameters.AddWithValue("@foto", NpgsqlTypes.NpgsqlDbType.Bytea, dataBaru.gambar);

                Execute_No_Return(cmd);
            }
        }
        public class DataBaru
        {
            public int id {  get; set; }
            public string judul { get; set; }
            public int tahun_terbit { get; set; }
            public byte[] gambar { get; set; }
            public int stok { get; set; }
            public string keterangan { get; set; }
            public string Pengarang { get; set; }
            public string Penerbit { get; set; }
            public int Genre { get; set; }
        }
    }
}
