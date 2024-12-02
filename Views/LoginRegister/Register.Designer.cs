namespace Projek_SimBuku.Views
{
    partial class Register
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Nama = new Panel();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            textBoxNama = new TextBox();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            panel_Confirm = new Panel();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            textBoxConfirmPass = new TextBox();
            panel_Email = new Panel();
            pictureBox5 = new PictureBox();
            panel8 = new Panel();
            textBoxEmail = new TextBox();
            panel_NomorHp = new Panel();
            pictureBox6 = new PictureBox();
            panel10 = new Panel();
            textBoxNomorHp = new TextBox();
            panel_Username = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            textBoxUsername = new TextBox();
            panel_Password = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            textBoxPassword = new TextBox();
            buttonRegistrasi = new Button();
            label1 = new Label();
            panel_Nama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel_Confirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel_Email.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel_NomorHp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel_Username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_Nama
            // 
            panel_Nama.Controls.Add(pictureBox4);
            panel_Nama.Controls.Add(panel3);
            panel_Nama.Controls.Add(textBoxNama);
            panel_Nama.Location = new Point(398, 129);
            panel_Nama.Name = "panel_Nama";
            panel_Nama.Size = new Size(317, 54);
            panel_Nama.TabIndex = 36;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Logo_Username;
            pictureBox4.Location = new Point(16, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(59, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 1);
            panel3.TabIndex = 4;
            // 
            // textBoxNama
            // 
            textBoxNama.BackColor = SystemColors.Window;
            textBoxNama.BorderStyle = BorderStyle.None;
            textBoxNama.Cursor = Cursors.IBeam;
            textBoxNama.Font = new Font("Myanmar Text", 11F, FontStyle.Bold);
            textBoxNama.ForeColor = Color.Black;
            textBoxNama.Location = new Point(62, 13);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.PlaceholderText = "Nama";
            textBoxNama.Size = new Size(234, 35);
            textBoxNama.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(220, 322);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 32;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(419, 431);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 20);
            linkLabel1.TabIndex = 42;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(294, 431);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 41;
            label2.Text = "Sudah Punya Akun";
            // 
            // panel_Confirm
            // 
            panel_Confirm.Controls.Add(pictureBox3);
            panel_Confirm.Controls.Add(panel5);
            panel_Confirm.Controls.Add(textBoxConfirmPass);
            panel_Confirm.Location = new Point(35, 262);
            panel_Confirm.Name = "panel_Confirm";
            panel_Confirm.Size = new Size(317, 54);
            panel_Confirm.TabIndex = 35;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_Password;
            pictureBox3.Location = new Point(16, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(59, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(237, 1);
            panel5.TabIndex = 4;
            // 
            // textBoxConfirmPass
            // 
            textBoxConfirmPass.BackColor = SystemColors.Window;
            textBoxConfirmPass.BorderStyle = BorderStyle.None;
            textBoxConfirmPass.Cursor = Cursors.IBeam;
            textBoxConfirmPass.Font = new Font("Myanmar Text", 11F, FontStyle.Bold);
            textBoxConfirmPass.ForeColor = Color.Black;
            textBoxConfirmPass.Location = new Point(62, 13);
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.PlaceholderText = "Konfirmasi Password";
            textBoxConfirmPass.Size = new Size(234, 35);
            textBoxConfirmPass.TabIndex = 1;
            // 
            // panel_Email
            // 
            panel_Email.Controls.Add(pictureBox5);
            panel_Email.Controls.Add(panel8);
            panel_Email.Controls.Add(textBoxEmail);
            panel_Email.Location = new Point(398, 196);
            panel_Email.Name = "panel_Email";
            panel_Email.Size = new Size(317, 54);
            panel_Email.TabIndex = 37;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Logo_Email;
            pictureBox5.Location = new Point(16, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(59, 49);
            panel8.Name = "panel8";
            panel8.Size = new Size(237, 1);
            panel8.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.BackColor = SystemColors.Window;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Cursor = Cursors.IBeam;
            textBoxEmail.Font = new Font("Myanmar Text", 11F, FontStyle.Bold);
            textBoxEmail.ForeColor = Color.Black;
            textBoxEmail.Location = new Point(62, 13);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email";
            textBoxEmail.Size = new Size(234, 35);
            textBoxEmail.TabIndex = 1;
            // 
            // panel_NomorHp
            // 
            panel_NomorHp.Controls.Add(pictureBox6);
            panel_NomorHp.Controls.Add(panel10);
            panel_NomorHp.Controls.Add(textBoxNomorHp);
            panel_NomorHp.Location = new Point(398, 262);
            panel_NomorHp.Name = "panel_NomorHp";
            panel_NomorHp.Size = new Size(317, 54);
            panel_NomorHp.TabIndex = 39;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Logo_NomorHp;
            pictureBox6.Location = new Point(16, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(59, 49);
            panel10.Name = "panel10";
            panel10.Size = new Size(237, 1);
            panel10.TabIndex = 4;
            // 
            // textBoxNomorHp
            // 
            textBoxNomorHp.BackColor = SystemColors.Window;
            textBoxNomorHp.BorderStyle = BorderStyle.None;
            textBoxNomorHp.Cursor = Cursors.IBeam;
            textBoxNomorHp.Font = new Font("Myanmar Text", 11F, FontStyle.Bold);
            textBoxNomorHp.ForeColor = Color.Black;
            textBoxNomorHp.Location = new Point(62, 13);
            textBoxNomorHp.Name = "textBoxNomorHp";
            textBoxNomorHp.PlaceholderText = "Nomor HP";
            textBoxNomorHp.Size = new Size(234, 35);
            textBoxNomorHp.TabIndex = 1;
            // 
            // panel_Username
            // 
            panel_Username.Controls.Add(pictureBox1);
            panel_Username.Controls.Add(panel2);
            panel_Username.Controls.Add(textBoxUsername);
            panel_Username.Location = new Point(35, 129);
            panel_Username.Name = "panel_Username";
            panel_Username.Size = new Size(317, 54);
            panel_Username.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Username;
            pictureBox1.Location = new Point(16, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(59, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 1);
            panel2.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.BackColor = SystemColors.Window;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Cursor = Cursors.IBeam;
            textBoxUsername.Font = new Font("Myanmar Text", 11F, FontStyle.Bold);
            textBoxUsername.ForeColor = Color.Black;
            textBoxUsername.Location = new Point(62, 13);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username";
            textBoxUsername.Size = new Size(234, 35);
            textBoxUsername.TabIndex = 1;
            // 
            // panel_Password
            // 
            panel_Password.Controls.Add(pictureBox2);
            panel_Password.Controls.Add(panel4);
            panel_Password.Controls.Add(textBoxPassword);
            panel_Password.Location = new Point(35, 196);
            panel_Password.Name = "panel_Password";
            panel_Password.Size = new Size(317, 54);
            panel_Password.TabIndex = 34;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo_Password;
            pictureBox2.Location = new Point(16, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(59, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(237, 1);
            panel4.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.Window;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Font = new Font("Myanmar Text", 11F, FontStyle.Bold);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(62, 13);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(234, 35);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonRegistrasi
            // 
            buttonRegistrasi.BackColor = Color.Cyan;
            buttonRegistrasi.BackgroundImageLayout = ImageLayout.None;
            buttonRegistrasi.FlatAppearance.BorderColor = Color.White;
            buttonRegistrasi.FlatAppearance.BorderSize = 0;
            buttonRegistrasi.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonRegistrasi.FlatAppearance.MouseOverBackColor = Color.Black;
            buttonRegistrasi.FlatStyle = FlatStyle.Flat;
            buttonRegistrasi.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistrasi.ForeColor = Color.White;
            buttonRegistrasi.Location = new Point(307, 379);
            buttonRegistrasi.Name = "buttonRegistrasi";
            buttonRegistrasi.Size = new Size(149, 40);
            buttonRegistrasi.TabIndex = 40;
            buttonRegistrasi.Text = "TAMBAH";
            buttonRegistrasi.UseVisualStyleBackColor = false;
            buttonRegistrasi.Click += buttonRegistrasi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Myanmar Text", 15F, FontStyle.Bold);
            label1.Location = new Point(321, 50);
            label1.Name = "label1";
            label1.Size = new Size(116, 44);
            label1.TabIndex = 38;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel_Nama);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(panel_Confirm);
            Controls.Add(panel_Email);
            Controls.Add(panel_NomorHp);
            Controls.Add(panel_Username);
            Controls.Add(panel_Password);
            Controls.Add(buttonRegistrasi);
            Controls.Add(label1);
            Name = "Register";
            Size = new Size(750, 500);
            panel_Nama.ResumeLayout(false);
            panel_Nama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel_Confirm.ResumeLayout(false);
            panel_Confirm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel_Email.ResumeLayout(false);
            panel_Email.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel_NomorHp.ResumeLayout(false);
            panel_NomorHp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel_Username.ResumeLayout(false);
            panel_Username.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_Password.ResumeLayout(false);
            panel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Nama;
        private PictureBox pictureBox4;
        private Panel panel3;
        public TextBox textBoxNama;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Panel panel_Confirm;
        private PictureBox pictureBox3;
        private Panel panel5;
        public TextBox textBoxConfirmPass;
        private Panel panel_Email;
        private PictureBox pictureBox5;
        private Panel panel8;
        public TextBox textBoxEmail;
        private Panel panel_NomorHp;
        private PictureBox pictureBox6;
        private Panel panel10;
        public TextBox textBoxNomorHp;
        private Panel panel_Username;
        private PictureBox pictureBox1;
        private Panel panel2;
        public TextBox textBoxUsername;
        private Panel panel_Password;
        private PictureBox pictureBox2;
        private Panel panel4;
        public TextBox textBoxPassword;
        private Button buttonRegistrasi;
        private Label label1;
    }
}
