using MailKit.Net.Imap;
using Projek_SimBuku.Controller;
using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Admin.Buku;
using Projek_SimBuku.Views.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_SimBuku.Views.Buku
{
    public partial class Buku : UserControl
    {
        C_Homepage _homepage;
        C_Buku Controller;
        M_Buku m_buku;
        public Buku(C_Homepage c_Homepage)
        {
            InitializeComponent();
            this._homepage = c_Homepage;
            Controller = new C_Buku(_homepage, this);
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buku_Load(object sender, EventArgs e)
        {
            Controller.Load();
            Search.Text = string.Empty;
        }

        private void TabelBuku_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        { 
            if (e.RowIndex >= 0) 
            { 
                int idBuku = Convert.ToInt32(TabelBuku.Rows[e.RowIndex].Cells["Id_Buku"].Value); 
                if (e.ColumnIndex == TabelBuku.Columns["Delete"].Index) 
                { 
                    Controller.Delete(idBuku); 
                    Controller.Load(); 
                }
                else if (e.ColumnIndex == TabelBuku.Columns["Edit"].Index) 
                { 
                    M_Buku buku = new M_Buku 
                    { 
                        Id_Buku = idBuku, 
                        Judul_buku = TabelBuku.Rows[e.RowIndex].Cells["Judul_buku"].Value.ToString(), 
                        Tahun_Terbit = Convert.ToInt32(TabelBuku.Rows[e.RowIndex].Cells["Tahun_Terbit"].Value), 
                        Stok = Convert.ToInt32(TabelBuku.Rows[e.RowIndex].Cells["Stok"].Value), 
                        Pengarang = TabelBuku.Rows[e.RowIndex].Cells["Pengarang"].Value.ToString(), 
                        Genre = TabelBuku.Rows[e.RowIndex].Cells["Genre"].Value.ToString(), 
                        Penerbit = TabelBuku.Rows[e.RowIndex].Cells["Penerbit"].Value.ToString(), 
                        keterangan = TabelBuku.Rows[e.RowIndex].Cells["keterangan"].Value.ToString(), 
                        Gambar = (byte[]) TabelBuku.Rows[e.RowIndex].Cells["gambar"].Value
                    };
                    CRUtambah formTambah = new CRUtambah(buku, Controller); 
                    formTambah.ShowDialog();
                }
                else if (e.ColumnIndex == TabelBuku.Columns["Detail"].Index)
                {
                    M_Buku buku = new M_Buku
                    {
                        Id_Buku = idBuku,
                        Judul_buku = TabelBuku.Rows[e.RowIndex].Cells["Judul_buku"].Value.ToString(),
                        Tahun_Terbit = Convert.ToInt32(TabelBuku.Rows[e.RowIndex].Cells["Tahun_Terbit"].Value),
                        Stok = Convert.ToInt32(TabelBuku.Rows[e.RowIndex].Cells["Stok"].Value),
                        Pengarang = TabelBuku.Rows[e.RowIndex].Cells["Pengarang"].Value.ToString(),
                        Genre = TabelBuku.Rows[e.RowIndex].Cells["Genre"].Value.ToString(),
                        Penerbit = TabelBuku.Rows[e.RowIndex].Cells["Penerbit"].Value.ToString(),
                        keterangan = TabelBuku.Rows[e.RowIndex].Cells["keterangan"].Value.ToString(),
                        Gambar = (byte[])TabelBuku.Rows[e.RowIndex].Cells["gambar"].Value
                    };
                    CRUtambah formTambah = new CRUtambah(buku, Controller);
                    formTambah.ShowDialog();
                }
            } 
        }

        private void buttonTambahBuku_Click(object sender, EventArgs e)
        {
            CRUtambah Tambah = new CRUtambah(Controller);
            Tambah.ShowDialog();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Search.Text))
            {
                Controller.Load();
            }
            else
            {
                Controller.SearchBuku(Search.Text);
            }
        }
    }
}
