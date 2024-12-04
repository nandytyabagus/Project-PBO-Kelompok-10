using Projek_SimBuku.Controller;
using Projek_SimBuku.Views.Dashboard;
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
    public partial class Home : UserControl
    {
        C_Homepage Controller;
        C_Home c_home;
        public Home(C_Homepage controller)
        {
            InitializeComponent();
            this.Controller = controller;
            c_home = new C_Home(controller, this);
        }
    }
}
