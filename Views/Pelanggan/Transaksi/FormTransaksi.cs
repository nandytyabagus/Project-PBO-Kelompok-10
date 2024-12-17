using Org.BouncyCastle.Asn1.X509;
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
    public partial class FormTransaksi : Form
    {
        C_Transaksi Controller;
        C_Keranjang Controller_Keranjang;
        BuatTransaksi buatTransaksi;
        public FormTransaksi(C_Transaksi controller,C_Keranjang controller_keranjang,UserControl view)
        {
            InitializeComponent();
            Controller = controller;
            Controller_Keranjang = controller_keranjang;
            panel1.Controls.Add(view);
        }
        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
