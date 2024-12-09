using Projek_SimBuku.Controller;
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
    public partial class tambah : Form
    {
        C_Buku buku;
        public tambah(C_Buku c_Buku)
        {
            InitializeComponent();
            this.buku = c_Buku;
            buku.genre(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buku.Tambahbuku(this);
            this.Close();
        }
    }
}
