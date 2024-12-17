using Projek_SimBuku.Controller;
using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Buku;
using Projek_SimBuku.Views.Massage_Box;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projek_SimBuku.Controller.C_LoginRegister;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projek_SimBuku.Views.Pelanggan.Home
{
    public partial class Detail : Form
    {
        C_Home Controller;
        M_Buku data;
        int id;
        public Detail(C_Home controller, M_Buku data)
        {
            InitializeComponent();
            this.Controller = controller;
            this.data = data;
            if (data.Gambar != null && data.Gambar.Length > 0) pictureBox1.Image = new Bitmap(new MemoryStream(data.Gambar));
            label1.Text = data.Judul_buku;
            label2.Text = data.Genre;
            label3.Text = data.Pengarang;
            label4.Text = $"{data.Penerbit} - {data.Tahun_Terbit}";
            label5.Text = data.keterangan;
            label6.Text = data.Id_Buku.ToString();
            id = data.Id_Buku;
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void buttonAddKeranjang_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(label6.Text);
            var existingBook = M_Keranjang.StaticCartItems.FirstOrDefault(b => b.Id_Buku == bookId);
            if (existingBook != null)
            {
                MessageBox.Show("This book is already in your cart and cannot be rented again.");
                this.Close();
                return;
            }
            M_Keranjang keranjang = new M_Keranjang
            {
                Id_Buku = bookId,
                Judul_buku = label1.Text,
                Gambar = (byte[])new ImageConverter().ConvertTo(pictureBox1.Image, typeof(byte[])),
                Genre = label2.Text,
            };
            M_Keranjang.StaticCartItems.Add(keranjang);
            MessageBox.Show("Book has been added to your cart!");
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

