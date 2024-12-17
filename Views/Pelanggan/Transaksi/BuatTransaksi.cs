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

namespace Projek_SimBuku.Views.Pelanggan.Transaksi
{
    public partial class BuatTransaksi : UserControl
    {
        C_Transaksi Controller;
        public BuatTransaksi(C_Transaksi controller)
        {
            InitializeComponent();
            this.Controller = controller;
            Controller.Durasi(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BuatTransaksi_Load(object sender, EventArgs e)
        {
            Tunai.Tag = 1;
            E_wallet.Tag = 2;
            Transfer.Tag = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.Buat_transaks(this);
        }
    }
}
