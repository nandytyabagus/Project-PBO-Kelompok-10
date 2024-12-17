namespace Projek_SimBuku.Views.Pelanggan.Transaksi
{
    partial class FormTransaksi
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
            Close_Button = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // Close_Button
            // 
            Close_Button.BackColor = Color.Red;
            Close_Button.FlatAppearance.BorderSize = 0;
            Close_Button.FlatStyle = FlatStyle.Flat;
            Close_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_Button.Location = new Point(510, 0);
            Close_Button.Margin = new Padding(0);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(40, 40);
            Close_Button.TabIndex = 0;
            Close_Button.Text = "X";
            Close_Button.UseVisualStyleBackColor = false;
            Close_Button.Click += Close_Button_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 450);
            panel1.TabIndex = 1;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 450);
            Controls.Add(Close_Button);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTransaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buat_Transaksi";
            ResumeLayout(false);
        }

        #endregion
        public Panel panel1;
        public Button Close_Button;
    }
}