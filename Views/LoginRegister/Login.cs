
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Projek_SimBuku.Views
{
    public partial class Login : UserControl
    {
        C_LoginRegister Controller;
        public Login(C_LoginRegister controller)
        {
            InitializeComponent();
            Controller = controller;
            textBoxPassword.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controller.Vregister = new Register(Controller);
            Controller.switchView(Controller.Vregister);
        }

        private void checkBox_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Password.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            Controller.Login();
        }
    }
}
