using Projek_SimBuku.Controller;
using Projek_SimBuku.Views.Dashboard;
using Projek_SimBuku.Views.Pelanggan.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_SimBuku.Views.Pelanggan
{
    public partial class HomeKatalog : UserControl
    {
        C_Homepage Controller;
        C_Home c_home;
        public HomeKatalog(C_Homepage controller)
        {
            InitializeComponent();
            this.Controller = controller;
            c_home = new C_Home(controller, this);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            c_home.Load_Katalog();
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            c_home.Search(Search.Text);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
