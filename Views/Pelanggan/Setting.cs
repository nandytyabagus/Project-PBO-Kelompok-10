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

namespace Projek_SimBuku.Views.Pelanggan
{
    public partial class Setting : UserControl
    {
        C_Homepage Controller;
        C_Profile Profile;
        public Setting(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            Profile = new C_Profile(Controller, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.logOut_Pelanggan();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            Profile.loadDataAkun();
        }
    }
}
