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

namespace Projek_SimBuku.Views.Admin.Transaksi
{
    public partial class Transaksi : UserControl
    {
        C_Homepage Controller;
        C_Transaksi transaksi;
        public Transaksi(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            transaksi = new C_Transaksi(controller,this);
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            transaksi.LoadData();
        }
    }
}
