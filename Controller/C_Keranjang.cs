using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Buku;
using Projek_SimBuku.Views.Pelanggan;
using Projek_SimBuku.Views.Pelanggan.Home;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_SimBuku.Controller
{
    public class C_Keranjang : Connector
    {
        bool isikeranjang;
        int HargaSewa;
        C_Homepage hompage;
        Keranjang vkeranjang;
        public C_Keranjang(C_Homepage c_Homepage, Keranjang view)
        {
            hompage = c_Homepage;
            vkeranjang = view;
        }
        public List<M_Keranjang> getDataKeranjang(int id)
        {
            List<M_Keranjang> m_Keranjangs = new List<M_Keranjang>();
            DataTable data = Execute_With_Return($"SELECT k.id_keranjang, k.id_akun, b.id_buku, b.judul_buku, b.penerbit, b.pengarang, b.tahun_terbit, g.genre, b.gambar FROM keranjang k JOIN buku b ON k.id_buku = b.id_buku LEFT JOIN genre g ON b.id_genre = g.id_genre WHERE k.id_akun = {id};");

            foreach (DataRow row in data.Rows)
            {
                M_Keranjang m_Keranjang = new M_Keranjang
                {
                    Id_Keranjang = Convert.ToInt32(row["ID_Keranjang"]),
                    Id_Buku = Convert.ToInt32(row["Id_Buku"]),
                    id_akun = Convert.ToInt32(row["Id_Akun"]),
                    Buku = new M_Buku
                    {
                        Id_Buku = Convert.ToInt32(row["Id_Buku"]),
                        Judul_buku = row["Judul_Buku"].ToString(),
                        Tahun_Terbit = Convert.ToInt32(row["Tahun_Terbit"]),
                        Gambar = row["Gambar"] != DBNull.Value ? (byte[])row["Gambar"] : new byte[0],
                        Penerbit = row["Penerbit"].ToString(),
                        Pengarang = row["Pengarang"].ToString(),
                        Genre = row["Genre"].ToString()
                    }
                };
                m_Keranjangs.Add(m_Keranjang);
            }
            return m_Keranjangs;
        }
        public void Create(M_Keranjang keranjang)
        {
            Panel Katalog = new Panel
            {
                BackColor = Color.White,
                BackgroundImageLayout = ImageLayout.Stretch,
                Location = new Point(35, 30),
                Margin = new Padding(35, 30, 0, 0),
                Name = "Katalog",
                Size = new Size(250, 400),
                TabIndex = 1,
            };

            PictureBox Foto = new PictureBox
            {
                Image = new Bitmap(new MemoryStream(keranjang.Buku.Gambar)),
                Location = new Point(15, 15),
                Name = "pictureBox1",
                Size = new Size(220, 320),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 1,
                TabStop = false,
            };

            System.Windows.Forms.Label judul = new System.Windows.Forms.Label
            {
                Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(51, 337),
                Name = "label1",
                Size = new Size(184, 62),
                TabIndex = 0,
                Text = keranjang.Buku.Judul_buku,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            RJRadioButton Button = new RJRadioButton
            {
                CheckedColor = SystemColors.AppWorkspace,
                FlatAppearance  = { BorderSize = 0 },
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F),
                Location = new Point(15, 359),
                MinimumSize = new Size(0, 21),
                Name = "button_Transaksi",
                Padding = new Padding(10, 0, 0, 0),
                Size = new Size(30, 21),
                TabIndex = 2,
                TabStop = true,
                UnCheckedColor = Color.Black,
                UseVisualStyleBackColor = true,
            };
            Katalog.Controls.Add(Button);
            Katalog.Controls.Add(Foto);
            Katalog.Controls.Add(judul);

            vkeranjang.flowLayoutPanel1.Controls.Add(Katalog);
        }

        public void LoadKatalog()
        {
            vkeranjang.flowLayoutPanel1.Controls.Clear();
            List<M_Keranjang> keranjang = getDataKeranjang(M_Session.Id);
            foreach (var buku in keranjang)
            {
                Create(buku);
            }
        }
        public void TotalSewa()
        {
            DataTable data = Execute_With_Return("SELECT ");
        }
    }
}

