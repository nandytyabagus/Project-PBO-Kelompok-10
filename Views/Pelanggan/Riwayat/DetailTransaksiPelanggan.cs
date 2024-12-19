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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projek_SimBuku.Views.Pelanggan.Riwayat
{
    public partial class DetailTransaksiPelanggan : Form
    {
        C_Transaksi Controller;
        M_Transaksi Model;
        public DetailTransaksiPelanggan(C_Transaksi controller, M_Transaksi data)
        {
            InitializeComponent();
            Controller = controller;
            Model = data;
        }

        private void DetailTransaksiPelanggan_Load(object sender, EventArgs e)
        {
            Tanggal_transaksi.Text = Model.tanggal_transaksi;
            Harga.Text = Model.harga_sewa.ToString();
            Pengambilan.Text = Model.tanggal_pengambilan;
            Pengembalian.Text = Model.tanggal_pengembalian;


            foreach (dynamic[] data in Model.Detail)
            {
                Judul.Text = data[0].ToString();
                Pengarang.Text = data[1].ToString();
                Penerbit.Text = $"{data[2]} {data[3]}";
                Genre.Text = data[4].ToString();
                if (data[5] != null && data[5].Length > 0) pictureBox1.Image = new Bitmap(new MemoryStream(data[5]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
