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
            label1 = new Label();
            TxtTimKiem = new TextBox();
            BtnLamMoi = new Button();
            BtnTimKiem = new Button();
            label2 = new Label();
            label4 = new Label();
            DtpNgaySau = new DateTimePicker();
            DtpNgayTruoc = new DateTimePicker();
            label3 = new Label();
            BtnXuatExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvBaoCao).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvBaoCao
            // 
            DgvBaoCao.AllowUserToAddRows = false;
            DgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBaoCao.Dock = DockStyle.Bottom;
            DgvBaoCao.Location = new Point(0, 445);
            DgvBaoCao.Name = "DgvBaoCao";
            DgvBaoCao.RowHeadersVisible = false;
            DgvBaoCao.RowHeadersWidth = 82;
            DgvBaoCao.Size = new Size(2088, 1182);
            DgvBaoCao.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtTimKiem);
            groupBox1.Controls.Add(BtnXuatExcel);
            groupBox1.Controls.Add(BtnLamMoi);
            groupBox1.Controls.Add(BtnTimKiem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DtpNgaySau);
            groupBox1.Controls.Add(DtpNgayTruoc);
            groupBox1.Location = new Point(16, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2020, 548);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(741, 80);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 37;
            label1.Text = "Đến";
            // 
            // TxtTimKiem
            // 
            TxtTimKiem.Location = new Point(571, 162);
            TxtTimKiem.Name = "TxtTimKiem";
            TxtTimKiem.Size = new Size(400, 39);
            TxtTimKiem.TabIndex = 36;
            // 
            // BtnLamMoi
            // 
            BtnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnLamMoi.Location = new Point(590, 242);
            BtnLamMoi.Name = "BtnLamMoi";
            BtnLamMoi.Size = new Size(181, 56);
            BtnLamMoi.TabIndex = 33;
            BtnLamMoi.Text = "Làm mới";
            BtnLamMoi.UseVisualStyleBackColor = true;
            BtnLamMoi.Click += BtnLamMoi_Click;
            // 
            // BtnTimKiem
            // 
            BtnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTimKiem.Location = new Point(387, 242);
            BtnTimKiem.Name = "BtnTimKiem";
            BtnTimKiem.Size = new Size(181, 56);
            BtnTimKiem.TabIndex = 33;
            BtnTimKiem.Text = "Tìm kiếm";
            BtnTimKiem.UseVisualStyleBackColor = true;
            BtnTimKiem.Click += BtnTimKiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(387, 165);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 7;
            label2.Text = "Tìm kiếm: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(387, 80);
            label4.Name = "label4";
            label4.Size = new Size(178, 32);
            label4.TabIndex = 7;
            label4.Text = "Ngày báo cáo:";
            // 
            // DtpNgaySau
            // 
            DtpNgaySau.CustomFormat = "MM/yyyy\r\n";
            DtpNgaySau.Format = DateTimePickerFormat.Custom;
            DtpNgaySau.Location = new Point(838, 75);
            DtpNgaySau.Name = "DtpNgaySau";
            DtpNgaySau.ShowUpDown = true;
            DtpNgaySau.Size = new Size(133, 39);
            DtpNgaySau.TabIndex = 34;
            // 
            // DtpNgayTruoc
            // 
            DtpNgayTruoc.CustomFormat = "MM/yyyy\r\n";
            DtpNgayTruoc.Format = DateTimePickerFormat.Custom;
            DtpNgayTruoc.Location = new Point(571, 75);
            DtpNgayTruoc.Name = "DtpNgayTruoc";
            DtpNgayTruoc.ShowUpDown = true;
            DtpNgayTruoc.Size = new Size(133, 39);
            DtpNgayTruoc.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 3);
            label3.Name = "label3";
            label3.Size = new Size(195, 45);
            label3.TabIndex = 13;
            label3.Text = "Bảng lương";
            // 
            // BtnXuatExcel
            // 
            BtnXuatExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnXuatExcel.Location = new Point(790, 242);
            BtnXuatExcel.Name = "BtnXuatExcel";
            BtnXuatExcel.Size = new Size(181, 56);
            BtnXuatExcel.TabIndex = 33;
            BtnXuatExcel.Text = "Xuất Excel";
            BtnXuatExcel.UseVisualStyleBackColor = true;
            BtnXuatExcel.Click += BtnXuatExcel_Click;
            // 
            // BaoCaoPhanTich
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DgvBaoCao);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "BaoCaoPhanTich";
            Size = new Size(2088, 1627);
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
