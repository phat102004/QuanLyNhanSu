namespace QuanLyNhanSu.usercontrol
{
    partial class QuanLyNhanVien
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
            pntop = new Panel();
            TxtNVCanXoaSua = new TextBox();
            label2 = new Label();
            BtnXoaNhanVien = new Button();
            BtnSuaThongTinNhanVien = new Button();
            TxtTimKiem = new TextBox();
            label1 = new Label();
            lbltimkiemnv = new Label();
            DgvDanhSachNhanVien = new DataGridView();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            NhanVienID = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            CMND_CCCD = new DataGridViewTextBoxColumn();
            NgayVaoLam = new DataGridViewTextBoxColumn();
            TrangThaiLamViec = new DataGridViewTextBoxColumn();
            TenTrinhDo = new DataGridViewTextBoxColumn();
            TenPhongBan = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            PhongBanID = new DataGridViewTextBoxColumn();
            ChucVuID = new DataGridViewTextBoxColumn();
            TrinhDoID = new DataGridViewTextBoxColumn();
            pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDanhSachNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 24);
            label3.Name = "label3";
            label3.Size = new Size(288, 45);
            label3.TabIndex = 2;
            label3.Text = "Quản lý nhân viên";
            // 
            // pntop
            // 
            pntop.BackColor = SystemColors.Control;
            pntop.Controls.Add(TxtNVCanXoaSua);
            pntop.Controls.Add(label2);
            pntop.Controls.Add(BtnXoaNhanVien);
            pntop.Controls.Add(BtnSuaThongTinNhanVien);
            pntop.Controls.Add(TxtTimKiem);
            pntop.Controls.Add(label1);
            pntop.Controls.Add(lbltimkiemnv);
            pntop.Location = new Point(35, 81);
            pntop.Margin = new Padding(5);
            pntop.Name = "pntop";
            pntop.Size = new Size(2035, 105);
            pntop.TabIndex = 3;
            // 
            // TxtNVCanXoaSua
            // 
            TxtNVCanXoaSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TxtNVCanXoaSua.Location = new Point(1083, 35);
            TxtNVCanXoaSua.Name = "TxtNVCanXoaSua";
            TxtNVCanXoaSua.ReadOnly = true;
            TxtNVCanXoaSua.Size = new Size(200, 39);
            TxtNVCanXoaSua.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(754, 38);
            label2.Name = "label2";
            label2.Size = new Size(323, 32);
            label2.TabIndex = 36;
            label2.Text = "Mã Nhân Viên Cần Xóa/ Sửa:";
            // 
            // BtnXoaNhanVien
            // 
            BtnXoaNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnXoaNhanVien.Location = new Point(389, 26);
            BtnXoaNhanVien.Name = "BtnXoaNhanVien";
            BtnXoaNhanVien.Size = new Size(256, 56);
            BtnXoaNhanVien.TabIndex = 34;
            BtnXoaNhanVien.Text = "Xóa nhân viên";
            BtnXoaNhanVien.UseVisualStyleBackColor = true;
            BtnXoaNhanVien.Click += BtnXoaNhanVien_Click;
            // 
            // BtnSuaThongTinNhanVien
            // 
            BtnSuaThongTinNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnSuaThongTinNhanVien.Location = new Point(127, 26);
            BtnSuaThongTinNhanVien.Name = "BtnSuaThongTinNhanVien";
            BtnSuaThongTinNhanVien.Size = new Size(256, 56);
            BtnSuaThongTinNhanVien.TabIndex = 35;
            BtnSuaThongTinNhanVien.Text = "Sửa thông tin";
            BtnSuaThongTinNhanVien.UseVisualStyleBackColor = true;
            BtnSuaThongTinNhanVien.Click += BtnSuaThongTinNhanVien_Click;
            // 
            // TxtTimKiem
            // 
            TxtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtTimKiem.Location = new Point(1533, 34);
            TxtTimKiem.Margin = new Padding(5);
            TxtTimKiem.Name = "TxtTimKiem";
            TxtTimKiem.Size = new Size(359, 39);
            TxtTimKiem.TabIndex = 5;
            TxtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(1399, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 4;
            label1.Text = "Tim kiếm:";
            // 
            // lbltimkiemnv
            // 
            lbltimkiemnv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbltimkiemnv.AutoSize = true;
            lbltimkiemnv.Location = new Point(3489, 30);
            lbltimkiemnv.Margin = new Padding(5, 0, 5, 0);
            lbltimkiemnv.Name = "lbltimkiemnv";
            lbltimkiemnv.Size = new Size(118, 32);
            lbltimkiemnv.TabIndex = 1;
            lbltimkiemnv.Text = "Tim kiếm:";
            // 
            // DgvDanhSachNhanVien
            // 
            DgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDanhSachNhanVien.Columns.AddRange(new DataGridViewColumn[] { NhanVienID, MaNhanVien, HoTen, GioiTinh, DiaChi, SoDienThoai, Email, NgaySinh, CMND_CCCD, NgayVaoLam, TrangThaiLamViec, TenTrinhDo, TenPhongBan, ChucVu, PhongBanID, ChucVuID, TrinhDoID });
            DgvDanhSachNhanVien.Location = new Point(0, 194);
            DgvDanhSachNhanVien.Name = "DgvDanhSachNhanVien";
            DgvDanhSachNhanVien.RowHeadersVisible = false;
            DgvDanhSachNhanVien.RowHeadersWidth = 82;
            DgvDanhSachNhanVien.Size = new Size(2088, 1430);
            DgvDanhSachNhanVien.TabIndex = 4;
            DgvDanhSachNhanVien.CellContentClick += DgvDanhSachNhanVien_CellContentClick;
            // 
            // NhanVienID
            // 
            NhanVienID.DataPropertyName = "NhanVienID";
            NhanVienID.HeaderText = "ID Nhân Viên";
            NhanVienID.MinimumWidth = 10;
            NhanVienID.Name = "NhanVienID";
            NhanVienID.Visible = false;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.MinimumWidth = 10;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ và Tên";
            HoTen.MinimumWidth = 10;
            HoTen.Name = "HoTen";
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 10;
            GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 10;
            DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 10;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 10;
            Email.Name = "Email";
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 10;
            NgaySinh.Name = "NgaySinh";
            // 
            // CMND_CCCD
            // 
            CMND_CCCD.DataPropertyName = "CMND_CCCD";
            CMND_CCCD.HeaderText = "CMND_CCCD";
            CMND_CCCD.MinimumWidth = 10;
            CMND_CCCD.Name = "CMND_CCCD";
            // 
            // NgayVaoLam
            // 
            NgayVaoLam.DataPropertyName = "NgayVaoLam";
            NgayVaoLam.HeaderText = "Ngày Vào Làm";
            NgayVaoLam.MinimumWidth = 10;
            NgayVaoLam.Name = "NgayVaoLam";
            // 
            // TrangThaiLamViec
            // 
            TrangThaiLamViec.DataPropertyName = "TrangThaiLamViec";
            TrangThaiLamViec.HeaderText = "Trạng Thái Làm Việc";
            TrangThaiLamViec.MinimumWidth = 10;
            TrangThaiLamViec.Name = "TrangThaiLamViec";
            // 
            // TenTrinhDo
            // 
            TenTrinhDo.DataPropertyName = "TenTrinhDo";
            TenTrinhDo.HeaderText = "Trình Độ";
            TenTrinhDo.MinimumWidth = 10;
            TenTrinhDo.Name = "TenTrinhDo";
            // 
            // TenPhongBan
            // 
            TenPhongBan.DataPropertyName = "TenPhongBan";
            TenPhongBan.HeaderText = "Phòng Ban";
            TenPhongBan.MinimumWidth = 10;
            TenPhongBan.Name = "TenPhongBan";
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "TenChucVu";
            ChucVu.HeaderText = "Tên Chức Vụ";
            ChucVu.MinimumWidth = 10;
            ChucVu.Name = "ChucVu";
            // 
            // PhongBanID
            // 
            PhongBanID.DataPropertyName = "PhongBanID";
            PhongBanID.HeaderText = "Column1";
            PhongBanID.MinimumWidth = 10;
            PhongBanID.Name = "PhongBanID";
            PhongBanID.Visible = false;
            // 
            // ChucVuID
            // 
            ChucVuID.DataPropertyName = "ChucVuID";
            ChucVuID.HeaderText = "Column1";
            ChucVuID.MinimumWidth = 10;
            ChucVuID.Name = "ChucVuID";
            ChucVuID.Visible = false;
            // 
            // TrinhDoID
            // 
            TrinhDoID.DataPropertyName = "TrinhDoID";
            TrinhDoID.HeaderText = "Column1";
            TrinhDoID.MinimumWidth = 10;
            TrinhDoID.Name = "TrinhDoID";
            TrinhDoID.Visible = false;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DgvDanhSachNhanVien);
            Controls.Add(pntop);
            Controls.Add(label3);
            Name = "QuanLyNhanVien";
            Size = new Size(2088, 1627);
            Load += QuanLyNhanVien_Load;
            pntop.ResumeLayout(false);
            pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDanhSachNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel pntop;
        private TextBox TxtTimKiem;
        private Label label1;
        private Label lbltimkiemnv;
        private DataGridView DgvDanhSachNhanVien;
        private Button BtnXoaNhanVien;
        private Button BtnSuaThongTinNhanVien;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox TxtNVCanXoaSua;
        private DataGridViewTextBoxColumn NhanVienID;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn CMND_CCCD;
        private DataGridViewTextBoxColumn NgayVaoLam;
        private DataGridViewTextBoxColumn TrangThaiLamViec;
        private DataGridViewTextBoxColumn TenTrinhDo;
        private DataGridViewTextBoxColumn TenPhongBan;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn PhongBanID;
        private DataGridViewTextBoxColumn ChucVuID;
        private DataGridViewTextBoxColumn TrinhDoID;
    }
}
