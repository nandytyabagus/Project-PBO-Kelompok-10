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
        C_Homepage Controller;
        C_Buku c_buku;
        M_Buku m_buku;
        public Buku(C_Homepage controller)
        {
            InitializeComponent();
            this.Controller = controller;
            c_buku = new C_Buku(controller, this);
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buku_Load(object sender, EventArgs e)
        {
            c_buku.Load();
        }

        private void TabelBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (0 == e.RowIndex && e.ColumnIndex == TabelBuku.Columns["Delete"].Index)
            {
                return;
            }
            if (e.ColumnIndex == TabelBuku.Columns["Edit"].Index)
            {
                c_buku.showEdit(new M_Buku
                {
                    Id_Buku = (int)TabelBuku.Rows[e.RowIndex].Cells["id"].Value,
                    Judul_buku = TabelBuku.Rows[e.RowIndex].Cells["Judul"].Value.ToString(),
                    Tahun_Terbit = (int)TabelBuku.Rows[e.RowIndex].Cells["Tahun Terbit"].Value,
                    Stok = (int)TabelBuku.Rows[e.RowIndex].Cells["Jumlah"].Value,
                    Pengarang = TabelBuku.Rows[e.RowIndex].Cells["Pengarang"].Value.ToString(),
                    Genre = TabelBuku.Rows[e.RowIndex].Cells["Genre"].Value.ToString(),
                    Penerbit = TabelBuku.Rows[e.RowIndex].Cells["Penerbit"].Value.ToString(),
                });
                return;
            }
            if (e.ColumnIndex == TabelBuku.Columns["Delete"].Index)
            {
                c_buku.DeleteBuku((int)TabelBuku.Rows[e.RowIndex].Cells["id"].Value);
            }
        }


        private void TabelBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTambahBuku_Click(object sender, EventArgs e)
        {
            tambah Tambah = new tambah(c_buku);
            Tambah.ShowDialog();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (Search.Text == null)
            {
                return;
            }
            else
            {
                c_buku.SearchBuku(Search.Text);
            }
        }
    }
}
