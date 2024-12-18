using Projek_SimBuku.Controller;
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
    public partial class Bukti_Pembayaran : UserControl
    {
        C_Transaksi Controller;
        public Bukti_Pembayaran(C_Transaksi controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Bukti_Pembayaran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
