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

namespace Projek_SimBuku.Controller
{
    public class C_Buku : Connector
    {
        C_Homepage c_hompage;
        Buku Vbuku;
        public C_Buku(C_Homepage homepage,Buku buku)
        {
            c_hompage = homepage;
            Vbuku = buku;
        }
        public List<M_Buku> GetListBuku()
        {
            List<M_Buku> bukuList = new List<M_Buku>();
            DataTable data = Execute_With_Return("SELECT Buku.Id_Buku, Buku.Judul_Buku, Buku.Tahun_Terbit, Buku.Stok, Buku.Gambar, pengarang.Nama_pengarang, genre.genre, penerbit.penerbit FROM Buku JOIN pengarang ON Buku.Id_pengarang = pengarang.Id_pengarang JOIN genre ON Buku.Id_genre = genre.Id_genre JOIN penerbit ON Buku.Id_penerbit = penerbit.Id_penerbit;");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                M_Buku m_buku = new M_Buku
                {
                    Id_Buku = Convert.ToInt32(data.Rows[i]["Id_Buku"]),
                    Judul_buku = data.Rows[i]["Judul_Buku"].ToString(),
                    Tahun_Terbit = data.Rows[i]["Tahun_Terbit"].ToString(),
                    Stok = Convert.ToInt32(data.Rows[i]["Stok"]),
                    Gambar = data.Rows[i]["Gambar"] as byte[],
                    Pengarang = data.Rows[i]["Nama_pengarang"].ToString(),
                    Genre = data.Rows[i]["Genre"].ToString(),
                    Penerbit = data.Rows[i]["Penerbit"].ToString()
                };

                bukuList.Add(m_buku);
            }
            return bukuList;
        }
        //public int insert(object obj)
        //{

        //}
        public void Delete(int id)
        {

        }
        public void Update(object obj, int id)
        {

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

    }
}
