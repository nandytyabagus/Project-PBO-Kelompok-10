using Projek_SimBuku.Controller;
using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Admin.Transaksi;
using Projek_SimBuku.Views.Massage_Box;
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
        FormTransaksi formTransaksi;
        M_Keranjang m_Keranjang;
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
            keranjang.load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (M_Keranjang.StaticCartItems == null || M_Keranjang.StaticCartItems.Count == 0)
            {
                MessageBox.Show("Pilih Buku terlebih dahulu");
            }
            else
            {
                C_Transaksi transaksi = new C_Transaksi(formTransaksi);
                FormTransaksi view = new FormTransaksi(transaksi, new BuatTransaksi(transaksi));
                view.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idBuku = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id_Buku"].Value);
                M_Keranjang mkeranjang = new M_Keranjang
                {
                    Id_Buku = idBuku,
                    Gambar = (byte[])dataGridView1.Rows[e.RowIndex].Cells["gambar"].Value,
                    Judul_buku = dataGridView1.Rows[e.RowIndex].Cells["Judul_buku"].Value.ToString(),
                    Genre = dataGridView1.Rows[e.RowIndex].Cells["Genre"].Value.ToString()
                };
                if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    keranjang.DeleteFromCart(idBuku);
                    keranjang.load();
                }

            }
        }
    }
}
