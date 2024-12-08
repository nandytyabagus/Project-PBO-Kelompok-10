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

namespace Projek_SimBuku.Controller
{
    public class C_Buku : Connector
    {
        C_Homepage c_hompage;
        Buku Vbuku;
        FormBuku form;
        public EditBuku edit;
        public TambahBuku tambah;
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
        public List<M_Buku> GetListBuku()
        {
            List<M_Buku> bukuList = new List<M_Buku>();
            DataTable data = Execute_With_Return("SELECT Buku.Id_Buku, Buku.Judul_Buku, Buku.Tahun_Terbit, Buku.Stok, Buku.Gambar, Buku.keterangan, pengarang.Nama_pengarang, genre.genre, penerbit.penerbit FROM Buku JOIN pengarang ON Buku.Id_pengarang = pengarang.Id_pengarang JOIN genre ON Buku.Id_genre = genre.Id_genre JOIN penerbit ON Buku.Id_penerbit = penerbit.Id_penerbit;");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                M_Buku m_buku = new M_Buku
                {
                    Id_Buku = Convert.ToInt32(data.Rows[i]["Id_Buku"]),
                    Judul_buku = data.Rows[i]["Judul_Buku"].ToString(),
                    Tahun_Terbit = data.Rows[i]["Tahun_Terbit"].ToString(),
                    Stok = Convert.ToInt32(data.Rows[i]["Stok"]),
                    Gambar = data.Rows[i]["Gambar"] as byte[],
                    keterangan = data.Rows[i]["keterangan"].ToString(),
                    Pengarang = data.Rows[i]["Nama_pengarang"].ToString(),
                    Genre = data.Rows[i]["Genre"].ToString(),
                    Penerbit = data.Rows[i]["Penerbit"].ToString()
                };

                bukuList.Add(m_buku);
            }
            return bukuList;
        }
        public void insert(object obj)
        {
            M_Buku buku = obj as M_Buku;
            Execute_No_Return("");
        }
        public void Delete(M_Buku buku)
        {
            
        }
        public void Update(object obj, int id)
        {

        }
        public void TambahData()
        {
            form = new FormBuku(this, new TambahBuku(this));
            form.ShowDialog();
        }
        public void Close()
        {
            form.Close();
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
