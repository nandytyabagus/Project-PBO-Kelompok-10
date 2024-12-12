using Projek_SimBuku.Controller;
using Projek_SimBuku.Model;
using System;
using System.Drawing;
using System.IO;
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

        public CRUtambah(M_Buku data, C_Buku c_Buku, bool edit, bool detail)
        {
            InitializeComponent();
            this.buku = c_Buku;
            buku.genre(this);
            EditMode = edit;
            DetailMode = detail;
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
                buku.EditBuku(this, data.Id_Buku);
            }
            else
            {
                buku.Tambahbuku(this);
            }
            this.Close();
        }

        private void CRUtambah_Load(object sender, EventArgs e)
        {
            if (EditMode || DetailMode)
            {
                if (data.Gambar != null && data.Gambar.Length > 0) pictureBox1.Image = new Bitmap(new MemoryStream(data.Gambar));
                judul.Text = data.Judul_buku;
                Jumlah.Text = data.Stok.ToString();
                pengarang.Text = data.Pengarang;
                penerbit.Text = data.Penerbit;
                tahunterbit.Text = data.Tahun_Terbit.ToString();
                BoxGenre.SelectedText = data.Genre;
                keterangan.Text = data.keterangan;

                if (EditMode)
                {
                    button3.Text = "Simpan";
                }

                if (DetailMode)
                {
                    button1.Visible = false;
                    button2.Text = "Kembali";
                    button3.Visible = false;

                    judul.Enabled = false;
                    Jumlah.Enabled = false;
                    pengarang.Enabled = false;
                    penerbit.Enabled = false;
                    tahunterbit.Enabled = false;
                    BoxGenre.Enabled = false;
                    keterangan.Enabled = false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Choose Image(*.JPG;*.PNG)|*.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }
    }
}