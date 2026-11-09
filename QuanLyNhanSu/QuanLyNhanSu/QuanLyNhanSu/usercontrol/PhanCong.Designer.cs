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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            groupBox1 = new GroupBox();
            formLayout = new TableLayoutPanel();
            panelNhanVien = new Panel();
            label9 = new Label();
            CbxChucVu = new ComboBox();
            label2 = new Label();
            CbxTenNhanVien = new ComboBox();
            panelCongViec = new Panel();
            label4 = new Label();
            TxtTenCongViec = new TextBox();
            label6 = new Label();
            DtpNgayGiao = new DateTimePicker();
            label5 = new Label();
            DtpHanHoanThanh = new DateTimePicker();
            label1 = new Label();
            TxtIDCongViec = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            actionPanel = new FlowLayoutPanel();
            BtnPhanCong = new Button();
            BtnXoa = new Button();
            BtnLamMoi = new Button();
            BtnLuuLuong = new Button();
            BtnTaoChucVu = new Button();
            BtnSuaChucVu = new Button();
            BtnXoaChucVu = new Button();
            DgvPhanCong = new DataGridView();
            CongViecID = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            TenCongViec = new DataGridViewTextBoxColumn();
            NgayGiao = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            mainLayout = new TableLayoutPanel();
            lblDanhSach = new Label();
            groupBox1.SuspendLayout();
            formLayout.SuspendLayout();
            panelNhanVien.SuspendLayout();
            panelCongViec.SuspendLayout();
            groupBox3.SuspendLayout();
            actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPhanCong).BeginInit();
            mainLayout.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(25, 48, 80);
            label3.Location = new Point(29, 26);
            label3.Name = "label3";
            label3.Size = new Size(2030, 105);
            label3.TabIndex = 0;
            label3.Text = "PHÂN CÔNG CÔNG VIỆC";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(formLayout);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(25, 48, 80);
            groupBox1.Location = new Point(26, 131);
            groupBox1.Margin = new Padding(0, 0, 0, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(18, 40, 18, 16);
            groupBox1.Size = new Size(2036, 498);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phân công";
            // 
            // formLayout
            // 
            formLayout.BackColor = Color.White;
            formLayout.ColumnCount = 2;
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            formLayout.Controls.Add(panelNhanVien, 0, 0);
            formLayout.Controls.Add(panelCongViec, 1, 0);
            formLayout.Dock = DockStyle.Fill;
            formLayout.Location = new Point(18, 80);
            formLayout.Name = "formLayout";
            formLayout.RowCount = 1;
            formLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            formLayout.Size = new Size(2000, 402);
            formLayout.TabIndex = 0;
            // 
            // panelNhanVien
            // 
            panelNhanVien.BackColor = Color.FromArgb(235, 244, 255);
            panelNhanVien.Controls.Add(label9);
            panelNhanVien.Controls.Add(CbxChucVu);
            panelNhanVien.Controls.Add(label2);
            panelNhanVien.Controls.Add(CbxTenNhanVien);
            panelNhanVien.Dock = DockStyle.Fill;
            panelNhanVien.Location = new Point(8, 8);
            panelNhanVien.Margin = new Padding(8);
            panelNhanVien.Name = "panelNhanVien";
            panelNhanVien.Padding = new Padding(22);
            panelNhanVien.Size = new Size(884, 386);
            panelNhanVien.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(25, 48, 80);
            label9.Location = new Point(22, 35);
            label9.Name = "label9";
            label9.Size = new Size(837, 42);
            label9.TabIndex = 0;
            label9.Text = "BƯỚC 1  -  CHỌN CHỨC VỤ";
            // 
            // CbxChucVu
            // 
            CbxChucVu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbxChucVu.BackColor = Color.White;
            CbxChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxChucVu.Font = new Font("Segoe UI", 11F);
            CbxChucVu.Location = new Point(22, 90);
            CbxChucVu.Name = "CbxChucVu";
            CbxChucVu.Size = new Size(837, 48);
            CbxChucVu.TabIndex = 1;
            CbxChucVu.SelectedIndexChanged += CbxChucVu_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(25, 48, 80);
            label2.Location = new Point(22, 185);
            label2.Name = "label2";
            label2.Size = new Size(837, 42);
            label2.TabIndex = 2;
            label2.Text = "BƯỚC 2  -  CHỌN NHÂN VIÊN THEO CHỨC VỤ";
            // 
            // CbxTenNhanVien
            // 
            CbxTenNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbxTenNhanVien.BackColor = Color.White;
            CbxTenNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxTenNhanVien.Font = new Font("Segoe UI", 11F);
            CbxTenNhanVien.Location = new Point(22, 240);
            CbxTenNhanVien.Name = "CbxTenNhanVien";
            CbxTenNhanVien.Size = new Size(837, 48);
            CbxTenNhanVien.TabIndex = 3;
            // 
            // panelCongViec
            // 
            panelCongViec.BackColor = Color.FromArgb(248, 250, 253);
            panelCongViec.Controls.Add(label4);
            panelCongViec.Controls.Add(TxtTenCongViec);
            panelCongViec.Controls.Add(label6);
            panelCongViec.Controls.Add(DtpNgayGiao);
            panelCongViec.Controls.Add(label5);
            panelCongViec.Controls.Add(DtpHanHoanThanh);
            panelCongViec.Controls.Add(label1);
            panelCongViec.Controls.Add(TxtIDCongViec);
            panelCongViec.Dock = DockStyle.Fill;
            panelCongViec.Location = new Point(908, 8);
            panelCongViec.Margin = new Padding(8);
            panelCongViec.Name = "panelCongViec";
            panelCongViec.Padding = new Padding(22);
            panelCongViec.Size = new Size(1084, 386);
            panelCongViec.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 60, 80);
            label4.Location = new Point(22, 28);
            label4.Name = "label4";
            label4.Size = new Size(900, 40);
            label4.TabIndex = 0;
            label4.Text = "TÊN CÔNG VIỆC";
            // 
            // TxtTenCongViec
            // 
            TxtTenCongViec.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtTenCongViec.BorderStyle = BorderStyle.FixedSingle;
            TxtTenCongViec.Font = new Font("Segoe UI", 11F);
            TxtTenCongViec.Location = new Point(22, 78);
            TxtTenCongViec.Name = "TxtTenCongViec";
            TxtTenCongViec.Size = new Size(1037, 47);
            TxtTenCongViec.TabIndex = 1;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 60, 80);
            label6.Location = new Point(22, 170);
            label6.Name = "label6";
            label6.Size = new Size(420, 40);
            label6.TabIndex = 2;
            label6.Text = "NGÀY GIAO";
            // 
            // DtpNgayGiao
            // 
            DtpNgayGiao.CustomFormat = "dd/MM/yyyy";
            DtpNgayGiao.Font = new Font("Segoe UI", 11F);
            DtpNgayGiao.Format = DateTimePickerFormat.Custom;
            DtpNgayGiao.Location = new Point(22, 220);
            DtpNgayGiao.Name = "DtpNgayGiao";
            DtpNgayGiao.Size = new Size(440, 47);
            DtpNgayGiao.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 60, 80);
            label5.Location = new Point(520, 170);
            label5.Name = "label5";
            label5.Size = new Size(450, 40);
            label5.TabIndex = 4;
            label5.Text = "HẠN HOÀN THÀNH";
            // 
            // DtpHanHoanThanh
            // 
            DtpHanHoanThanh.CustomFormat = "dd/MM/yyyy";
            DtpHanHoanThanh.Font = new Font("Segoe UI", 11F);
            DtpHanHoanThanh.Format = DateTimePickerFormat.Custom;
            DtpHanHoanThanh.Location = new Point(520, 220);
            DtpHanHoanThanh.Name = "DtpHanHoanThanh";
            DtpHanHoanThanh.Size = new Size(460, 47);
            DtpHanHoanThanh.TabIndex = 5;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "ID Công việc";
            label1.Visible = false;
            // 
            // TxtIDCongViec
            // 
            TxtIDCongViec.Location = new Point(0, 0);
            TxtIDCongViec.Name = "TxtIDCongViec";
            TxtIDCongViec.Size = new Size(100, 47);
            TxtIDCongViec.TabIndex = 7;
            TxtIDCongViec.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(actionPanel);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(25, 48, 80);
            groupBox3.Location = new Point(26, 641);
            groupBox3.Margin = new Padding(0, 0, 0, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(16, 30, 16, 12);
            groupBox3.Size = new Size(2036, 133);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thao tác phân công";
            // 
            // actionPanel
            // 
            actionPanel.AutoScroll = true;
            actionPanel.Controls.Add(BtnPhanCong);
            actionPanel.Controls.Add(BtnXoa);
            actionPanel.Controls.Add(BtnLamMoi);
            actionPanel.Dock = DockStyle.Fill;
            actionPanel.Location = new Point(16, 66);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(2004, 55);
            actionPanel.TabIndex = 0;
            actionPanel.WrapContents = false;
            // 
            // BtnPhanCong
            // 
            BtnPhanCong.BackColor = Color.FromArgb(35, 91, 155);
            BtnPhanCong.FlatAppearance.BorderSize = 0;
            BtnPhanCong.FlatStyle = FlatStyle.Flat;
            BtnPhanCong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnPhanCong.ForeColor = Color.White;
            BtnPhanCong.Location = new Point(0, 0);
            BtnPhanCong.Margin = new Padding(0, 0, 16, 0);
            BtnPhanCong.Name = "BtnPhanCong";
            BtnPhanCong.Size = new Size(280, 65);
            BtnPhanCong.TabIndex = 0;
            BtnPhanCong.Text = "＋  PHÂN CÔNG";
            BtnPhanCong.UseVisualStyleBackColor = false;
            BtnPhanCong.Click += BtnPhanCong_Click;
            // 
            // BtnXoa
            // 
            BtnXoa.BackColor = Color.White;
            BtnXoa.FlatAppearance.BorderColor = Color.FromArgb(220, 225, 230);
            BtnXoa.FlatStyle = FlatStyle.Flat;
            BtnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnXoa.ForeColor = Color.FromArgb(155, 45, 45);
            BtnXoa.Location = new Point(296, 0);
            BtnXoa.Margin = new Padding(0, 0, 16, 0);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(230, 65);
            BtnXoa.TabIndex = 1;
            BtnXoa.Text = "Xóa công việc";
            BtnXoa.UseVisualStyleBackColor = false;
            BtnXoa.Click += BtnXoa_Click;
            // 
            // BtnLamMoi
            // 
            BtnLamMoi.BackColor = Color.White;
            BtnLamMoi.FlatAppearance.BorderColor = Color.FromArgb(220, 225, 230);
            BtnLamMoi.FlatStyle = FlatStyle.Flat;
            BtnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnLamMoi.ForeColor = Color.FromArgb(25, 48, 80);
            BtnLamMoi.Location = new Point(542, 0);
            BtnLamMoi.Margin = new Padding(0, 0, 16, 0);
            BtnLamMoi.Name = "BtnLamMoi";
            BtnLamMoi.Size = new Size(210, 65);
            BtnLamMoi.TabIndex = 2;
            BtnLamMoi.Text = "Làm mới";
            BtnLamMoi.UseVisualStyleBackColor = false;
            BtnLamMoi.Click += BtnLamMoi_Click;
            // 
            // BtnLuuLuong
            // 
            BtnLuuLuong.Location = new Point(0, 0);
            BtnLuuLuong.Name = "BtnLuuLuong";
            BtnLuuLuong.Size = new Size(75, 23);
            BtnLuuLuong.TabIndex = 0;
            // 
            // BtnTaoChucVu
            // 
            BtnTaoChucVu.Location = new Point(0, 0);
            BtnTaoChucVu.Name = "BtnTaoChucVu";
            BtnTaoChucVu.Size = new Size(75, 23);
            BtnTaoChucVu.TabIndex = 0;
            // 
            // BtnSuaChucVu
            // 
            BtnSuaChucVu.Location = new Point(0, 0);
            BtnSuaChucVu.Name = "BtnSuaChucVu";
            BtnSuaChucVu.Size = new Size(75, 23);
            BtnSuaChucVu.TabIndex = 0;
            // 
            // BtnXoaChucVu
            // 
            BtnXoaChucVu.Location = new Point(0, 0);
            BtnXoaChucVu.Name = "BtnXoaChucVu";
            BtnXoaChucVu.Size = new Size(75, 23);
            BtnXoaChucVu.TabIndex = 0;
            // 
            // DgvPhanCong
            // 
            DgvPhanCong.AllowUserToAddRows = false;
            DgvPhanCong.AllowUserToDeleteRows = false;
            DgvPhanCong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 250, 253);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(40, 55, 75);
            DgvPhanCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPhanCong.BackgroundColor = Color.White;
            DgvPhanCong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 48, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(25, 48, 80);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvPhanCong.ColumnHeadersHeight = 56;
            DgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvPhanCong.Columns.AddRange(new DataGridViewColumn[] { CongViecID, HoTen, TenCongViec, NgayGiao, TrangThai });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(40, 55, 75);
            dataGridViewCellStyle4.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(25, 48, 80);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgvPhanCong.DefaultCellStyle = dataGridViewCellStyle4;
            DgvPhanCong.Dock = DockStyle.Fill;
            DgvPhanCong.EnableHeadersVisualStyles = false;
            DgvPhanCong.GridColor = Color.FromArgb(220, 225, 232);
            DgvPhanCong.Location = new Point(26, 786);
            DgvPhanCong.Margin = new Padding(0);
            DgvPhanCong.MultiSelect = false;
            DgvPhanCong.Name = "DgvPhanCong";
            DgvPhanCong.ReadOnly = true;
            DgvPhanCong.RowHeadersVisible = false;
            DgvPhanCong.RowHeadersWidth = 82;
            DgvPhanCong.RowTemplate.Height = 46;
            DgvPhanCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPhanCong.Size = new Size(2036, 815);
            DgvPhanCong.TabIndex = 3;
            DgvPhanCong.CellContentClick += DgvPhanCong_CellContentClick;
            // 
            // CongViecID
            // 
            CongViecID.DataPropertyName = "CongViecID";
            CongViecID.HeaderText = "ID Công việc";
            CongViecID.MinimumWidth = 10;
            CongViecID.Name = "CongViecID";
            CongViecID.ReadOnly = true;
            CongViecID.Visible = false;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.FillWeight = 130F;
            HoTen.HeaderText = "Nhân viên";
            HoTen.MinimumWidth = 10;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // TenCongViec
            // 
            TenCongViec.DataPropertyName = "TenCongViec";
            TenCongViec.FillWeight = 220F;
            TenCongViec.HeaderText = "Tên công việc";
            TenCongViec.MinimumWidth = 10;
            TenCongViec.Name = "TenCongViec";
            TenCongViec.ReadOnly = true;
            // 
            // NgayGiao
            // 
            NgayGiao.DataPropertyName = "NgayGiao";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            NgayGiao.DefaultCellStyle = dataGridViewCellStyle3;
            NgayGiao.FillWeight = 110F;
            NgayGiao.HeaderText = "Ngày giao";
            NgayGiao.MinimumWidth = 10;
            NgayGiao.Name = "NgayGiao";
            NgayGiao.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.FillWeight = 130F;
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 10;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(label3, 0, 0);
            mainLayout.Controls.Add(groupBox1, 0, 1);
            mainLayout.Controls.Add(groupBox3, 0, 2);
            mainLayout.Controls.Add(DgvPhanCong, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(26);
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 510F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(2088, 1627);
            mainLayout.TabIndex = 0;
            // 
            // lblDanhSach
            // 
            lblDanhSach.Location = new Point(0, 0);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(100, 23);
            lblDanhSach.TabIndex = 0;
            // 
            // PhanCong
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(mainLayout);
            Font = new Font("Segoe UI", 10F);
            Name = "PhanCong";
            Size = new Size(2088, 1627);
            Load += PhanCong_Load;
            groupBox1.ResumeLayout(false);
            formLayout.ResumeLayout(false);
            panelNhanVien.ResumeLayout(false);
            panelCongViec.ResumeLayout(false);
            panelCongViec.PerformLayout();
            groupBox3.ResumeLayout(false);
            actionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPhanCong).EndInit();
            mainLayout.ResumeLayout(false);
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn CongViecID;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn TenCongViec;
        private DataGridViewTextBoxColumn NgayGiao;
        private DataGridViewTextBoxColumn HanHoanThanh;
        private DataGridViewTextBoxColumn TrangThai;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel formLayout;
        private Panel panelNhanVien;
        private Panel panelCongViec;
        private FlowLayoutPanel actionPanel;
        private Label lblDanhSach;
        private Label label1;
        private TextBox TxtIDCongViec;
    }
}
