namespace Projek_SimBuku.Views.Pelanggan.Home
{
    partial class Detail
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonAddKeranjang = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(321, 25);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(321, 65);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(321, 105);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(321, 145);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(321, 185);
            label5.Name = "label5";
            label5.Size = new Size(289, 240);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // buttonAddKeranjang
            // 
            buttonAddKeranjang.FlatAppearance.BorderSize = 0;
            buttonAddKeranjang.FlatStyle = FlatStyle.Flat;
            buttonAddKeranjang.Location = new Point(783, 379);
            buttonAddKeranjang.Name = "buttonAddKeranjang";
            buttonAddKeranjang.Size = new Size(192, 46);
            buttonAddKeranjang.TabIndex = 6;
            buttonAddKeranjang.Text = "button1";
            buttonAddKeranjang.UseVisualStyleBackColor = true;
            buttonAddKeranjang.Click += buttonAddKeranjang_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(920, 25);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // Detail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1000, 450);
            Controls.Add(label6);
            Controls.Add(buttonAddKeranjang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Detail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detail";
            Load += Detail_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox1;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        private Button buttonAddKeranjang;
        public Label label6;
    }
}