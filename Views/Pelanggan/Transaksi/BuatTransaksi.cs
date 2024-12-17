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
        C_Keranjang keranjang;
        public BuatTransaksi(C_Transaksi controller, C_Keranjang keranjang)
        {
            InitializeComponent();
            Controller = controller;
            this.keranjang = keranjang;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BuatTransaksi_Load(object sender, EventArgs e)
        {
            //Controller.Metode_pembayaran(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
