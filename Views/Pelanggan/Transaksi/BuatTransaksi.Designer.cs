namespace Projek_SimBuku.Views.Pelanggan.Transaksi
{
    partial class BuatTransaksi
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
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            Tunai = new RJRadioButton();
            E_wallet = new RJRadioButton();
            Transfer = new RJRadioButton();
            comboBox1 = new ComboBox();
            metode_pembayaran = new Panel();
            button2 = new Button();
            metode_pembayaran.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(323, 375);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 17;
            button1.Text = "Bayar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(26, 54);
            label4.Name = "label4";
            label4.Size = new Size(195, 28);
            label4.TabIndex = 16;
            label4.Text = "Durasi Peminjaman";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(26, 165);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(26, 134);
            label3.Name = "label3";
            label3.Size = new Size(214, 28);
            label3.TabIndex = 13;
            label3.Text = "Tanggal Pengambilan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(26, 213);
            label2.Name = "label2";
            label2.Size = new Size(176, 28);
            label2.TabIndex = 12;
            label2.Text = "Pilih Pembayaran";
            // 
            // Tunai
            // 
            Tunai.AutoSize = true;
            Tunai.CheckedColor = Color.FromArgb(61, 65, 75);
            Tunai.Font = new Font("Segoe UI", 10.2F);
            Tunai.Location = new Point(3, 69);
            Tunai.MinimumSize = new Size(0, 21);
            Tunai.Name = "Tunai";
            Tunai.Padding = new Padding(10, 0, 0, 0);
            Tunai.Size = new Size(82, 27);
            Tunai.TabIndex = 11;
            Tunai.TabStop = true;
            Tunai.Text = "Tunai";
            Tunai.UnCheckedColor = Color.Gray;
            Tunai.UseVisualStyleBackColor = true;
            // 
            // E_wallet
            // 
            E_wallet.AutoSize = true;
            E_wallet.CheckedColor = Color.FromArgb(61, 65, 75);
            E_wallet.Font = new Font("Segoe UI", 10.2F);
            E_wallet.Location = new Point(3, 3);
            E_wallet.MinimumSize = new Size(0, 21);
            E_wallet.Name = "E_wallet";
            E_wallet.Padding = new Padding(10, 0, 0, 0);
            E_wallet.Size = new Size(113, 27);
            E_wallet.TabIndex = 10;
            E_wallet.TabStop = true;
            E_wallet.Text = "E - Wallet";
            E_wallet.UnCheckedColor = Color.Gray;
            E_wallet.UseVisualStyleBackColor = true;
            // 
            // Transfer
            // 
            Transfer.AutoSize = true;
            Transfer.CheckedColor = Color.FromArgb(61, 65, 75);
            Transfer.Font = new Font("Segoe UI", 10.2F);
            Transfer.Location = new Point(3, 36);
            Transfer.MinimumSize = new Size(0, 21);
            Transfer.Name = "Transfer";
            Transfer.Padding = new Padding(10, 0, 0, 0);
            Transfer.Size = new Size(142, 27);
            Transfer.TabIndex = 18;
            Transfer.TabStop = true;
            Transfer.Text = "Transfer Bank";
            Transfer.UnCheckedColor = Color.Gray;
            Transfer.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "1 Hari";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 31);
            comboBox1.TabIndex = 14;
            comboBox1.ValueMember = "1";
            // 
            // metode_pembayaran
            // 
            metode_pembayaran.Controls.Add(Transfer);
            metode_pembayaran.Controls.Add(E_wallet);
            metode_pembayaran.Controls.Add(Tunai);
            metode_pembayaran.Location = new Point(26, 244);
            metode_pembayaran.Name = "metode_pembayaran";
            metode_pembayaran.Size = new Size(250, 125);
            metode_pembayaran.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new Point(26, 375);
            button2.Name = "button2";
            button2.Size = new Size(200, 50);
            button2.TabIndex = 20;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BuatTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(metode_pembayaran);
            Name = "BuatTransaksi";
            Size = new Size(550, 450);
            Load += BuatTransaksi_Load;
            metode_pembayaran.ResumeLayout(false);
            metode_pembayaran.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        public ComboBox comboBox1;
        public Panel metode_pembayaran;
        public DateTimePicker dateTimePicker1;
        public RJRadioButton Tunai;
        public RJRadioButton E_wallet;
        public RJRadioButton Transfer;
        private Button button2;
    }
}
