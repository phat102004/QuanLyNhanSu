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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            pntop = new Panel();
            topLayout = new TableLayoutPanel();
            actionPanel = new FlowLayoutPanel();
            BtnSuaThongTinNhanVien = new Button();
            BtnXoaNhanVien = new Button();
            employeePanel = new TableLayoutPanel();
            label2 = new Label();
            TxtNVCanXoaSua = new TextBox();
            searchPanel = new TableLayoutPanel();
            label1 = new Label();
            TxtTimKiem = new TextBox();
            lbltimkiemnv = new Label();
            DgvDanhSachNhanVien = new DataGridView();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            mainLayout = new TableLayoutPanel();
            NhanVienID = new DataGridViewTextBoxColumn();
            TenChucVu = new DataGridViewTextBoxColumn();
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
            PhongBanID = new DataGridViewTextBoxColumn();
            ChucVuID = new DataGridViewTextBoxColumn();
            TrinhDoID = new DataGridViewTextBoxColumn();
            pntop.SuspendLayout();
            topLayout.SuspendLayout();
            actionPanel.SuspendLayout();
            employeePanel.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDanhSachNhanVien).BeginInit();
            mainLayout.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(30, 30, 30);
            label3.Location = new Point(25, 25);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(536, 65);
            label3.TabIndex = 0;
            label3.Text = "Quản lý nhân viên";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pntop
            // 
            pntop.BackColor = Color.FromArgb(245, 247, 250);
            pntop.Controls.Add(topLayout);
            pntop.Dock = DockStyle.Fill;
            pntop.Location = new Point(25, 90);
            pntop.Margin = new Padding(0, 0, 0, 15);
            pntop.Name = "pntop";
            pntop.Size = new Size(2038, 80);
            pntop.TabIndex = 1;
            // 
            // topLayout
            // 
            topLayout.ColumnCount = 3;
            topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 390F));
            topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            topLayout.Controls.Add(actionPanel, 0, 0);
            topLayout.Controls.Add(employeePanel, 1, 0);
            topLayout.Controls.Add(searchPanel, 2, 0);
            topLayout.Dock = DockStyle.Fill;
            topLayout.Location = new Point(0, 0);
            topLayout.Margin = new Padding(0);
            topLayout.Name = "topLayout";
            topLayout.Padding = new Padding(15, 12, 15, 12);
            topLayout.RowCount = 1;
            topLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            topLayout.Size = new Size(2038, 80);
            topLayout.TabIndex = 0;
            // 
            // actionPanel
            // 
            actionPanel.BackColor = Color.Transparent;
            actionPanel.Controls.Add(BtnSuaThongTinNhanVien);
            actionPanel.Controls.Add(BtnXoaNhanVien);
            actionPanel.Dock = DockStyle.Fill;
            actionPanel.Location = new Point(15, 12);
            actionPanel.Margin = new Padding(0);
            actionPanel.Name = "actionPanel";
            actionPanel.Padding = new Padding(0, 5, 0, 0);
            actionPanel.Size = new Size(390, 56);
            actionPanel.TabIndex = 0;
            actionPanel.WrapContents = false;
            // 
            // BtnSuaThongTinNhanVien
            // 
            BtnSuaThongTinNhanVien.BackColor = Color.White;
            BtnSuaThongTinNhanVien.FlatAppearance.BorderColor = Color.FromArgb(190, 195, 200);
            BtnSuaThongTinNhanVien.FlatStyle = FlatStyle.Flat;
            BtnSuaThongTinNhanVien.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            BtnSuaThongTinNhanVien.ForeColor = Color.FromArgb(40, 40, 40);
            BtnSuaThongTinNhanVien.Location = new Point(0, 5);
            BtnSuaThongTinNhanVien.Margin = new Padding(0, 0, 10, 0);
            BtnSuaThongTinNhanVien.Name = "BtnSuaThongTinNhanVien";
            BtnSuaThongTinNhanVien.Size = new Size(170, 48);
            BtnSuaThongTinNhanVien.TabIndex = 0;
            BtnSuaThongTinNhanVien.Text = "Sửa thông tin";
            BtnSuaThongTinNhanVien.UseVisualStyleBackColor = false;
            BtnSuaThongTinNhanVien.Click += BtnSuaThongTinNhanVien_Click;
            // 
            // BtnXoaNhanVien
            // 
            BtnXoaNhanVien.BackColor = Color.White;
            BtnXoaNhanVien.FlatAppearance.BorderColor = Color.FromArgb(190, 195, 200);
            BtnXoaNhanVien.FlatStyle = FlatStyle.Flat;
            BtnXoaNhanVien.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            BtnXoaNhanVien.ForeColor = Color.FromArgb(40, 40, 40);
            BtnXoaNhanVien.Location = new Point(180, 5);
            BtnXoaNhanVien.Margin = new Padding(0);
            BtnXoaNhanVien.Name = "BtnXoaNhanVien";
            BtnXoaNhanVien.Size = new Size(170, 48);
            BtnXoaNhanVien.TabIndex = 1;
            BtnXoaNhanVien.Text = "Xóa nhân viên";
            BtnXoaNhanVien.UseVisualStyleBackColor = false;
            BtnXoaNhanVien.Click += BtnXoaNhanVien_Click;
            // 
            // employeePanel
            // 
            employeePanel.ColumnCount = 2;
            employeePanel.ColumnStyles.Add(new ColumnStyle());
            employeePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            employeePanel.Controls.Add(label2, 0, 0);
            employeePanel.Controls.Add(TxtNVCanXoaSua, 1, 0);
            employeePanel.Dock = DockStyle.Fill;
            employeePanel.Location = new Point(415, 12);
            employeePanel.Margin = new Padding(10, 0, 10, 0);
            employeePanel.Name = "employeePanel";
            employeePanel.Padding = new Padding(10, 5, 10, 5);
            employeePanel.RowCount = 1;
            employeePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            employeePanel.Size = new Size(998, 56);
            employeePanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(10, 9);
            label2.Margin = new Padding(0, 0, 12, 0);
            label2.Name = "label2";
            label2.Size = new Size(370, 38);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên cần sửa/xóa:";
            // 
            // TxtNVCanXoaSua
            // 
            TxtNVCanXoaSua.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtNVCanXoaSua.Font = new Font("Segoe UI", 10.5F);
            TxtNVCanXoaSua.Location = new Point(392, 5);
            TxtNVCanXoaSua.Margin = new Padding(0);
            TxtNVCanXoaSua.MinimumSize = new Size(150, 0);
            TxtNVCanXoaSua.Name = "TxtNVCanXoaSua";
            TxtNVCanXoaSua.ReadOnly = true;
            TxtNVCanXoaSua.Size = new Size(596, 45);
            TxtNVCanXoaSua.TabIndex = 3;
            // 
            // searchPanel
            // 
            searchPanel.ColumnCount = 2;
            searchPanel.ColumnStyles.Add(new ColumnStyle());
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchPanel.Controls.Add(label1, 0, 0);
            searchPanel.Controls.Add(TxtTimKiem, 1, 0);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(1433, 12);
            searchPanel.Margin = new Padding(10, 0, 0, 0);
            searchPanel.Name = "searchPanel";
            searchPanel.Padding = new Padding(10, 5, 0, 5);
            searchPanel.RowCount = 1;
            searchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchPanel.Size = new Size(590, 56);
            searchPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(10, 9);
            label1.Margin = new Padding(0, 0, 12, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // TxtTimKiem
            // 
            TxtTimKiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtTimKiem.Font = new Font("Segoe UI", 10.5F);
            TxtTimKiem.Location = new Point(170, 5);
            TxtTimKiem.Margin = new Padding(0);
            TxtTimKiem.Name = "TxtTimKiem";
            TxtTimKiem.Size = new Size(420, 45);
            TxtTimKiem.TabIndex = 5;
            TxtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            // 
            // lbltimkiemnv
            // 
            lbltimkiemnv.AutoSize = true;
            lbltimkiemnv.Location = new Point(0, 0);
            lbltimkiemnv.Name = "lbltimkiemnv";
            lbltimkiemnv.Size = new Size(0, 15);
            lbltimkiemnv.TabIndex = 0;
            lbltimkiemnv.Visible = false;
            // 
            // DgvDanhSachNhanVien
            // 
            DgvDanhSachNhanVien.AllowUserToAddRows = false;
            DgvDanhSachNhanVien.AllowUserToDeleteRows = false;
            DgvDanhSachNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DgvDanhSachNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvDanhSachNhanVien.BackgroundColor = Color.White;
            DgvDanhSachNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvDanhSachNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvDanhSachNhanVien.ColumnHeadersHeight = 50;
            DgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvDanhSachNhanVien.Columns.AddRange(new DataGridViewColumn[] { NhanVienID, TenChucVu, MaNhanVien, HoTen, GioiTinh, DiaChi, SoDienThoai, Email, NgaySinh, CMND_CCCD, NgayVaoLam, TrangThaiLamViec, TenTrinhDo, TenPhongBan, PhongBanID, ChucVuID, TrinhDoID });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Padding = new Padding(5, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvDanhSachNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            DgvDanhSachNhanVien.Dock = DockStyle.Fill;
            DgvDanhSachNhanVien.EnableHeadersVisualStyles = false;
            DgvDanhSachNhanVien.GridColor = Color.FromArgb(220, 225, 230);
            DgvDanhSachNhanVien.Location = new Point(25, 185);
            DgvDanhSachNhanVien.Margin = new Padding(0);
            DgvDanhSachNhanVien.MultiSelect = false;
            DgvDanhSachNhanVien.Name = "DgvDanhSachNhanVien";
            DgvDanhSachNhanVien.ReadOnly = true;
            DgvDanhSachNhanVien.RowHeadersVisible = false;
            DgvDanhSachNhanVien.RowHeadersWidth = 82;
            DgvDanhSachNhanVien.RowTemplate.Height = 40;
            DgvDanhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDanhSachNhanVien.Size = new Size(2038, 1417);
            DgvDanhSachNhanVien.TabIndex = 7;
            DgvDanhSachNhanVien.CellContentClick += DgvDanhSachNhanVien_CellContentClick;
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.White;
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(pntop, 0, 1);
            mainLayout.Controls.Add(DgvDanhSachNhanVien, 0, 2);
            mainLayout.Controls.Add(label3, 0, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(25);
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(2088, 1627);
            mainLayout.TabIndex = 0;
            // 
            // NhanVienID
            // 
            NhanVienID.DataPropertyName = "NhanVienID";
            NhanVienID.HeaderText = "NhanVienID";
            NhanVienID.MinimumWidth = 10;
            NhanVienID.Name = "NhanVienID";
            NhanVienID.ReadOnly = true;
            NhanVienID.Visible = false;
            NhanVienID.Width = 200;
            // 
            // TenChucVu
            // 
            TenChucVu.DataPropertyName = "TenChucVu";
            TenChucVu.HeaderText = "Tên Chức Vụ";
            TenChucVu.MinimumWidth = 10;
            TenChucVu.Name = "TenChucVu";
            TenChucVu.ReadOnly = true;
            TenChucVu.Width = 200;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.MinimumWidth = 120;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            MaNhanVien.Width = 145;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ và Tên";
            HoTen.MinimumWidth = 180;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            HoTen.Width = 200;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 100;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            GioiTinh.Width = 110;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 200;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            DiaChi.Width = 280;
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 150;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            SoDienThoai.Width = 165;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 200;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 280;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 130;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            NgaySinh.Width = 145;
            // 
            // CMND_CCCD
            // 
            CMND_CCCD.DataPropertyName = "CMND_CCCD";
            CMND_CCCD.HeaderText = "CMND/CCCD";
            CMND_CCCD.MinimumWidth = 150;
            CMND_CCCD.Name = "CMND_CCCD";
            CMND_CCCD.ReadOnly = true;
            CMND_CCCD.Width = 170;
            // 
            // NgayVaoLam
            // 
            NgayVaoLam.DataPropertyName = "NgayVaoLam";
            NgayVaoLam.HeaderText = "Ngày Vào Làm";
            NgayVaoLam.MinimumWidth = 145;
            NgayVaoLam.Name = "NgayVaoLam";
            NgayVaoLam.ReadOnly = true;
            NgayVaoLam.Width = 160;
            // 
            // TrangThaiLamViec
            // 
            TrangThaiLamViec.DataPropertyName = "TrangThaiLamViec";
            TrangThaiLamViec.HeaderText = "Trạng Thái Làm Việc";
            TrangThaiLamViec.MinimumWidth = 180;
            TrangThaiLamViec.Name = "TrangThaiLamViec";
            TrangThaiLamViec.ReadOnly = true;
            TrangThaiLamViec.Width = 200;
            // 
            // TenTrinhDo
            // 
            TenTrinhDo.DataPropertyName = "TenTrinhDo";
            TenTrinhDo.HeaderText = "Trình Độ";
            TenTrinhDo.MinimumWidth = 140;
            TenTrinhDo.Name = "TenTrinhDo";
            TenTrinhDo.ReadOnly = true;
            TenTrinhDo.Width = 160;
            // 
            // TenPhongBan
            // 
            TenPhongBan.DataPropertyName = "TenPhongBan";
            TenPhongBan.HeaderText = "Phòng Ban";
            TenPhongBan.MinimumWidth = 160;
            TenPhongBan.Name = "TenPhongBan";
            TenPhongBan.ReadOnly = true;
            TenPhongBan.Width = 190;
            // 
            // PhongBanID
            // 
            PhongBanID.DataPropertyName = "PhongBanID";
            PhongBanID.HeaderText = "PhongBanID";
            PhongBanID.MinimumWidth = 10;
            PhongBanID.Name = "PhongBanID";
            PhongBanID.ReadOnly = true;
            PhongBanID.Visible = false;
            PhongBanID.Width = 200;
            // 
            // ChucVuID
            // 
            ChucVuID.DataPropertyName = "ChucVuID";
            ChucVuID.HeaderText = "ChucVuID";
            ChucVuID.MinimumWidth = 10;
            ChucVuID.Name = "ChucVuID";
            ChucVuID.ReadOnly = true;
            ChucVuID.Visible = false;
            ChucVuID.Width = 200;
            // 
            // TrinhDoID
            // 
            TrinhDoID.DataPropertyName = "TrinhDoID";
            TrinhDoID.HeaderText = "TrinhDoID";
            TrinhDoID.MinimumWidth = 10;
            TrinhDoID.Name = "TrinhDoID";
            TrinhDoID.ReadOnly = true;
            TrinhDoID.Visible = false;
            TrinhDoID.Width = 200;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(mainLayout);
            Margin = new Padding(0);
            Name = "QuanLyNhanVien";
            Size = new Size(2088, 1627);
            Load += QuanLyNhanVien_Load;
            pntop.ResumeLayout(false);
            topLayout.ResumeLayout(false);
            actionPanel.ResumeLayout(false);
            employeePanel.ResumeLayout(false);
            employeePanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDanhSachNhanVien).EndInit();
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel topLayout;
        private FlowLayoutPanel actionPanel;
        private TableLayoutPanel employeePanel;
        private TableLayoutPanel searchPanel;
        private TableLayoutPanel mainLayout;
        private DataGridViewTextBoxColumn NhanVienID;
        private DataGridViewTextBoxColumn TenChucVu;
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
        private DataGridViewTextBoxColumn PhongBanID;
        private DataGridViewTextBoxColumn ChucVuID;
        private DataGridViewTextBoxColumn TrinhDoID;
    }
}
