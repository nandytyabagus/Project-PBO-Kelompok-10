namespace Projek_SimBuku.Views
{
    partial class HomePage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            button_Hide = new Button();
            button_Exit = new Button();
            panel2 = new Panel();
            buttonDashboard = new Button();
            buttonBuku = new Button();
            buttonPeminjaman = new Button();
            buttonPengembalian = new Button();
            buttonLogout = new Button();
            panelSideBar = new Panel();
            panel3 = new Panel();
            buttonTransaksi = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panelSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // button_Hide
            // 
            button_Hide.FlatAppearance.BorderSize = 0;
            button_Hide.FlatStyle = FlatStyle.Flat;
            button_Hide.Location = new Point(1818, 0);
            button_Hide.Name = "button_Hide";
            button_Hide.Size = new Size(52, 40);
            button_Hide.TabIndex = 1;
            button_Hide.Text = "-";
            button_Hide.UseVisualStyleBackColor = true;
            button_Hide.Click += button_Hide_Click;
            // 
            // button_Exit
            // 
            button_Exit.FlatAppearance.BorderSize = 0;
            button_Exit.FlatStyle = FlatStyle.Flat;
            button_Exit.Location = new Point(1868, 0);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(52, 40);
            button_Exit.TabIndex = 0;
            button_Exit.Text = "X";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button_Hide);
            panel2.Controls.Add(button_Exit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1920, 40);
            panel2.TabIndex = 2;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.Transparent;
            buttonDashboard.BackgroundImage = Properties.Resources.Frame_22__1_;
            buttonDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(0, 257);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(120, 12, 0, 0);
            buttonDashboard.Size = new Size(402, 100);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // buttonBuku
            // 
            buttonBuku.BackColor = Color.Transparent;
            buttonBuku.BackgroundImage = Properties.Resources.Frame_22__2_;
            buttonBuku.FlatAppearance.BorderSize = 0;
            buttonBuku.FlatStyle = FlatStyle.Flat;
            buttonBuku.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold);
            buttonBuku.ForeColor = Color.White;
            buttonBuku.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBuku.Location = new Point(0, 365);
            buttonBuku.Name = "buttonBuku";
            buttonBuku.Padding = new Padding(120, 12, 0, 0);
            buttonBuku.Size = new Size(402, 100);
            buttonBuku.TabIndex = 2;
            buttonBuku.TextAlign = ContentAlignment.MiddleLeft;
            buttonBuku.UseVisualStyleBackColor = false;
            buttonBuku.Click += buttonBuku_Click;
            // 
            // buttonPeminjaman
            // 
            buttonPeminjaman.BackColor = Color.Transparent;
            buttonPeminjaman.BackgroundImage = Properties.Resources.Frame_22__3_1;
            buttonPeminjaman.FlatAppearance.BorderSize = 0;
            buttonPeminjaman.FlatStyle = FlatStyle.Flat;
            buttonPeminjaman.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold);
            buttonPeminjaman.ForeColor = Color.White;
            buttonPeminjaman.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPeminjaman.Location = new Point(0, 473);
            buttonPeminjaman.Name = "buttonPeminjaman";
            buttonPeminjaman.Padding = new Padding(120, 12, 0, 0);
            buttonPeminjaman.Size = new Size(402, 100);
            buttonPeminjaman.TabIndex = 3;
            buttonPeminjaman.TextAlign = ContentAlignment.MiddleLeft;
            buttonPeminjaman.UseVisualStyleBackColor = false;
            buttonPeminjaman.Click += buttonPeminjaman_Click;
            // 
            // buttonPengembalian
            // 
            buttonPengembalian.BackColor = Color.Transparent;
            buttonPengembalian.BackgroundImage = Properties.Resources.Frame_22__4_;
            buttonPengembalian.FlatAppearance.BorderSize = 0;
            buttonPengembalian.FlatStyle = FlatStyle.Flat;
            buttonPengembalian.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold);
            buttonPengembalian.ForeColor = Color.White;
            buttonPengembalian.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPengembalian.Location = new Point(0, 581);
            buttonPengembalian.Name = "buttonPengembalian";
            buttonPengembalian.Padding = new Padding(120, 12, 0, 0);
            buttonPengembalian.Size = new Size(402, 100);
            buttonPengembalian.TabIndex = 4;
            buttonPengembalian.TextAlign = ContentAlignment.MiddleLeft;
            buttonPengembalian.UseVisualStyleBackColor = false;
            buttonPengembalian.Click += buttonPengembalian_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackgroundImage = (Image)resources.GetObject("buttonLogout.BackgroundImage");
            buttonLogout.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Location = new Point(12, 968);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(60, 60);
            buttonLogout.TabIndex = 5;
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.Transparent;
            panelSideBar.BackgroundImage = Properties.Resources.Frame_10__3_;
            panelSideBar.Controls.Add(panel3);
            panelSideBar.Controls.Add(buttonTransaksi);
            panelSideBar.Controls.Add(buttonLogout);
            panelSideBar.Controls.Add(buttonPengembalian);
            panelSideBar.Controls.Add(buttonPeminjaman);
            panelSideBar.Controls.Add(buttonBuku);
            panelSideBar.Controls.Add(buttonDashboard);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 40);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(402, 1040);
            panelSideBar.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Rectangle_71;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 183);
            panel3.TabIndex = 11;
            // 
            // buttonTransaksi
            // 
            buttonTransaksi.BackColor = Color.Transparent;
            buttonTransaksi.BackgroundImage = Properties.Resources.Frame_22__5_;
            buttonTransaksi.FlatAppearance.BorderSize = 0;
            buttonTransaksi.FlatStyle = FlatStyle.Flat;
            buttonTransaksi.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold);
            buttonTransaksi.ForeColor = Color.White;
            buttonTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransaksi.Location = new Point(0, 689);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Padding = new Padding(120, 12, 0, 0);
            buttonTransaksi.Size = new Size(402, 100);
            buttonTransaksi.TabIndex = 10;
            buttonTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            buttonTransaksi.UseVisualStyleBackColor = false;
            buttonTransaksi.Click += buttonTransaksi_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(402, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1518, 1040);
            panel1.TabIndex = 4;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel1);
            Controls.Add(panelSideBar);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainFrame";
            panel2.ResumeLayout(false);
            panelSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button_Hide;
        private Button button_Exit;
        private Panel panel2;
        private Button buttonDashboard;
        private Button buttonBuku;
        private Button buttonPeminjaman;
        private Button buttonPengembalian;
        private Button buttonLogout;
        private Panel panelSideBar;
        public Panel panel1;
        private Button buttonTransaksi;
        private Panel panel3;
    }
}