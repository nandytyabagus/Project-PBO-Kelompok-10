using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Buku;
using Projek_SimBuku.Views.Massage_Box;
using Projek_SimBuku.Views.Pelanggan;
using Projek_SimBuku.Views.Pelanggan.Home;
using Projek_SimBuku.Views.Pelanggan.Transaksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_SimBuku.Controller
{
    public class C_Keranjang : Connector
    {
        C_Homepage hompage;
        C_Transaksi c_Transaksi;
        Keranjang vkeranjang;
        BuatTransaksi vbuatTransaksi;

        public C_Keranjang(C_Homepage c_Homepage, Keranjang view)
        {
            hompage = c_Homepage;
            vkeranjang = view;
        }
        public void load()
        {
            List<M_Keranjang> keranjangList = M_Keranjang.StaticCartItems;
            vkeranjang.dataGridView1.DataSource = null;
            vkeranjang.dataGridView1.Columns.Clear();
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn
            {
                Name = "Delete",
                UseColumnTextForButtonValue = true,
                Text = "Delete"
            };
            vkeranjang.dataGridView1.DataSource = keranjangList;

            vkeranjang.dataGridView1.Columns["Id_Buku"].Visible = false;
            vkeranjang.dataGridView1.Columns["gambar"].HeaderText = "";
            vkeranjang.dataGridView1.Columns["Judul_buku"].HeaderText = "Judul";
            vkeranjang.dataGridView1.Columns["Genre"].HeaderText = "Genre";
            vkeranjang.dataGridView1.Columns.Add(Delete);
            vkeranjang.dataGridView1.Columns["Delete"].HeaderText = "";
        }


        public void DeleteFromCart(int idBuku)
        {
            var itemToRemove = M_Keranjang.StaticCartItems.FirstOrDefault(x => x.Id_Buku == idBuku);
            if (itemToRemove != null)
            {
                M_Keranjang.StaticCartItems.Remove(itemToRemove);
            }
        }

        public void buat_keranjang()
        {
            FormTransaksi view = new FormTransaksi(c_Transaksi, this, new BuatTransaksi(c_Transaksi,this));
            view.ShowDialog();
        }
    }
}
