namespace Projek_SimBuku.Views
{
    partial class Login
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
            panel_Username = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            textBoxUsername = new TextBox();
            panel_Password = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            textBoxPassword = new TextBox();
            checkBox_Password = new CheckBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            buttonMasuk = new Button();
            label1 = new Label();
            panel_Username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_Username
            // 
            panel_Username.Controls.Add(pictureBox1);
            panel_Username.Controls.Add(panel3);
            panel_Username.Controls.Add(textBoxUsername);
            panel_Username.Location = new Point(219, 136);
            panel_Username.Name = "panel_Username";
            panel_Username.Size = new Size(317, 54);
            panel_Username.TabIndex = 32;
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
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(59, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 1);
            panel3.TabIndex = 4;
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
            panel_Password.Location = new Point(219, 215);
            panel_Password.Name = "panel_Password";
            panel_Password.Size = new Size(317, 54);
            panel_Password.TabIndex = 33;
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
            // checkBox_Password
            // 
            checkBox_Password.AutoSize = true;
            checkBox_Password.Location = new Point(389, 289);
            checkBox_Password.Name = "checkBox_Password";
            checkBox_Password.Size = new Size(132, 24);
            checkBox_Password.TabIndex = 40;
            checkBox_Password.Text = "Show Password";
            checkBox_Password.UseVisualStyleBackColor = true;
            checkBox_Password.CheckedChanged += checkBox_Password_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 424);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 39;
            label4.Text = "Don't Have Account ?";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(404, 424);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 20);
            linkLabel1.TabIndex = 38;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrasi Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.Location = new Point(278, 266);
            label3.Name = "label3";
            label3.Size = new Size(236, 20);
            label3.TabIndex = 37;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.Location = new Point(278, 189);
            label2.Name = "label2";
            label2.Size = new Size(236, 20);
            label2.TabIndex = 34;
            label2.Text = "label2";
            // 
            // buttonMasuk
            // 
            buttonMasuk.BackColor = Color.Cyan;
            buttonMasuk.BackgroundImageLayout = ImageLayout.None;
            buttonMasuk.FlatAppearance.BorderColor = Color.White;
            buttonMasuk.FlatAppearance.BorderSize = 0;
            buttonMasuk.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonMasuk.FlatAppearance.MouseOverBackColor = Color.Black;
            buttonMasuk.FlatStyle = FlatStyle.Flat;
            buttonMasuk.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMasuk.ForeColor = Color.White;
            buttonMasuk.Location = new Point(310, 350);
            buttonMasuk.Name = "buttonMasuk";
            buttonMasuk.Size = new Size(149, 40);
            buttonMasuk.TabIndex = 36;
            buttonMasuk.Text = "MASUK";
            buttonMasuk.UseVisualStyleBackColor = false;
            buttonMasuk.Click += buttonMasuk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Myanmar Text", 15F, FontStyle.Bold);
            label1.Location = new Point(340, 57);
            label1.Name = "label1";
            label1.Size = new Size(84, 44);
            label1.TabIndex = 35;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel_Username);
            Controls.Add(panel_Password);
            Controls.Add(checkBox_Password);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonMasuk);
            Controls.Add(label1);
            Name = "Login";
            Size = new Size(750, 500);
            Load += Login_Load;
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

        private Panel panel_Username;
        private PictureBox pictureBox1;
        private Panel panel3;
        public TextBox textBoxUsername;
        private Panel panel_Password;
        private PictureBox pictureBox2;
        private Panel panel4;
        public TextBox textBoxPassword;
        private CheckBox checkBox_Password;
        private Label label4;
        private LinkLabel linkLabel1;
        public Label label3;
        public Label label2;
        private Button buttonMasuk;
        private Label label1;
    }
}
