namespace Projek_SimBuku.Views.Buku
{
    partial class Buku
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Search = new TextBox();
            button1 = new Button();
            buttonTambahBuku = new Button();
            panel2 = new Panel();
            TabelBuku = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabelBuku).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Frame_23;
            panel1.Controls.Add(Search);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(50, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 80);
            panel1.TabIndex = 0;
            // 
            // Search
            // 
            Search.BackColor = Color.White;
            Search.BorderStyle = BorderStyle.None;
            Search.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.ForeColor = Color.Black;
            Search.Location = new Point(105, 22);
            Search.Name = "Search";
            Search.PlaceholderText = "Search";
            Search.Size = new Size(272, 39);
            Search.TabIndex = 1;
            Search.TextChanged += Search_TextChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._7d72fdb8_53c5_4b02_8afc_59e6a8f86106;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources._02de674a_a51c_4cd4_bad8_25a1c70748c4;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(80, 80);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonTambahBuku
            // 
            buttonTambahBuku.BackColor = Color.Transparent;
            buttonTambahBuku.BackgroundImage = Properties.Resources.Frame_23__1_;
            buttonTambahBuku.FlatAppearance.BorderSize = 0;
            buttonTambahBuku.FlatStyle = FlatStyle.Flat;
            buttonTambahBuku.Location = new Point(1088, 50);
            buttonTambahBuku.Name = "buttonTambahBuku";
            buttonTambahBuku.Size = new Size(380, 80);
            buttonTambahBuku.TabIndex = 3;
            buttonTambahBuku.UseVisualStyleBackColor = false;
            buttonTambahBuku.Click += buttonTambahBuku_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources._38ad706e_f194_40e2_8a7e_48a4a97401b1;
            panel2.Controls.Add(TabelBuku);
            panel2.Location = new Point(50, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(1418, 750);
            panel2.TabIndex = 4;
            // 
            // TabelBuku
            // 
            TabelBuku.AllowUserToAddRows = false;
            TabelBuku.AllowUserToDeleteRows = false;
            TabelBuku.AllowUserToResizeColumns = false;
            TabelBuku.AllowUserToResizeRows = false;
            TabelBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelBuku.BackgroundColor = Color.White;
            TabelBuku.BorderStyle = BorderStyle.None;
            TabelBuku.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelBuku.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Myanmar Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TabelBuku.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TabelBuku.ColumnHeadersHeight = 29;
            TabelBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Myanmar Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TabelBuku.DefaultCellStyle = dataGridViewCellStyle2;
            TabelBuku.EnableHeadersVisualStyles = false;
            TabelBuku.Location = new Point(20, 20);
            TabelBuku.Margin = new Padding(3, 4, 3, 4);
            TabelBuku.Name = "TabelBuku";
            TabelBuku.ReadOnly = true;
            TabelBuku.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            TabelBuku.RowHeadersVisible = false;
            TabelBuku.RowHeadersWidth = 51;
            TabelBuku.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            TabelBuku.ScrollBars = ScrollBars.Vertical;
            TabelBuku.Size = new Size(1378, 710);
            TabelBuku.TabIndex = 0;
            TabelBuku.CellClick += TabelBuku_CellClick;
            TabelBuku.CellContentClick += TabelBuku_CellContentClick;
            // 
            // Buku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Frame_16;
            Controls.Add(panel2);
            Controls.Add(buttonTambahBuku);
            Controls.Add(panel1);
            Name = "Buku";
            Size = new Size(1518, 1040);
            Load += Buku_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TabelBuku).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox Search;
        private Button buttonTambahBuku;
        private Panel panel2;
        public DataGridView TabelBuku;
    }
}
