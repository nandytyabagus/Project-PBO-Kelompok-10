namespace Projek_SimBuku.Views
{
    partial class Homepage_pelanggan
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
            button_Hide = new Button();
            button_Exit = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel2.Controls.Add(button_Hide);
            panel2.Controls.Add(button_Exit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1920, 40);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 65, 75);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 150);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(150, 60);
            label1.Name = "label1";
            label1.Size = new Size(162, 41);
            label1.TabIndex = 5;
            label1.Text = "NAMA AKUN";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(40, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Frame_24__3_;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(1670, 0);
            button4.Name = "button4";
            button4.Size = new Size(250, 150);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Frame_24__2_;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1420, 0);
            button3.Name = "button3";
            button3.Size = new Size(250, 150);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Frame_24__1_;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1170, 0);
            button2.Name = "button2";
            button2.Size = new Size(250, 150);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Frame_24;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(920, 0);
            button1.Name = "button1";
            button1.Size = new Size(250, 150);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(1920, 890);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // Homepage_pelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homepage_pelanggan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage_pelanggan";
            Load += Homepage_pelanggan_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_Hide;
        private Button button_Exit;
        private Panel panel2;
        private Panel panel1;
        public Panel panel3;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        public Label label1;
        public PictureBox pictureBox1;
    }
}