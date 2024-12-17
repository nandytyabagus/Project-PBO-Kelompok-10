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
    public partial class Transfer : UserControl
    {
        C_Transaksi Controller;
        public Transfer(C_Transaksi controller)
        {
            InitializeComponent();
            Controller = controller;
        }
    }
}
