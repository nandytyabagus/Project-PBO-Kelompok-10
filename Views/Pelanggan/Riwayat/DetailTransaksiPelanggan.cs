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

namespace Projek_SimBuku.Views.Pelanggan.Riwayat
{
    public partial class DetailTransaksiPelanggan : Form
    {
        C_Transaksi Controller;
        public DetailTransaksiPelanggan(C_Transaksi controller,M_Transaksi data)
        {
            InitializeComponent();
            Controller = controller;
        }
    }
}
