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

namespace Projek_SimBuku.Views.Pelanggan
{
    public partial class Setting : UserControl
    {
        C_Homepage Controller;
        public Setting(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.logOut_Pelanggan();
        }
    }
}
