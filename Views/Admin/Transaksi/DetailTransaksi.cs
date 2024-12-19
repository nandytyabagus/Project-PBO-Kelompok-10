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

namespace Projek_SimBuku.Views.Admin.Transaksi
{
    public partial class DetailTransaksi : Form
    {
        C_Transaksi Controller;
        M_Transaksi Data;
        public DetailTransaksi(C_Transaksi controller, M_Transaksi data)
        {
            InitializeComponent();
            Controller = controller;
            Data = data;
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DetailTransaksi_Load(object sender, EventArgs e)
        {
            Tanggal_transaksi.Text = Data.tanggal_transaksi;
            Harga.Text = Data.harga_sewa.ToString();
            Pengambilan.Text = Data.tanggal_pengambilan;
            Pengembalian.Text = Data.tanggal_pengembalian;


            foreach (dynamic[] data in Data.Detail)
            {
                Judul.Text = data[0].ToString();
                Pengarang.Text = data[1].ToString();
                Penerbit.Text = $"{data[2]} {data[3]}";
                Genre.Text = data[4].ToString();
                if (data[5] != null && data[5].Length > 0) pictureBox1.Image = new Bitmap(new MemoryStream(data[5]));
            }
            foreach (dynamic[] data in Data.DetailAkun)
            {
                Nama.Text = data[0].ToString();
                Email.Text = data[1].ToString();
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
