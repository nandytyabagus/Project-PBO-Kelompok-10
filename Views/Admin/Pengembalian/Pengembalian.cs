using Projek_SimBuku.Controller;
using Projek_SimBuku.Model;
using Projek_SimBuku.Views.Peminjaman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_SimBuku.Views.Pengembalian
{
    public partial class Pengembalian : UserControl
    {
        C_Homepage Controller;
        C_Pengembalian pengembalian;
        public Pengembalian(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            pengembalian = new C_Pengembalian(controller, this);
        }

        private void Pengembalian_Load(object sender, EventArgs e)
        {
            pengembalian.LoadData();
        }

        private void dataPengembalian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataPengembalian.Rows[e.RowIndex].Cells["Id_Transaksi"].Value);
                if (e.ColumnIndex == dataPengembalian.Columns["Ubah Status"].Index)
                {
                    pengembalian.UpdateStatus(id);
                    pengembalian.LoadData();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Search.Text))
            {
                pengembalian.LoadData();
            }
            else
            {
                pengembalian.CariPengembalian(Search.Text);
            }
        }
    }
}
