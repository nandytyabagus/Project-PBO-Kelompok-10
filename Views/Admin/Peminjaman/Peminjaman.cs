using Projek_SimBuku.Controller;
using Projek_SimBuku.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_SimBuku.Views.Peminjaman
{
    public partial class Peminjaman : UserControl
    {
        C_Homepage Controller;
        C_Peminjaman peminjaman;
        public Peminjaman(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            peminjaman = new C_Peminjaman(controller, this);
        }

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            peminjaman.LoadData();
        }

        private void dataPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataPeminjaman.Rows[e.RowIndex].Cells["id_transaksi"].Value);
                if (e.ColumnIndex == dataPeminjaman.Columns["Ubah Status"].Index)
                {
                    peminjaman.Update(id);
                    peminjaman.LoadData();
                }
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Search.Text))
            {
                peminjaman.LoadData();
            }
            else
            {
                peminjaman.CariPeminjaman(Search.Text);
            }
        }
    }
}
