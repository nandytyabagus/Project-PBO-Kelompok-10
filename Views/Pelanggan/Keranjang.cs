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

        private void Keranjang_Load(object sender, EventArgs e)
        {
            keranjang.Load_Katalog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
