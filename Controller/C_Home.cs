using Org.BouncyCastle.Asn1;
using Projek_SimBuku.Model;
using Projek_SimBuku.Properties;
using Projek_SimBuku.Views;
using Projek_SimBuku.Views.Buku;
using Projek_SimBuku.Views.Pelanggan;
using Projek_SimBuku.Views.Pelanggan.Home;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projek_SimBuku.Controller
{
    public class C_Home : Connector
    {
        C_Homepage c_Homepage;
        HomeKatalog Vhome;
        M_Buku mbuku;
        M_Akun m_Akun;
        Detail vdetail;
        public List<(int idAkun, int idBuku)> keranjangSementara = new List<(int, int)>();
        public C_Home(C_Homepage homepage, HomeKatalog home)
        {
            c_Homepage = homepage;
            Vhome = home;
        }
        public List<M_Buku> GetListBuku()
        {
            List<M_Buku> bukuList = new List<M_Buku>();
            DataTable data = Execute_With_Return("SELECT Buku.Id_Buku, Buku.Judul_Buku, Buku.Tahun_Terbit, Buku.Stok, Buku.Gambar, Buku.keterangan, Buku.pengarang, Buku.penerbit, genre.genre  FROM Buku JOIN Genre ON Buku.Id_Genre = Genre.Id_Genre WHERE stok > 0;");

            foreach (DataRow row in data.Rows)
            {
                M_Buku m_buku = new M_Buku
                {
                    Id_Buku = Convert.ToInt32(row["Id_Buku"]),
                    Judul_buku = row["Judul_Buku"].ToString(),
                    Tahun_Terbit = Convert.ToInt32(row["Tahun_Terbit"]),
                    Stok = Convert.ToInt32(row["Stok"]),
                    Gambar = row["Gambar"] != DBNull.Value ? (byte[])row["Gambar"] : new byte[0],
                    keterangan = row["keterangan"].ToString(),
                    Pengarang = row["pengarang"].ToString(),
                    Genre = row["Genre"].ToString(),
                    Penerbit = row["Penerbit"].ToString()
                };

                bukuList.Add(m_buku);
            }
            return bukuList;
        }
        public bool Search(string keyword)
        {
            List<M_Buku> hasil_pencarian = GetListBuku().Where(buku => buku.Judul_buku.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            Vhome.flowLayoutPanel1.Controls.Clear();

            if (hasil_pencarian.Count == 0)
            {
                return false;
            }

            foreach (var data in hasil_pencarian)
            {
                CreateKatalog(data);
            }
            return true;
        }
        public void CreateKatalog(M_Buku buku)
        {
            if (buku.Gambar != null && buku.Gambar.Length > 0)
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
                    Image = new Bitmap(new MemoryStream(buku.Gambar)),
                    Location = new Point(15, 15),
                    Name = "pictureBox1",
                    Size = new Size(220, 320),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    TabIndex = 1,
                    TabStop = false,
                };
                Foto.DoubleClick += (object sender, EventArgs e) =>
                {
                    Detail detail = new Detail(this, buku);
                    detail.ShowDialog();
                };

                System.Windows.Forms.Label judul = new System.Windows.Forms.Label
                {
                    Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(15, 337),
                    Name = "label1",
                    Size = new Size(220, 62),
                    TabIndex = 0,
                    Text = buku.Judul_buku,
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                Katalog.Controls.Add(Foto);
                Katalog.Controls.Add(judul);
                Vhome.flowLayoutPanel1.Controls.Add(Katalog);
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
                    Detail detail = new Detail(this, buku);
                    detail.ShowDialog();
                };

                System.Windows.Forms.Label judul = new System.Windows.Forms.Label
                {
                    Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(15, 337),
                    Name = "label1",
                    Size = new Size(220, 62),
                    TabIndex = 0,
                    Text = buku.Judul_buku,
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                Katalog.Controls.Add(Foto);
                Katalog.Controls.Add(judul);
                Vhome.flowLayoutPanel1.Controls.Add(Katalog);
            }

        }
        public void Load_Katalog()
        {
            Vhome.flowLayoutPanel1.Controls.Clear();
            List<M_Buku> data = GetListBuku();
            foreach (var buku in data)
            {
                CreateKatalog(buku);
            }
        }
        public bool CekPeminjaman(int idAkun, int idBuku)
        {
            string query = $"SELECT COUNT(*) FROM transaksi WHERE id_akun = {idAkun} AND id_buku = {idBuku} AND status != 'Dikembalikan';";
            DataTable result = Execute_With_Return(query);
            return result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0;
        }
    }
}
