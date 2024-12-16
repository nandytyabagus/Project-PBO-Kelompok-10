using Projek_SimBuku.Controller;
using Projek_SimBuku.Views.Pelanggan.Transaksi;
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
    public partial class Keranjang : UserControl
    {
        C_Homepage Controller;
        C_Keranjang keranjang;
        public Keranjang(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            keranjang = new C_Keranjang(Controller, this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Keranjang_Load(object sender, EventArgs e)
        {
            keranjang.LoadKeranjang();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
