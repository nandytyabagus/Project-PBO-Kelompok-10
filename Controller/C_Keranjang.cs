using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Buku;
using Projek_SimBuku.Views.Massage_Box;
using Projek_SimBuku.Views.Pelanggan;
using Projek_SimBuku.Views.Pelanggan.Home;
using Projek_SimBuku.Views.Pelanggan.Transaksi;
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
        M_Keranjang keranjang = new M_Keranjang();
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
                Size = new Size(250, 435),
                TabIndex = 1,
            };

            PictureBox Foto = new PictureBox
            {
                Image = new Bitmap(new MemoryStream(keranjang.Buku.Gambar)),
                Location = new Point(15, 45),
                Name = "pictureBox1",
                Size = new Size(220, 320),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 0,
                TabStop = false,
            };

            System.Windows.Forms.Label Judul = new System.Windows.Forms.Label
            {
                Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(15, 368),
                Name = "label1",
                Size = new Size(220, 62),
                TabIndex = 0,
                Text = keranjang.Buku.Judul_buku,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Button Delete = new Button
            {
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.Delete,
                BackgroundImageLayout = ImageLayout.Stretch,
                FlatAppearance = { BorderSize = 0 },
                FlatStyle = FlatStyle.Flat,
                Location = new Point(205, 10),
                Name = "Delete",
                Size = new Size(30, 30),
                TabIndex = 2,
                UseVisualStyleBackColor = false,
            };
            CheckBox Check = new CheckBox
            {
                AutoSize = true,
                FlatAppearance = { BorderSize = 0 },
                FlatStyle = FlatStyle.Flat,
                Location = new Point(15, 13),
                Name = "checkBox_keranjang",
                Size = new Size(35, 24),
                TabIndex = 2,
                Text = "  ",
                UseVisualStyleBackColor = true,
            };
            Check.CheckedChanged += (sender, e) =>
            {
                
            };
            Katalog.Controls.Add(Check);
            Katalog.Controls.Add(Delete);
            Katalog.Controls.Add(Foto);
            Katalog.Controls.Add(Judul);

            vkeranjang.flowLayoutPanel1.Controls.Add(Katalog);
        }

        public void LoadKeranjang()
        {
            vkeranjang.flowLayoutPanel1.Controls.Clear();
            List<M_Keranjang> keranjang = getDataKeranjang(M_Session.Id);
            foreach (var buku in keranjang)
            {
                Create(buku);
            }
        }
    }
}

