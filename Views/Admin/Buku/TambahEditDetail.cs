﻿using Projek_SimBuku.Controller;
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

namespace Projek_SimBuku.Views.Admin.Buku
{
    public partial class CRUtambah : Form
    {
        C_Buku buku;
        bool EditMode;
        bool DetailMode;
        M_Buku data;
        public CRUtambah(C_Buku c_Buku)
        {
            InitializeComponent();
            this.buku = c_Buku;
            buku.genre(this);
            EditMode = false;
            DetailMode = false;
        }
        public CRUtambah(M_Buku data, C_Buku c_Buku)
        {
            InitializeComponent();
            this.buku = c_Buku;
            buku.genre(this);
            EditMode = true;
            DetailMode = true;
            this.data = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                buku.EditBuku(this,data.Id_Buku);
            }
            else
            {
                buku.Tambahbuku(this);
            }
            this.Close();
        }

        private void CRUtambah_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                if (data.Gambar != null && data.Gambar.Length > 0) pictureBox1.Image = new Bitmap(new MemoryStream(data.Gambar));
                judul.Text = data.Judul_buku;
                Jumlah.Text = data.Stok.ToString();
                pengarang.Text = data.Pengarang;
                penerbit.Text = data.Penerbit;
                tahunterbit.Text = data.Tahun_Terbit.ToString();
                BoxGenre.SelectedText = data.Genre;
                keterangan.Text = data.keterangan;
            }
            else if (DetailMode)
            {
                if (data.Gambar != null && data.Gambar.Length > 0) pictureBox1.Image = new Bitmap(new MemoryStream(data.Gambar));
                judul.Text = data.Judul_buku;
                Jumlah.Text = data.Stok.ToString();
                pengarang.Text = data.Pengarang;
                penerbit.Text = data.Penerbit;
                tahunterbit.Text = data.Tahun_Terbit.ToString();
                BoxGenre.SelectedText = data.Genre;
                keterangan.Text = data.keterangan;
                Enabled = false;
            }
        }
    }
}
