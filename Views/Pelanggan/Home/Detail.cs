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

namespace Projek_SimBuku.Views.Pelanggan.Home
{
    public partial class Detail : Form
    {
        C_Home Controller;
        M_Buku data;
        public Detail(C_Home controller, M_Buku data)
        {
            InitializeComponent();
            this.Controller = controller;
            this.data = data;
            if (data.Gambar != null && data.Gambar.Length > 0) pictureBox1.Image = new Bitmap(new MemoryStream(data.Gambar));
            label1.Text = data.Judul_buku;
            label2.Text = data.Genre;
            label3.Text = data.Pengarang;
            label4.Text = data.Penerbit;
            label5.Text = data.keterangan;
            label6.Text = data.Id_Buku.ToString();
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            
        }

        private void buttonAddKeranjang_Click(object sender, EventArgs e)
        {
            Controller.Execute_No_Return($"INSERT INTO keranjang (id_buku, id_akun) VALUES ({label6.Text},{M_Akun.id_akun})");
            this.Close();
        }
    }
}
