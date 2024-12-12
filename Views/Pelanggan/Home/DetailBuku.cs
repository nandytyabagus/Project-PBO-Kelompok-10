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

namespace Projek_SimBuku.Views.Pelanggan.Home
{
    public partial class DetailBuku : UserControl
    {
        C_Homepage Controller;
        C_Home c_home;
        public DetailBuku(C_Homepage controller)
        {
            InitializeComponent();
            this.Controller = controller;
            c_home = new C_Home(controller, this);
        }
    }
}
