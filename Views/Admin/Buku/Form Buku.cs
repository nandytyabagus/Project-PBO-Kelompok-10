using Projek_SimBuku.Controller;
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
    public partial class FormBuku : Form
    {
        C_Buku buku;
        public FormBuku(C_Buku c_Buku, M_Buku data, UserControl view)
        {
            InitializeComponent();
            this.buku = c_Buku;
            this.panel1.Controls.Add(view);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
