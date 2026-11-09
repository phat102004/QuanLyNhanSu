namespace QuanLyNhanSu.usercontrol
{
    partial class BaoCaoPhanCong
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
            DgvPhanCong = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            TxtTimKiem = new TextBox();
            BtnXuatExcel = new Button();
            BtnLamMoi = new Button();
            BtnTimKiem = new Button();
            label2 = new Label();
            label4 = new Label();
            DtpNgaySau = new DateTimePicker();
            DtpNgayTruoc = new DateTimePicker();
            label3 = new Label();
            BtnHoanThanh = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvPhanCong).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            //
            // DgvPhanCong
            //
            DgvPhanCong.AllowUserToAddRows = false;
            DgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPhanCong.Dock = DockStyle.Bottom;
            DgvPhanCong.Location = new Point(0, 715);
            DgvPhanCong.Name = "DgvPhanCong";
            DgvPhanCong.RowHeadersVisible = false;
            DgvPhanCong.RowHeadersWidth = 82;
            DgvPhanCong.Size = new Size(2088, 912);
            DgvPhanCong.TabIndex = 17;
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
            groupBox1.Location = new Point(16, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2020, 419);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(760, 80);
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
            // BtnXuatExcel
            //
            BtnXuatExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnXuatExcel.Location = new Point(790, 242);
            BtnXuatExcel.Name = "BtnXuatExcel";
            BtnXuatExcel.Size = new Size(181, 56);
            BtnXuatExcel.TabIndex = 33;
            BtnXuatExcel.Text = "Xuất Excel";
            BtnXuatExcel.UseVisualStyleBackColor = true;
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
            label4.Location = new Point(363, 80);
            label4.Name = "label4";
            label4.Size = new Size(202, 32);
            label4.TabIndex = 7;
            label4.Text = "Ngày phân công";
            //
            // DtpNgaySau
            //
            DtpNgaySau.CustomFormat = "MM/yyyy\r\n";
            DtpNgaySau.Format = DateTimePickerFormat.Short;
            DtpNgaySau.Location = new Point(838, 75);
            DtpNgaySau.Name = "DtpNgaySau";
            DtpNgaySau.ShowUpDown = true;
            DtpNgaySau.Size = new Size(197, 39);
            DtpNgaySau.TabIndex = 34;
            //
            // DtpNgayTruoc
            //
            DtpNgayTruoc.CustomFormat = "MM/yyyy\r\n";
            DtpNgayTruoc.Format = DateTimePickerFormat.Short;
            DtpNgayTruoc.Location = new Point(571, 75);
            DtpNgayTruoc.Name = "DtpNgayTruoc";
            DtpNgayTruoc.ShowUpDown = true;
            DtpNgayTruoc.Size = new Size(164, 39);
            DtpNgayTruoc.TabIndex = 34;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 1);
            label3.Name = "label3";
            label3.Size = new Size(306, 45);
            label3.TabIndex = 16;
            label3.Text = "Báo cáo phân công";
            //
            // BtnHoanThanh
            //
            BtnHoanThanh.Location = new Point(1602, 653);
            BtnHoanThanh.Name = "BtnHoanThanh";
            BtnHoanThanh.Size = new Size(160, 56);
            BtnHoanThanh.TabIndex = 38;
            BtnHoanThanh.Text = "Hoàn thành";
            BtnHoanThanh.UseVisualStyleBackColor = true;
            //
            // BaoCaoPhanCong
            //
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnHoanThanh);
            Controls.Add(DgvPhanCong);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "BaoCaoPhanCong";
            Size = new Size(2088, 1627);
            Load += BaoCaoPhanCong_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPhanCong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvPhanCong;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox TxtTimKiem;
        private Button BtnXuatExcel;
        private Button BtnLamMoi;
        private Button BtnTimKiem;
        private Label label2;
        private Label label4;
        private DateTimePicker DtpNgaySau;
        private DateTimePicker DtpNgayTruoc;
        private Label label3;
        private Button BtnHoanThanh;
    }
}