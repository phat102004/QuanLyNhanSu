namespace QuanLyNhanSu.usercontrol
{
    partial class TinhLuong
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
            label3 = new Label();
            groupBox2 = new GroupBox();
            BtnXoaChucVu = new Button();
            BtnSuaChucVu = new Button();
            BtnTaoChucVu = new Button();
            label6 = new Label();
            DtpNgayTinhLuong = new DateTimePicker();
            groupBox1 = new GroupBox();
            TxtPhuCap = new TextBox();
            BtnTinhPhuCap = new Button();
            CbxTenNhanVien = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            TxtTongLuong = new TextBox();
            TxtLuongCoBan = new TextBox();
            label4 = new Label();
            TxtSoNgayCong = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TxtMaLuong = new TextBox();
            DgvTinhLuong = new DataGridView();
            MaLuong = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgayTinhLuong = new DataGridViewTextBoxColumn();
            SoNgayCong = new DataGridViewTextBoxColumn();
            TongPhuCap = new DataGridViewTextBoxColumn();
            TongLuong = new DataGridViewTextBoxColumn();
            TinhLuongID = new DataGridViewTextBoxColumn();
            TenChucVu = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            BtnLuuLuong = new Button();
            BtnLamMoi = new Button();
            BtnXoa = new Button();
            BtnSua = new Button();
            BtnTinhLuong = new Button();
            label9 = new Label();
            CbxChucVu = new ComboBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTinhLuong).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(36, 21);
            label3.Name = "label3";
            label3.Size = new Size(191, 45);
            label3.TabIndex = 3;
            label3.Text = "Tinh Lương";
            //
            // groupBox2
            //
            groupBox2.Controls.Add(BtnXoaChucVu);
            groupBox2.Controls.Add(BtnSuaChucVu);
            groupBox2.Controls.Add(BtnTaoChucVu);
            groupBox2.Location = new Point(16, 686);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1697, 183);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
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
            // label6
            //
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(19, 512);
            label6.Name = "label6";
            label6.Size = new Size(208, 32);
            label6.TabIndex = 7;
            label6.Text = "Ngày tính lương:";
            //
            // DtpNgayTinhLuong
            //
            DtpNgayTinhLuong.Location = new Point(18, 564);
            DtpNgayTinhLuong.Name = "DtpNgayTinhLuong";
            DtpNgayTinhLuong.Size = new Size(2001, 39);
            DtpNgayTinhLuong.TabIndex = 8;
            //
            // groupBox1
            //
            groupBox1.Controls.Add(TxtPhuCap);
            groupBox1.Controls.Add(BtnTinhPhuCap);
            groupBox1.Controls.Add(CbxTenNhanVien);
            groupBox1.Controls.Add(DtpNgayTinhLuong);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtTongLuong);
            groupBox1.Controls.Add(TxtLuongCoBan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtSoNgayCong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtMaLuong);
            groupBox1.Location = new Point(16, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2020, 850);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            //
            // TxtPhuCap
            //
            TxtPhuCap.Location = new Point(19, 450);
            TxtPhuCap.Name = "TxtPhuCap";
            TxtPhuCap.Size = new Size(180, 39);
            TxtPhuCap.TabIndex = 12;
            //
            // BtnTinhPhuCap
            //
            BtnTinhPhuCap.Location = new Point(250, 446);
            BtnTinhPhuCap.Name = "BtnTinhPhuCap";
            BtnTinhPhuCap.Size = new Size(240, 46);
            BtnTinhPhuCap.TabIndex = 11;
            BtnTinhPhuCap.Text = "Tính phụ cấp";
            BtnTinhPhuCap.UseVisualStyleBackColor = true;
            BtnTinhPhuCap.Click += BtnTinhPhuCap_Click;
            //
            // CbxTenNhanVien
            //
            CbxTenNhanVien.FormattingEnabled = true;
            CbxTenNhanVien.Location = new Point(19, 202);
            CbxTenNhanVien.Name = "CbxTenNhanVien";
            CbxTenNhanVien.Size = new Size(2001, 40);
            CbxTenNhanVien.TabIndex = 9;
            CbxTenNhanVien.SelectedIndexChanged += CbxTenNhanVien_SelectedIndexChanged;
            //
            // label8
            //
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(20, 738);
            label8.Name = "label8";
            label8.Size = new Size(155, 32);
            label8.TabIndex = 7;
            label8.Text = "Tổng lương:";
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(19, 402);
            label5.Name = "label5";
            label5.Size = new Size(112, 32);
            label5.TabIndex = 7;
            label5.Text = "Phụ cấp:";
            //
            // label7
            //
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(20, 633);
            label7.Name = "label7";
            label7.Size = new Size(178, 32);
            label7.TabIndex = 7;
            label7.Text = "Lương cơ bản:";
            //
            // TxtTongLuong
            //
            TxtTongLuong.Location = new Point(20, 783);
            TxtTongLuong.Name = "TxtTongLuong";
            TxtTongLuong.ReadOnly = true;
            TxtTongLuong.Size = new Size(2001, 39);
            TxtTongLuong.TabIndex = 6;
            //
            // TxtLuongCoBan
            //
            TxtLuongCoBan.Location = new Point(20, 677);
            TxtLuongCoBan.Name = "TxtLuongCoBan";
            TxtLuongCoBan.ReadOnly = true;
            TxtLuongCoBan.Size = new Size(2001, 39);
            TxtLuongCoBan.TabIndex = 6;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(19, 274);
            label4.Name = "label4";
            label4.Size = new Size(183, 32);
            label4.TabIndex = 7;
            label4.Text = "Số ngày công: ";
            //
            // TxtSoNgayCong
            //
            TxtSoNgayCong.Location = new Point(19, 318);
            TxtSoNgayCong.Name = "TxtSoNgayCong";
            TxtSoNgayCong.Size = new Size(2001, 39);
            TxtSoNgayCong.TabIndex = 6;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 158);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 5;
            label2.Text = "Tên nhân viên:";
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(19, 50);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 3;
            label1.Text = "Mã lương:";
            //
            // TxtMaLuong
            //
            TxtMaLuong.Enabled = false;
            TxtMaLuong.Location = new Point(19, 94);
            TxtMaLuong.Name = "TxtMaLuong";
            TxtMaLuong.ReadOnly = true;
            TxtMaLuong.Size = new Size(2001, 39);
            TxtMaLuong.TabIndex = 2;
            //
            // DgvTinhLuong
            //
            DgvTinhLuong.AllowUserToAddRows = false;
            DgvTinhLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTinhLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTinhLuong.Columns.AddRange(new DataGridViewColumn[] { MaLuong, HoTen, NgayTinhLuong, SoNgayCong, TongPhuCap, TongLuong, TinhLuongID, TenChucVu });
            DgvTinhLuong.Dock = DockStyle.Bottom;
            DgvTinhLuong.Location = new Point(0, 1410);
            DgvTinhLuong.Name = "DgvTinhLuong";
            DgvTinhLuong.RowHeadersVisible = false;
            DgvTinhLuong.RowHeadersWidth = 82;
            DgvTinhLuong.Size = new Size(2088, 217);
            DgvTinhLuong.TabIndex = 9;
            DgvTinhLuong.CellContentClick += DgvTinhLuong_CellContentClick;
            //
            // MaLuong
            //
            MaLuong.DataPropertyName = "MaLuong";
            MaLuong.HeaderText = "Mã Lương";
            MaLuong.MinimumWidth = 10;
            MaLuong.Name = "MaLuong";
            //
            // HoTen
            //
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Tên nhân viên";
            HoTen.MinimumWidth = 10;
            HoTen.Name = "HoTen";
            //
            // NgayTinhLuong
            //
            NgayTinhLuong.DataPropertyName = "NgayTinhLuong";
            NgayTinhLuong.HeaderText = "Ngày tính lương";
            NgayTinhLuong.MinimumWidth = 10;
            NgayTinhLuong.Name = "NgayTinhLuong";
            //
            // SoNgayCong
            //
            SoNgayCong.DataPropertyName = "SoNgayCong";
            SoNgayCong.HeaderText = "Số ngày công";
            SoNgayCong.MinimumWidth = 10;
            SoNgayCong.Name = "SoNgayCong";
            //
            // TongPhuCap
            //
            TongPhuCap.DataPropertyName = "TongPhuCap";
            TongPhuCap.HeaderText = "Tổng phụ cấp";
            TongPhuCap.MinimumWidth = 10;
            TongPhuCap.Name = "TongPhuCap";
            //
            // TongLuong
            //
            TongLuong.DataPropertyName = "TongLuong";
            TongLuong.HeaderText = "Tổng lương";
            TongLuong.MinimumWidth = 10;
            TongLuong.Name = "TongLuong";
            //
            // TinhLuongID
            //
            TinhLuongID.DataPropertyName = "TinhLuongID";
            TinhLuongID.HeaderText = "ID Tinh Luong";
            TinhLuongID.MinimumWidth = 10;
            TinhLuongID.Name = "TinhLuongID";
            TinhLuongID.Visible = false;
            //
            // TenChucVu
            //
            TenChucVu.DataPropertyName = "TenChucVu";
            TenChucVu.HeaderText = "Column1";
            TenChucVu.MinimumWidth = 10;
            TenChucVu.Name = "TenChucVu";
            TenChucVu.Visible = false;
            //
            // groupBox3
            //
            groupBox3.Controls.Add(BtnLuuLuong);
            groupBox3.Controls.Add(BtnLamMoi);
            groupBox3.Controls.Add(BtnXoa);
            groupBox3.Controls.Add(BtnSua);
            groupBox3.Controls.Add(BtnTinhLuong);
            groupBox3.Location = new Point(16, 948);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(2021, 200);
            groupBox3.TabIndex = 10;
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
            BtnLuuLuong.Click += BtnLuuLuong_Click;
            //
            // BtnLamMoi
            //
            BtnLamMoi.Location = new Point(869, 73);
            BtnLamMoi.Name = "BtnLamMoi";
            BtnLamMoi.Size = new Size(255, 67);
            BtnLamMoi.TabIndex = 1;
            BtnLamMoi.Text = "Làm mới";
            BtnLamMoi.UseVisualStyleBackColor = true;
            BtnLamMoi.Click += BtnLamMoi_Click;
            //
            // BtnXoa
            //
            BtnXoa.Location = new Point(608, 73);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(255, 67);
            BtnXoa.TabIndex = 1;
            BtnXoa.Text = "Xóa";
            BtnXoa.UseVisualStyleBackColor = true;
            BtnXoa.Click += BtnXoa_Click;
            //
            // BtnSua
            //
            BtnSua.Location = new Point(347, 73);
            BtnSua.Name = "BtnSua";
            BtnSua.Size = new Size(255, 67);
            BtnSua.TabIndex = 1;
            BtnSua.Text = "Sửa";
            BtnSua.UseVisualStyleBackColor = true;
            BtnSua.Click += BtnSua_Click;
            //
            // BtnTinhLuong
            //
            BtnTinhLuong.Location = new Point(39, 73);
            BtnTinhLuong.Name = "BtnTinhLuong";
            BtnTinhLuong.Size = new Size(302, 67);
            BtnTinhLuong.TabIndex = 0;
            BtnTinhLuong.Text = "Tính lương nhân viên";
            BtnTinhLuong.UseVisualStyleBackColor = true;
            BtnTinhLuong.Click += BtnTinhLuong_Click;
            //
            // label9
            //
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(759, 34);
            label9.Name = "label9";
            label9.Size = new Size(157, 32);
            label9.TabIndex = 3;
            label9.Text = "Tên chức vụ:";
            //
            // CbxChucVu
            //
            CbxChucVu.FormattingEnabled = true;
            CbxChucVu.Location = new Point(934, 28);
            CbxChucVu.Name = "CbxChucVu";
            CbxChucVu.Size = new Size(423, 40);
            CbxChucVu.TabIndex = 13;
            CbxChucVu.SelectedIndexChanged += CbxChucVu_SelectedIndexChanged;
            //
            // TinhLuong
            //
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CbxChucVu);
            Controls.Add(groupBox3);
            Controls.Add(DgvTinhLuong);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(label9);
            Name = "TinhLuong";
            Size = new Size(2088, 1627);
            Load += TinhLuong_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTinhLuong).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox groupBox2;
        private Button BtnXoaChucVu;
        private Button BtnSuaChucVu;
        private Button BtnTaoChucVu;
        private Label label6;
        private DateTimePicker DtpNgayTinhLuong;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private TextBox TxtLuongCoBan;
        private TextBox TxtSoNgayCong;
        private Label label2;
        private Label label1;
        private TextBox TxtMaLuong;
        private DataGridView DgvTinhLuong;
        private ComboBox CbxTenNhanVien;
        private Button BtnTinhPhuCap;
        private Label label8;
        private Label label7;
        private TextBox TxtTenChucVu;
        private TextBox TxtPhuCap;
        private TextBox TxtTongLuong;
        private GroupBox groupBox3;
        private Button BtnTinhLuong;
        private Label label9;
        private ComboBox CbxChucVu;
        private DataGridViewTextBoxColumn MaLuong;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgayTinhLuong;
        private DataGridViewTextBoxColumn SoNgayCong;
        private DataGridViewTextBoxColumn TongPhuCap;
        private DataGridViewTextBoxColumn TongLuong;
        private DataGridViewTextBoxColumn TinhLuongID;
        private DataGridViewTextBoxColumn TenChucVu;
        private Button BtnLamMoi;
        private Button BtnXoa;
        private Button BtnSua;
        private Button BtnLuuLuong;
    }
}
