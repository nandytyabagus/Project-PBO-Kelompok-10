using Projek_SimBuku.Controller;
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
        tambah vtambah;
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
    }
}
