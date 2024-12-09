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
using static System.Runtime.InteropServices.JavaScript.JSType;
using Npgsql;
using System.ComponentModel.DataAnnotations;

namespace Projek_SimBuku.Controller
{
    public class C_Buku : Connector
    {
        HomePage homePage;
        C_Homepage c_hompage;
        Buku Vbuku;
        FormBuku form;
        tambah Tambah;
        public EditBuku edit;
        public DetailBuku detail;
        public C_Buku(C_Homepage homepage, Buku buku)
        {
            c_hompage = homepage;
            Vbuku = buku;
        }
        public C_Buku(FormBuku formBuku)
        {
            form = formBuku;
            edit = new EditBuku(this);
            detail = new DetailBuku(this);
        }
        public C_Buku(tambah tambah)
        {
            Tambah = tambah;
        }
        public void SwitchView(UserControl view)
        {
            form.panel1.Controls.Clear();
            form.panel1.Controls.Add(view);
        }
        public void genre(tambah view)
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

            Vbuku.TabelBuku.DataSource = GetListBuku();

            Vbuku.TabelBuku.Columns["Id_Buku"].Visible = false;
            Vbuku.TabelBuku.Columns["keterangan"].Visible = false;
            Vbuku.TabelBuku.Columns["gambar"].Visible = false ;
            Vbuku.TabelBuku.Columns["Judul_buku"].HeaderText = "Judul";
            Vbuku.TabelBuku.Columns["Tahun_Terbit"].HeaderText = "Tahun Terbit";
            Vbuku.TabelBuku.Columns["Stok"].HeaderText = "Jumlah";
            Vbuku.TabelBuku.Columns["Pengarang"].HeaderText = "Pengarang";
            Vbuku.TabelBuku.Columns["Genre"].HeaderText = "Genre";
            Vbuku.TabelBuku.Columns["Penerbit"].HeaderText = "Penerbit";

            Vbuku.TabelBuku.Columns.Add(Edit);
            Vbuku.TabelBuku.Columns.Add(Delete);

            Vbuku.TabelBuku.Columns["Edit"].HeaderText = "";
            Vbuku.TabelBuku.Columns["Delete"].HeaderText = "";
        }
        public List<M_Buku> GetListBuku()
        {
            List<M_Buku> bukuList = new List<M_Buku>();
            DataTable data = Execute_With_Return("SELECT Buku.Id_Buku, Buku.Judul_Buku, Buku.Tahun_Terbit, Buku.Stok, Buku.Gambar, Buku.keterangan, Buku.pengarang, Buku.penerbit, genre.genre  FROM Buku JOIN Genre ON Buku.Id_Genre = Genre.Id_Genre;");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                M_Buku m_buku = new M_Buku
                {
                    Id_Buku = Convert.ToInt32(data.Rows[i]["Id_Buku"]),
                    Judul_buku = data.Rows[i]["Judul_Buku"].ToString(),
                    Tahun_Terbit = Convert.ToInt32(data.Rows[i]["Tahun_Terbit"]),
                    Stok = Convert.ToInt32(data.Rows[i]["Stok"]),
                    Gambar = data.Rows[i]["Gambar"] as byte[],
                    keterangan = data.Rows[i]["keterangan"].ToString(),
                    Pengarang = data.Rows[i]["pengarang"].ToString(),
                    Genre = data.Rows[i]["Genre"].ToString(),
                    Penerbit = data.Rows[i]["Penerbit"].ToString()
                };

                bukuList.Add(m_buku);
            }
            return bukuList;
        }
        public void Tambahbuku(tambah view)
        {
            DataBaru data = new DataBaru()
            {
                judul = view.judul.Text,
                tahun_terbit = int.Parse(view.tahunterbit.Text),
                gambar = null,
                stok = int.Parse(view.Jumlah.Text),
                keterangan = view.keterangan.Text,
                Pengarang = view.pengarang.Text,
                Penerbit = view.penerbit.Text,
                Genre = (int)view.BoxGenre.SelectedValue,
            };
            try
            {
                insert(data);
            }
            catch { }
        }
        public void insert(object item)
        {
            DataBaru dataBaru = item as DataBaru;
            Execute_No_Return($"INSERT INTO Buku (Judul_Buku, Tahun_Terbit, Stok, keterangan, Pengarang, id_Genre, Penerbit) VALUES ('{dataBaru.judul}','{dataBaru.tahun_terbit}','{dataBaru.stok}','{dataBaru.keterangan}','{dataBaru.Pengarang}','{dataBaru.Genre}','{dataBaru.Penerbit}')");
        }
        public void Delete(int id)
        {
            Execute_No_Return($"DELETE FROM Buku WHERE Id_Buku = {id}");
        }
        public void Update(object obj, int id)
        {

        }
        public class DataBaru
        {
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
