namespace QuanLyNhanSu
{
    partial class FormPhuCap
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
            groupBox1 = new GroupBox();
            CbxPhuCap = new ComboBox();
            groupBox2 = new GroupBox();
            BtnXong = new Button();
            BtnThemPhuCap = new Button();
            TxtTongTien = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            DgvPhuCap = new DataGridView();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPhuCap).BeginInit();
            SuspendLayout();

            // 
            // label3 - Tiêu đề
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(35, 55, 80);
            label3.Location = new Point(25, 15);
            label3.Name = "label3";
            label3.Size = new Size(300, 48);
            label3.TabIndex = 11;
            label3.Text = "TÍNH PHỤ CẤP";

            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CbxPhuCap);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(45, 65, 90);
            groupBox1.Location = new Point(25, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1424, 280);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phụ cấp";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(25, 55);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 5;
            label2.Text = "Tên phụ cấp:";

            // 
            // CbxPhuCap
            // 
            CbxPhuCap.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxPhuCap.Font = new Font("Segoe UI", 11F);
            CbxPhuCap.FormattingEnabled = true;
            CbxPhuCap.Location = new Point(180, 50);
            CbxPhuCap.Name = "CbxPhuCap";
            CbxPhuCap.Size = new Size(650, 38);
            CbxPhuCap.TabIndex = 6;

            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnXong);
            groupBox2.Controls.Add(BtnThemPhuCap);
            groupBox2.Controls.Add(TxtTongTien);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(20, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1380, 140);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;

            // 
            // BtnThemPhuCap
            // 
            BtnThemPhuCap.BackColor = Color.FromArgb(46, 125, 80);
            BtnThemPhuCap.FlatStyle = FlatStyle.Flat;
            BtnThemPhuCap.FlatAppearance.BorderSize = 0;
            BtnThemPhuCap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnThemPhuCap.ForeColor = Color.White;
            BtnThemPhuCap.Location = new Point(40, 45);
            BtnThemPhuCap.Name = "BtnThemPhuCap";
            BtnThemPhuCap.Size = new Size(220, 50);
            BtnThemPhuCap.TabIndex = 33;
            BtnThemPhuCap.Text = "Thêm phụ cấp";
            BtnThemPhuCap.UseVisualStyleBackColor = false;
            BtnThemPhuCap.Click += BtnThemPhuCap_Click;

            // 
            // BtnXong
            // 
            BtnXong.BackColor = Color.FromArgb(41, 113, 170);
            BtnXong.FlatStyle = FlatStyle.Flat;
            BtnXong.FlatAppearance.BorderSize = 0;
            BtnXong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnXong.ForeColor = Color.White;
            BtnXong.Location = new Point(280, 45);
            BtnXong.Name = "BtnXong";
            BtnXong.Size = new Size(220, 50);
            BtnXong.TabIndex = 33;
            BtnXong.Text = "Xong";
            BtnXong.UseVisualStyleBackColor = false;
            BtnXong.Click += BtnXong_Click;

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 65, 90);
            label5.Location = new Point(800, 55);
            label5.Name = "label5";
            label5.Size = new Size(110, 30);
            label5.TabIndex = 5;
            label5.Text = "Tổng tiền:";

            // 
            // TxtTongTien
            // 
            TxtTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtTongTien.ForeColor = Color.FromArgb(46, 125, 80);
            TxtTongTien.BackColor = Color.FromArgb(240, 248, 243);
            TxtTongTien.Location = new Point(930, 50);
            TxtTongTien.Name = "TxtTongTien";
            TxtTongTien.ReadOnly = true;
            TxtTongTien.Size = new Size(400, 39);
            TxtTongTien.TabIndex = 6;
            TxtTongTien.TextAlign = HorizontalAlignment.Right;

            // 
            // DgvPhuCap
            // 
            DgvPhuCap.AllowUserToAddRows = false;
            DgvPhuCap.AllowUserToDeleteRows = false;
            DgvPhuCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPhuCap.BackgroundColor = Color.White;
            DgvPhuCap.BorderStyle = BorderStyle.None;
            DgvPhuCap.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvPhuCap.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvPhuCap.ColumnHeadersHeight = 48;
            DgvPhuCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvPhuCap.Dock = DockStyle.Bottom;
            DgvPhuCap.EnableHeadersVisualStyles = false;
            DgvPhuCap.GridColor = Color.FromArgb(230, 234, 240);
            DgvPhuCap.Location = new Point(0, 390);
            DgvPhuCap.Name = "DgvPhuCap";
            DgvPhuCap.ReadOnly = true;
            DgvPhuCap.RowHeadersVisible = false;
            DgvPhuCap.RowHeadersWidth = 82;
            DgvPhuCap.RowTemplate.Height = 45;
            DgvPhuCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPhuCap.MultiSelect = false;

            DgvPhuCap.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            DgvPhuCap.DefaultCellStyle.ForeColor = Color.FromArgb(50, 55, 65);
            DgvPhuCap.DefaultCellStyle.BackColor = Color.White;
            DgvPhuCap.DefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 232, 248);
            DgvPhuCap.DefaultCellStyle.SelectionForeColor = Color.FromArgb(35, 55, 80);
            DgvPhuCap.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            DgvPhuCap.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 252);
            DgvPhuCap.TabIndex = 12;

            // 
            // FormPhuCap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1474, 929);
            Controls.Add(DgvPhuCap);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "FormPhuCap";
            Text = "Tính phụ cấp";

            Load += FormPhuCap_Load;

            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPhuCap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnXong;
        private Button BtnThemPhuCap;
        private Label label2;
        private Label label3;
        private TextBox TxtTongTien;
        private Label label5;
        private DataGridView DgvPhuCap;
        private ComboBox CbxPhuCap;
    }
}