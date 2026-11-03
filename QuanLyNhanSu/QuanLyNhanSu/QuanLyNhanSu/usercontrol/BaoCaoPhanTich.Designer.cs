namespace QuanLyNhanSu.usercontrol
{
    partial class BaoCaoPhanTich
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
            DgvBaoCao = new DataGridView();
            groupBox1 = new GroupBox();
            BtnXuatExcel = new Button();
            BtnLamMoi = new Button();
            BtnTimKiem = new Button();
            TxtTimKiem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            DtpNgaySau = new DateTimePicker();
            DtpNgayTruoc = new DateTimePicker();
            label3 = new Label();

            ((System.ComponentModel.ISupportInitialize)DgvBaoCao).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();

            // 
            // DgvBaoCao
            // 
            DgvBaoCao.AllowUserToAddRows = false;
            DgvBaoCao.AllowUserToDeleteRows = false;
            DgvBaoCao.AllowUserToResizeRows = false;
            DgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBaoCao.BackgroundColor = Color.White;
            DgvBaoCao.BorderStyle = BorderStyle.FixedSingle;
            DgvBaoCao.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvBaoCao.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DgvBaoCao.ColumnHeadersHeight = 50;
            DgvBaoCao.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvBaoCao.Dock = DockStyle.Fill;
            DgvBaoCao.EnableHeadersVisualStyles = false;
            DgvBaoCao.GridColor = Color.FromArgb(220, 225, 230);
            DgvBaoCao.MultiSelect = false;
            DgvBaoCao.Name = "DgvBaoCao";
            DgvBaoCao.ReadOnly = true;
            DgvBaoCao.RowHeadersVisible = false;
            DgvBaoCao.RowTemplate.Height = 42;
            DgvBaoCao.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            DgvBaoCao.TabIndex = 14;

            // Màu bảng
            DgvBaoCao.DefaultCellStyle.BackColor = Color.White;
            DgvBaoCao.DefaultCellStyle.ForeColor =
                Color.FromArgb(40, 40, 40);

            DgvBaoCao.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F);

            DgvBaoCao.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(225, 235, 247);

            DgvBaoCao.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(30, 30, 30);

            DgvBaoCao.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 249, 251);

            DgvBaoCao.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(242, 244, 247);

            DgvBaoCao.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(35, 35, 35);

            DgvBaoCao.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(BtnXuatExcel);
            groupBox1.Controls.Add(BtnLamMoi);
            groupBox1.Controls.Add(BtnTimKiem);
            groupBox1.Controls.Add(TxtTimKiem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DtpNgaySau);
            groupBox1.Controls.Add(DtpNgayTruoc);

            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            groupBox1.Height = 190;

            groupBox1.Name = "groupBox1";
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bộ lọc báo cáo";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location =
                new Point(35, 48);
            label4.Name =
                "label4";
            label4.Size =
                new Size(110, 28);
            label4.TabIndex =
                7;
            label4.Text =
                "Từ tháng:";

            // 
            // DtpNgayTruoc
            // 
            DtpNgayTruoc.CustomFormat = "MM/yyyy";
            DtpNgayTruoc.Font =
                new Font("Segoe UI", 10F);
            DtpNgayTruoc.Format =
                DateTimePickerFormat.Custom;
            DtpNgayTruoc.Location =
                new Point(155, 42);
            DtpNgayTruoc.Name =
                "DtpNgayTruoc";
            DtpNgayTruoc.ShowUpDown = true;
            DtpNgayTruoc.Size =
                new Size(160, 35);
            DtpNgayTruoc.TabIndex =
                34;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location =
                new Point(350, 48);
            label1.Name =
                "label1";
            label1.Size =
                new Size(105, 28);
            label1.TabIndex =
                37;
            label1.Text =
                "Đến tháng:";

            // 
            // DtpNgaySau
            // 
            DtpNgaySau.CustomFormat = "MM/yyyy";
            DtpNgaySau.Font =
                new Font("Segoe UI", 10F);
            DtpNgaySau.Format =
                DateTimePickerFormat.Custom;
            DtpNgaySau.Location =
                new Point(465, 42);
            DtpNgaySau.Name =
                "DtpNgaySau";
            DtpNgaySau.ShowUpDown = true;
            DtpNgaySau.Size =
                new Size(160, 35);
            DtpNgaySau.TabIndex =
                34;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location =
                new Point(35, 105);
            label2.Name =
                "label2";
            label2.Size =
                new Size(95, 28);
            label2.TabIndex =
                7;
            label2.Text =
                "Tìm kiếm:";

            // 
            // TxtTimKiem
            // 
            TxtTimKiem.BorderStyle =
                BorderStyle.FixedSingle;
            TxtTimKiem.Font =
                new Font("Segoe UI", 10F);
            TxtTimKiem.Location =
                new Point(155, 98);
            TxtTimKiem.Name =
                "TxtTimKiem";
            TxtTimKiem.PlaceholderText =
                "Nhập nội dung cần tìm...";
            TxtTimKiem.Size =
                new Size(470, 35);
            TxtTimKiem.TabIndex =
                35;

            // 
            // BtnTimKiem
            // 
            BtnTimKiem.BackColor =
                Color.FromArgb(52, 108, 170);
            BtnTimKiem.FlatAppearance.BorderSize = 0;
            BtnTimKiem.FlatStyle =
                FlatStyle.Flat;
            BtnTimKiem.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnTimKiem.ForeColor =
                Color.White;
            BtnTimKiem.Location =
                new Point(650, 93);
            BtnTimKiem.Name =
                "BtnTimKiem";
            BtnTimKiem.Size =
                new Size(145, 45);
            BtnTimKiem.TabIndex =
                36;
            BtnTimKiem.Text =
                "Tìm kiếm";
            BtnTimKiem.UseVisualStyleBackColor =
                false;
            BtnTimKiem.Click += BtnTimKiem_Click;

            // 
            // BtnLamMoi
            // 
            BtnLamMoi.BackColor =
                Color.FromArgb(245, 246, 248);
            BtnLamMoi.FlatAppearance.BorderColor =
                Color.FromArgb(210, 214, 220);
            BtnLamMoi.FlatStyle =
                FlatStyle.Flat;
            BtnLamMoi.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnLamMoi.ForeColor =
                Color.FromArgb(50, 50, 50);
            BtnLamMoi.Location =
                new Point(810, 93);
            BtnLamMoi.Name =
                "BtnLamMoi";
            BtnLamMoi.Size =
                new Size(145, 45);
            BtnLamMoi.TabIndex =
                38;
            BtnLamMoi.Text =
                "Làm mới";
            BtnLamMoi.UseVisualStyleBackColor =
                false;
            BtnLamMoi.Click += BtnLamMoi_Click;

            // 
            // BtnXuatExcel
            // 
            BtnXuatExcel.BackColor =
                Color.FromArgb(47, 126, 82);
            BtnXuatExcel.FlatAppearance.BorderSize = 0;
            BtnXuatExcel.FlatStyle =
                FlatStyle.Flat;
            BtnXuatExcel.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnXuatExcel.ForeColor =
                Color.White;
            BtnXuatExcel.Location =
                new Point(970, 93);
            BtnXuatExcel.Name =
                "BtnXuatExcel";
            BtnXuatExcel.Size =
                new Size(160, 45);
            BtnXuatExcel.TabIndex =
                39;
            BtnXuatExcel.Text =
                "Xuất Excel";
            BtnXuatExcel.UseVisualStyleBackColor =
                false;
            BtnXuatExcel.Click += BtnXuatExcel_Click;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font =
                new Font("Segoe UI", 17F, FontStyle.Bold);
            label3.ForeColor =
                Color.FromArgb(30, 30, 30);
            label3.Location =
                new Point(28, 15);
            label3.Name =
                "label3";
            label3.Size =
                new Size(300, 46);
            label3.TabIndex =
                13;
            label3.Text =
                "Báo cáo phân tích";

            // 
            // BaoCaoPhanTich
            // 
            AutoScaleDimensions =
                new SizeF(8F, 20F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(245, 247, 249);

            Controls.Add(DgvBaoCao);
            Controls.Add(groupBox1);
            Controls.Add(label3);

            Name =
                "BaoCaoPhanTich";

            Size =
                new Size(2088, 1627);

            Load += BaoCaoPhanTich_Load;

            ((System.ComponentModel.ISupportInitialize)DgvBaoCao).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

    #endregion

        private DataGridView DgvBaoCao;
        private GroupBox groupBox1;
        private TextBox TxtTimKiem;
        private Button BtnLamMoi;
        private Button BtnTimKiem;
        private Label label2;
        private Label label4;
        private DateTimePicker DtpNgayTruoc;
        private Label label3;
        private Label label1;
        private DateTimePicker DtpNgaySau;
        private Button BtnXuatExcel;
    }
}
