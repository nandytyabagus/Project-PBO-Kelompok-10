namespace Projek_SimBuku.Views.Pelanggan.Transaksi
{
    partial class Transfer
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(175, 375);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 0;
            button1.Text = "Lanjut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 25);
            label1.Name = "label1";
            label1.Size = new Size(241, 44);
            label1.TabIndex = 1;
            label1.Text = "Transfer Bank";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe MDL2 Assets", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 110);
            label2.Margin = new Padding(3, 20, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(222, 34);
            label2.TabIndex = 2;
            label2.Text = "Bank Maumaluet";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe MDL2 Assets", 13.8F);
            label3.Location = new Point(54, 164);
            label3.Margin = new Padding(3, 20, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 27);
            label3.TabIndex = 3;
            label3.Text = "No. Rekening";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe MDL2 Assets", 13.8F);
            label4.Location = new Point(54, 194);
            label4.Margin = new Padding(3, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 23);
            label4.TabIndex = 4;
            label4.Text = "7278924897234";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe MDL2 Assets", 13.8F, FontStyle.Bold);
            label5.Location = new Point(54, 237);
            label5.Margin = new Padding(3, 20, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 5;
            label5.Text = "Atas Nama";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe MDL2 Assets", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(54, 280);
            label6.Margin = new Padding(3, 20, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 6;
            label6.Text = "SIMBUKU";
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Transfer";
            Size = new Size(550, 450);
            Load += Transfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
