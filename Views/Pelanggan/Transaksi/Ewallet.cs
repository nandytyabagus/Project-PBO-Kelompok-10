﻿using Projek_SimBuku.Controller;
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
    public partial class Ewallet : UserControl
    {
        C_Transaksi Controller;
        public Ewallet(C_Transaksi controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {

        }
    }
}
