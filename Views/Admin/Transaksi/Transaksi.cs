﻿using Projek_SimBuku.Controller;
using Projek_SimBuku.Views.Admin.Buku;
using Projek_SimBuku.Views.Buku;
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
            transaksi = new C_Transaksi(controller, this);
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            transaksi.LoadData();

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Search.Text))
            {
                transaksi.LoadData();
            }
            else
            {
                transaksi.SearchTransaksi(Search.Text);
            }
        }

        private void dataTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idTransaksi = Convert.ToInt32(dataTransaksi.Rows[e.RowIndex].Cells["id_transaksi"].Value);
                if (e.ColumnIndex == dataTransaksi.Columns["Detail"].Index)
                {
                    transaksi.LoadDetail(idTransaksi);
                }
            }
        }
    }
}
