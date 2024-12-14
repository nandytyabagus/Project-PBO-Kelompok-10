using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Pelanggan;
using Projek_SimBuku.Views.Pelanggan.Home;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Controller
{
    public class C_Keranjang : Connector
    {
        C_Homepage hompage;
        Keranjang vkeranjang;
        public C_Keranjang(C_Homepage c_Homepage,Keranjang view) 
        {
            hompage = c_Homepage;
            vkeranjang = view;
        }
        public List<M_Keranjang> getDataKeranjang(int id)
        {
            List<M_Keranjang> m_Keranjangs = new List<M_Keranjang>();
            DataTable data = Execute_With_Return($"SELECT Keranjang.ID_Keranjang,Buku.Id_Buku,Buku.Judul_Buku,genre.genre,Buku.Penerbit,Buku.Pengarang,Buku.Tahun_Terbit,Buku.Gambar,data_akun.Id_Akun FROM Keranjang JOIN Buku ON Keranjang.ID_Keranjang = Buku.Id_Buku LEFT JOIN genre ON Buku.Id_Buku = genre.Id_genre JOIN data_akun ON Keranjang.ID_Keranjang = data_akun.Id_Akun WHERE data_akun.Id_Akun = {id};");
            
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
        public void CreateKatalog(M_Keranjang keranjang)
        {
            if (keranjang.Buku.Gambar != null && keranjang.Buku.Gambar.Length > 0)
            {
                Panel Katalog = new Panel
                {
                    BackColor = Color.White,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(35, 30),
                    Margin = new Padding(35, 30, 0, 0),
                    Name = "Katalog",
                    Size = new Size(250, 400),
                    TabIndex = 0,
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
                Foto.DoubleClick += (object sender, EventArgs e) =>
                {

                };

                System.Windows.Forms.Label judul = new System.Windows.Forms.Label
                {
                    Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(15, 337),
                    Name = "label1",
                    Size = new Size(220, 62),
                    TabIndex = 0,
                    Text = keranjang.Buku.Judul_buku,
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                Katalog.Controls.Add(Foto);
                Katalog.Controls.Add(judul);
                vkeranjang.flowLayoutPanel1.Controls.Add(Katalog);
            }
            else
            {
                Panel Katalog = new Panel
                {
                    BackColor = Color.White,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(35, 30),
                    Margin = new Padding(35, 30, 0, 0),
                    Name = "Katalog",
                    Size = new Size(250, 400),
                    TabIndex = 0,
                };

                PictureBox Foto = new PictureBox
                {
                    Image = Properties.Resources.Frame_11__1_,
                    Location = new Point(15, 15),
                    Name = "pictureBox1",
                    Size = new Size(220, 320),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    TabIndex = 1,
                    TabStop = false,
                };
                Foto.DoubleClick += (object sender, EventArgs e) =>
                {

                };

                System.Windows.Forms.Label judul = new System.Windows.Forms.Label
                {
                    Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(15, 337),
                    Name = "label1",
                    Size = new Size(220, 62),
                    TabIndex = 0,
                    Text = keranjang.Buku.Judul_buku,
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                Katalog.Controls.Add(Foto);
                Katalog.Controls.Add(judul);
                vkeranjang.flowLayoutPanel1.Controls.Add(Katalog);
            }
        }
        public void Load_Katalog()
        {
            int id_ = M_Akun.id_akun;
            vkeranjang.flowLayoutPanel1.Controls.Clear();
            List<M_Keranjang> keranjang = getDataKeranjang(id_);
            foreach (var buku in keranjang)
            {
                CreateKatalog(buku);
            }
        }
    }
}
