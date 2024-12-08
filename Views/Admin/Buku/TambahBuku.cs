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
    public partial class TambahBuku : UserControl
    {
        C_Buku buku;
        public TambahBuku(C_Buku c_Buku)
        {
            InitializeComponent();
            buku = c_Buku;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buku.Close();
        }
    }
}
