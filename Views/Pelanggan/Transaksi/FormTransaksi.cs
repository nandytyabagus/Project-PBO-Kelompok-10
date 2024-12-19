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
        BuatTransaksi buatTransaksi;
        public FormTransaksi(C_Transaksi controller,UserControl view)
        {
            InitializeComponent();
            Controller = controller;
            panel1.Controls.Add(view);
            Controller = new C_Transaksi(this);
        }
        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
