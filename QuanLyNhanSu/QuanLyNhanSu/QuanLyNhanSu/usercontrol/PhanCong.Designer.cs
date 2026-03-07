namespace QuanLyNhanSu.usercontrol
{
    partial class PhanCong
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
            groupBox3 = new GroupBox();
            BtnLuuLuong = new Button();
            BtnLamMoi = new Button();
            BtnXoa = new Button();
            BtnPhanCong = new Button();
            DgvPhanCong = new DataGridView();
            CongViecID = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            TenCongViec = new DataGridViewTextBoxColumn();
            NgayGiao = new DataGridViewTextBoxColumn();
            HanHoanThanh = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            CbxChucVu = new ComboBox();
            label9 = new Label();
            CbxTenNhanVien = new ComboBox();
            DtpHanHoanThanh = new DateTimePicker();
            DtpNgayGiao = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            TxtIDCongViec = new TextBox();
            TxtTenCongViec = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnXoaChucVu = new Button();
            BtnSuaChucVu = new Button();
            BtnTaoChucVu = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPhanCong).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnLuuLuong);
            groupBox3.Controls.Add(BtnLamMoi);
            groupBox3.Controls.Add(BtnXoa);
            groupBox3.Controls.Add(BtnPhanCong);
            groupBox3.Location = new Point(16, 937);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(2021, 200);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            // 
            // BtnLuuLuong
            // 
            BtnLuuLuong.Location = new Point(1614, 73);
            BtnLuuLuong.Name = "BtnLuuLuong";
            BtnLuuLuong.Size = new Size(349, 67);
            BtnLuuLuong.TabIndex = 2;
            BtnLuuLuong.Text = "Lưu bảng lương";
            BtnLuuLuong.UseVisualStyleBackColor = true;
            // 
            // BtnLamMoi
            // 
            BtnLamMoi.Location = new Point(608, 73);
            BtnLamMoi.Name = "BtnLamMoi";
            BtnLamMoi.Size = new Size(255, 67);
            BtnLamMoi.TabIndex = 1;
            BtnLamMoi.Text = "Làm mới";
            BtnLamMoi.UseVisualStyleBackColor = true;
            BtnLamMoi.Click += BtnLamMoi_Click;
            // 
            // BtnXoa
            // 
            BtnXoa.Location = new Point(347, 73);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(255, 67);
            BtnXoa.TabIndex = 1;
            BtnXoa.Text = "Xóa";
            BtnXoa.UseVisualStyleBackColor = true;
            BtnXoa.Click += BtnXoa_Click;
            // 
            // BtnPhanCong
            // 
            BtnPhanCong.Location = new Point(39, 73);
            BtnPhanCong.Name = "BtnPhanCong";
            BtnPhanCong.Size = new Size(302, 67);
            BtnPhanCong.TabIndex = 0;
            BtnPhanCong.Text = "Thêm";
            BtnPhanCong.UseVisualStyleBackColor = true;
            BtnPhanCong.Click += BtnPhanCong_Click;
            // 
            // DgvPhanCong
            // 
            DgvPhanCong.AllowUserToAddRows = false;
            DgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPhanCong.Columns.AddRange(new DataGridViewColumn[] { CongViecID, HoTen, TenCongViec, NgayGiao, HanHoanThanh, TrangThai });
            DgvPhanCong.Dock = DockStyle.Bottom;
            DgvPhanCong.Location = new Point(0, 1183);
            DgvPhanCong.Name = "DgvPhanCong";
            DgvPhanCong.RowHeadersVisible = false;
            DgvPhanCong.RowHeadersWidth = 82;
            DgvPhanCong.Size = new Size(2088, 444);
            DgvPhanCong.TabIndex = 18;
            DgvPhanCong.CellContentClick += DgvPhanCong_CellContentClick;
            // 
            // CongViecID
            // 
            CongViecID.DataPropertyName = "CongViecID";
            CongViecID.HeaderText = "ID Công việc";
            CongViecID.MinimumWidth = 10;
            CongViecID.Name = "CongViecID";
            CongViecID.Visible = false;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Tên nhân viên";
            HoTen.MinimumWidth = 10;
            HoTen.Name = "HoTen";
            // 
            // TenCongViec
            // 
            TenCongViec.DataPropertyName = "TenCongViec";
            TenCongViec.HeaderText = "Tên công việc";
            TenCongViec.MinimumWidth = 10;
            TenCongViec.Name = "TenCongViec";
            // 
            // NgayGiao
            // 
            NgayGiao.DataPropertyName = "NgayGiao";
            NgayGiao.HeaderText = "Ngày giao";
            NgayGiao.MinimumWidth = 10;
            NgayGiao.Name = "NgayGiao";
            // 
            // HanHoanThanh
            // 
            HanHoanThanh.DataPropertyName = "HanHoanThanh";
            HanHoanThanh.HeaderText = "Ngày cần hoàn thành";
            HanHoanThanh.MinimumWidth = 10;
            HanHoanThanh.Name = "HanHoanThanh";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 10;
            TrangThai.Name = "TrangThai";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CbxChucVu);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(CbxTenNhanVien);
            groupBox1.Controls.Add(DtpHanHoanThanh);
            groupBox1.Controls.Add(DtpNgayGiao);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtIDCongViec);
            groupBox1.Controls.Add(TxtTenCongViec);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(16, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2020, 850);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // CbxChucVu
            // 
            CbxChucVu.FormattingEnabled = true;
            CbxChucVu.Location = new Point(185, 63);
            CbxChucVu.Name = "CbxChucVu";
            CbxChucVu.Size = new Size(423, 40);
            CbxChucVu.TabIndex = 27;
            CbxChucVu.SelectedIndexChanged += CbxChucVu_SelectedIndexChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(10, 69);
            label9.Name = "label9";
            label9.Size = new Size(157, 32);
            label9.TabIndex = 26;
            label9.Text = "Tên chức vụ:";
            // 
            // CbxTenNhanVien
            // 
            CbxTenNhanVien.FormattingEnabled = true;
            CbxTenNhanVien.Location = new Point(10, 281);
            CbxTenNhanVien.Name = "CbxTenNhanVien";
            CbxTenNhanVien.Size = new Size(2001, 40);
            CbxTenNhanVien.TabIndex = 25;
            // 
            // DtpHanHoanThanh
            // 
            DtpHanHoanThanh.Location = new Point(9, 669);
            DtpHanHoanThanh.Name = "DtpHanHoanThanh";
            DtpHanHoanThanh.Size = new Size(2001, 39);
            DtpHanHoanThanh.TabIndex = 24;
            // 
            // DtpNgayGiao
            // 
            DtpNgayGiao.Location = new Point(9, 532);
            DtpNgayGiao.Name = "DtpNgayGiao";
            DtpNgayGiao.Size = new Size(2001, 39);
            DtpNgayGiao.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(10, 617);
            label5.Name = "label5";
            label5.Size = new Size(203, 32);
            label5.TabIndex = 19;
            label5.Text = "Hạn hoàn thành:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(10, 480);
            label6.Name = "label6";
            label6.Size = new Size(138, 32);
            label6.TabIndex = 19;
            label6.Text = "Ngày giao:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(10, 353);
            label4.Name = "label4";
            label4.Size = new Size(177, 32);
            label4.TabIndex = 23;
            label4.Text = "Tên công việc:";
            // 
            // TxtIDCongViec
            // 
            TxtIDCongViec.Location = new Point(9, 183);
            TxtIDCongViec.Name = "TxtIDCongViec";
            TxtIDCongViec.Size = new Size(2001, 39);
            TxtIDCongViec.TabIndex = 18;
            TxtIDCongViec.Visible = false;
            // 
            // TxtTenCongViec
            // 
            TxtTenCongViec.Location = new Point(10, 397);
            TxtTenCongViec.Name = "TxtTenCongViec";
            TxtTenCongViec.Size = new Size(2001, 39);
            TxtTenCongViec.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(10, 138);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 15;
            label1.Text = "ID Công việc:";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 237);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 15;
            label2.Text = "Tên nhân viên:";
            // 
            // BtnXoaChucVu
            // 
            BtnXoaChucVu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnXoaChucVu.Location = new Point(1114, 60);
            BtnXoaChucVu.Name = "BtnXoaChucVu";
            BtnXoaChucVu.Size = new Size(256, 56);
            BtnXoaChucVu.TabIndex = 33;
            BtnXoaChucVu.Text = "Xóa chức vụ";
            BtnXoaChucVu.UseVisualStyleBackColor = true;
            // 
            // BtnSuaChucVu
            // 
            BtnSuaChucVu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnSuaChucVu.Location = new Point(852, 60);
            BtnSuaChucVu.Name = "BtnSuaChucVu";
            BtnSuaChucVu.Size = new Size(256, 56);
            BtnSuaChucVu.TabIndex = 33;
            BtnSuaChucVu.Text = "Sửa chức vụ";
            BtnSuaChucVu.UseVisualStyleBackColor = true;
            // 
            // BtnTaoChucVu
            // 
            BtnTaoChucVu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTaoChucVu.Location = new Point(590, 60);
            BtnTaoChucVu.Name = "BtnTaoChucVu";
            BtnTaoChucVu.Size = new Size(256, 56);
            BtnTaoChucVu.TabIndex = 33;
            BtnTaoChucVu.Text = "Tạo chức vụ";
            BtnTaoChucVu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnXoaChucVu);
            groupBox2.Controls.Add(BtnSuaChucVu);
            groupBox2.Controls.Add(BtnTaoChucVu);
            groupBox2.Location = new Point(16, 675);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1697, 183);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(36, 10);
            label3.Name = "label3";
            label3.Size = new Size(183, 45);
            label3.TabIndex = 16;
            label3.Text = "Phân Công";
            // 
            // PhanCong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(DgvPhanCong);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Name = "PhanCong";
            Size = new Size(2088, 1627);
            Load += PhanCong_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPhanCong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox3;
        private Button BtnLuuLuong;
        private Button BtnLamMoi;
        private Button BtnXoa;
        private Button BtnPhanCong;
        private DataGridView DgvPhanCong;
        private GroupBox groupBox1;
        private Button BtnXoaChucVu;
        private Button BtnSuaChucVu;
        private Button BtnTaoChucVu;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox CbxTenNhanVien;
        private DateTimePicker DtpNgayGiao;
        private Label label6;
        private Label label4;
        private TextBox TxtTenCongViec;
        private Label label2;
        private ComboBox CbxChucVu;
        private Label label9;
        private DateTimePicker DtpHanHoanThanh;
        private Label label5;
        private TextBox TxtIDCongViec;
        private Label label1;
        private DataGridViewTextBoxColumn CongViecID;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn TenCongViec;
        private DataGridViewTextBoxColumn NgayGiao;
        private DataGridViewTextBoxColumn HanHoanThanh;
        private DataGridViewTextBoxColumn TrangThai;
    }
}
