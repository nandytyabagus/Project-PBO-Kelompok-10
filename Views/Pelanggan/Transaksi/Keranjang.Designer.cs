namespace Projek_SimBuku.Views.Pelanggan
{
    partial class Keranjang
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            Katalog = new Panel();
            pictureBox1 = new PictureBox();
            button_Transaksi = new RJRadioButton();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            flowLayoutPanel1.SuspendLayout();
            Katalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackgroundImage = Properties.Resources._2df56124_0a5c_431b_9c93_b3fd95214eef;
            flowLayoutPanel1.Controls.Add(Katalog);
            flowLayoutPanel1.Location = new Point(60, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1800, 690);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Katalog
            // 
            Katalog.BackColor = Color.White;
            Katalog.BackgroundImageLayout = ImageLayout.Stretch;
            Katalog.Controls.Add(pictureBox1);
            Katalog.Controls.Add(button_Transaksi);
            Katalog.Controls.Add(label1);
            Katalog.Location = new Point(35, 30);
            Katalog.Margin = new Padding(35, 30, 0, 0);
            Katalog.Name = "Katalog";
            Katalog.Size = new Size(250, 400);
            Katalog.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button_Transaksi
            // 
            button_Transaksi.CheckedColor = SystemColors.AppWorkspace;
            button_Transaksi.FlatAppearance.BorderSize = 0;
            button_Transaksi.FlatStyle = FlatStyle.Flat;
            button_Transaksi.Font = new Font("Segoe UI", 9F);
            button_Transaksi.Location = new Point(15, 359);
            button_Transaksi.MinimumSize = new Size(0, 21);
            button_Transaksi.Name = "button_Transaksi";
            button_Transaksi.Padding = new Padding(10, 0, 0, 0);
            button_Transaksi.Size = new Size(30, 21);
            button_Transaksi.TabIndex = 2;
            button_Transaksi.TabStop = true;
            button_Transaksi.UnCheckedColor = Color.Black;
            button_Transaksi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 337);
            label1.Name = "label1";
            label1.Size = new Size(184, 62);
            label1.TabIndex = 1;
            label1.Text = "Judul Buku";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(60, 750);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1800, 80);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(1525, 11);
            button1.Name = "button1";
            button1.Size = new Size(261, 57);
            button1.TabIndex = 0;
            button1.Text = "Sewa";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1460, 29);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // Keranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Keranjang";
            Size = new Size(1920, 890);
            Load += Keranjang_Load;
            flowLayoutPanel1.ResumeLayout(false);
            Katalog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public FlowLayoutPanel flowLayoutPanel1;
        public Panel Katalog;
        public PictureBox pictureBox1;
        private Label label1;
        private RJRadioButton button_Transaksi;
        private Panel panel1;
        private Label label2;
        private Button button1;
    }
}
