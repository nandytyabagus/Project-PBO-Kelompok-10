namespace Projek_SimBuku.Views.Admin.Buku
{
    partial class Detail_Buku
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
            Close = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            penerbit = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Close
            // 
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Location = new Point(471, 0);
            Close.Name = "Close";
            Close.Size = new Size(30, 30);
            Close.TabIndex = 0;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 36);
            label1.TabIndex = 2;
            label1.Text = "Judul";
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(penerbit);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(250, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 298);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buku;
            pictureBox1.Location = new Point(32, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Myanmar Text", 9F);
            label2.Location = new Point(0, 36);
            label2.Name = "label2";
            label2.Size = new Size(46, 27);
            label2.TabIndex = 3;
            label2.Text = "Judul";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            label3.Location = new Point(0, 72);
            label3.Name = "label3";
            label3.Size = new Size(71, 36);
            label3.TabIndex = 4;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Myanmar Text", 9F);
            label4.Location = new Point(0, 108);
            label4.Name = "label4";
            label4.Size = new Size(46, 27);
            label4.TabIndex = 5;
            label4.Text = "Judul";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            label5.Location = new Point(0, 144);
            label5.Name = "label5";
            label5.Size = new Size(116, 36);
            label5.TabIndex = 6;
            label5.Text = "Pengarang";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Myanmar Text", 9F);
            label6.Location = new Point(0, 180);
            label6.Name = "label6";
            label6.Size = new Size(46, 27);
            label6.TabIndex = 7;
            label6.Text = "Judul";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            label7.Location = new Point(0, 216);
            label7.Name = "label7";
            label7.Size = new Size(95, 36);
            label7.TabIndex = 8;
            label7.Text = "Penerbit";
            // 
            // penerbit
            // 
            penerbit.AutoSize = true;
            penerbit.FlatStyle = FlatStyle.Flat;
            penerbit.Font = new Font("Myanmar Text", 9F);
            penerbit.Location = new Point(0, 252);
            penerbit.Name = "penerbit";
            penerbit.Size = new Size(97, 27);
            penerbit.TabIndex = 9;
            penerbit.Text = "Tahun_Terbit";
            // 
            // Detail_Buku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 375);
            Controls.Add(pictureBox1);
            Controls.Add(Close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Detail_Buku";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detail_Buku";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Button Close;
        public Label label1;
        private Panel panel1;
        public PictureBox pictureBox1;
        public Label label5;
        public Label label4;
        public Label label3;
        public Label label2;
        public Label label6;
        public Label label7;
        public Label penerbit;
    }
}