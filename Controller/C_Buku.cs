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

namespace Projek_SimBuku.Controller
{
    public class C_Buku : Connector
    {
        C_Homepage c_hompage;
        Buku Vbuku;
        FormBuku form;
        public EditBuku edit;
        public tambah Tambah;
        public DetailBuku detail;
        public C_Buku(C_Homepage homepage, Buku buku)
        {
            c_hompage = homepage;
            Vbuku = buku;
        }
        public void SwitchView(UserControl view)
        {
            form.panel1.Controls.Clear();
            form.panel1.Controls.Add(view);
        }
        public void Simpan()
        {
            //string judulBuku = Tambah.judul.Text;
            //int tahunTerbit = int.Parse(Tambah.tahunterbit.Text);
            //int stok = int.Parse(Tambah.Jumlah.Text);
            //byte[] gambar = null;
            //string keterangan = Tambah.keterangan.Text;
            //string Pengarang = Tambah.pengarang.Text;
            //string Genre = Tambah.boxgenre.SelectedText;
            //string Penerbit = Tambah.penerbit.Text;

            //M_Buku m_buku = new M_Buku
            //{
            //    Judul_buku = judulBuku,
            //    Tahun_Terbit = tahunTerbit,
            //    Stok = stok,
            //    Gambar = gambar,
            //    keterangan = keterangan,
            //    Pengarang = Pengarang,
            //    Genre = Genre,
            //    Penerbit = Penerbit
            //};
            //insert(m_buku);
        }
        //public void genre()
        //{
        //    Tambah.boxgenre.DataSource = get();
        //    Tambah.boxgenre.DisplayMember = "genre";
        //    Tambah.boxgenre.ValueMember = "id_genre";
        //    Tambah.boxgenre.DropDownStyle = ComboBoxStyle.DropDownList;
        //}

        //public List<M_Genre> get()
        //{
        //    List<M_Genre> List = new List<M_Genre>();
        //    DataTable data = Execute_With_Return("SELECT * FROM genre");
        //    for (int i = 0; i < data.Rows.Count; i++)
        //    {
        //        M_Genre genre = new M_Genre
        //        {
        //            Id_Genre = Convert.ToInt32(data.Rows[i]["id_genre"]),
        //            Genre = data.Rows[i]["genre"].ToString()
        //        };
        //        List.Add(genre);
        //    }
        //    return List;
        //}

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
        public void insert(M_Buku m_Buku)
        {
            Execute_No_Return($"INSERT INTO Buku (Judul_Buku, Tahun_Terbit, Stok, Gambar, keterangan, Pengarang, Id_Genre, Penerbit) VALUES ('{m_Buku.Judul_buku}','{m_Buku.Tahun_Terbit}','{m_Buku.Stok}','{m_Buku.Gambar}','{m_Buku.keterangan}','{m_Buku.Pengarang}','{Tambah.boxgenre.SelectedValue}','{m_Buku.Penerbit}')");
        }
        public void Delete(int id)
        {
            Execute_No_Return($"DELETE FROM Buku WHERE Id_Buku = {id}");
        }
        public void Update(object obj, int id)
        {

        }
    }
}
