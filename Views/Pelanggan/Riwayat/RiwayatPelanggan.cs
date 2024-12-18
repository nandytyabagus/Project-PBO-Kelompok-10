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

namespace Projek_SimBuku.Views.Pelanggan
{
    public partial class RiwayatPelanggan : UserControl
    {
        C_Homepage Controller;
        C_Transaksi transaksi;
        public RiwayatPelanggan(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            transaksi = new C_Transaksi(controller, this);
        }

        private void RiwayatPelanggan_Load(object sender, EventArgs e)
        {
            transaksi.LoadDatariwayat();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["Detail"].Index)
                {
                    transaksi.LoadDetailTransaksi(M_Sementara.id);
                }
            }
        }
    }
}
