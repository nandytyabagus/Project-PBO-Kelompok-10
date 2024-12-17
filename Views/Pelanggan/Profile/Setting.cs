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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            Profile.Get();
            Profile.loadDataAkun();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Choose Image(*.JPG;*.PNG;*.JPEG)|*.jpg;*.png;*.jpeg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
