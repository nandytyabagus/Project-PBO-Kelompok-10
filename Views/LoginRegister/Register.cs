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

namespace Projek_SimBuku.Views
{
    public partial class Register : UserControl
    {
        C_LoginRegister Controller;
        public Register(C_LoginRegister controller)
        {
            InitializeComponent();
            Controller = controller;
            textBoxPassword.PasswordChar = '*';
            textBoxConfirmPass.PasswordChar = '*';
        }
        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            Controller.Vlogin = new Login(Controller);
            Controller.switchView(Controller.Vlogin);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPass.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                textBoxConfirmPass.PasswordChar = '*';
            }
        }

        private void buttonRegistrasi_Click(object sender, EventArgs e)
        {

        }
    }
}
