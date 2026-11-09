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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label3 = new Label();
            groupBox1 = new GroupBox();
            contentLayout = new TableLayoutPanel();
            employeeGrid = new TableLayoutPanel();
            label9 = new Label();
            CbxChucVu = new ComboBox();
            label2 = new Label();
            CbxTenNhanVien = new ComboBox();
            detailGrid = new TableLayoutPanel();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            TxtMaLuong = new TextBox();
            DtpNgayTinhLuong = new DateTimePicker();
            TxtSoNgayCong = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            phuCapPanel = new Panel();
            BtnTinhPhuCap = new Button();
            TxtPhuCap = new TextBox();
            TxtLuongCoBan = new TextBox();
            TxtTongLuong = new TextBox();
            groupBox2 = new GroupBox();
            roleActions = new FlowLayoutPanel();
            BtnTaoChucVu = new Button();
            BtnSuaChucVu = new Button();
            BtnXoaChucVu = new Button();
            groupBox3 = new GroupBox();
            salaryActions = new FlowLayoutPanel();
            BtnTinhLuong = new Button();
            BtnSua = new Button();
            BtnXoa = new Button();
            BtnLamMoi = new Button();
            BtnLuuLuong = new Button();
            DgvTinhLuong = new DataGridView();
            MaLuong = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgayTinhLuong = new DataGridViewTextBoxColumn();
            SoNgayCong = new DataGridViewTextBoxColumn();
            TongPhuCap = new DataGridViewTextBoxColumn();
            TongLuong = new DataGridViewTextBoxColumn();
            TinhLuongID = new DataGridViewTextBoxColumn();
            TenChucVu = new DataGridViewTextBoxColumn();
            mainLayout = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            contentLayout.SuspendLayout();
            employeeGrid.SuspendLayout();
            detailGrid.SuspendLayout();
            phuCapPanel.SuspendLayout();
            groupBox3.SuspendLayout();
            salaryActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTinhLuong).BeginInit();
            mainLayout.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(25, 48, 80);
            label3.Location = new Point(23, 20);
            label3.Name = "label3";
            label3.Size = new Size(2042, 109);
            label3.TabIndex = 0;
            label3.Text = "TÍNH LƯƠNG NHÂN VIÊN";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(contentLayout);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(25, 48, 80);
            groupBox1.Location = new Point(20, 129);
            groupBox1.Margin = new Padding(0, 0, 0, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(14, 32, 14, 10);
            groupBox1.Size = new Size(2048, 744);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tính lương";
            // 
            // contentLayout
            // 
            contentLayout.ColumnCount = 1;
            contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentLayout.Controls.Add(employeeGrid, 0, 0);
            contentLayout.Controls.Add(detailGrid, 0, 1);
            contentLayout.Dock = DockStyle.Fill;
            contentLayout.Location = new Point(14, 68);
            contentLayout.Name = "contentLayout";
            contentLayout.RowCount = 2;
            contentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            contentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 56F));
            contentLayout.Size = new Size(2020, 666);
            contentLayout.TabIndex = 0;
            // 
            // employeeGrid
            // 
            employeeGrid.BackColor = Color.FromArgb(235, 244, 255);
            employeeGrid.ColumnCount = 1;
            employeeGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            employeeGrid.Controls.Add(label9, 0, 0);
            employeeGrid.Controls.Add(CbxChucVu, 0, 1);
            employeeGrid.Controls.Add(label2, 0, 2);
            employeeGrid.Controls.Add(CbxTenNhanVien, 0, 3);
            employeeGrid.Dock = DockStyle.Fill;
            employeeGrid.Location = new Point(3, 3);
            employeeGrid.Name = "employeeGrid";
            employeeGrid.Padding = new Padding(15, 8, 15, 8);
            employeeGrid.RowCount = 4;
            employeeGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            employeeGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            employeeGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            employeeGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            employeeGrid.Size = new Size(2014, 287);
            employeeGrid.TabIndex = 0;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(25, 48, 80);
            label9.Location = new Point(18, 8);
            label9.Name = "label9";
            label9.Size = new Size(1978, 59);
            label9.TabIndex = 0;
            label9.Text = "BƯỚC 1 - CHỌN CHỨC VỤ";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CbxChucVu
            // 
            CbxChucVu.Dock = DockStyle.Fill;
            CbxChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxChucVu.Font = new Font("Segoe UI", 11F);
            CbxChucVu.Location = new Point(15, 67);
            CbxChucVu.Margin = new Padding(0, 0, 0, 4);
            CbxChucVu.Name = "CbxChucVu";
            CbxChucVu.Size = new Size(1984, 48);
            CbxChucVu.TabIndex = 1;
            CbxChucVu.SelectedIndexChanged += CbxChucVu_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(25, 48, 80);
            label2.Location = new Point(18, 142);
            label2.Name = "label2";
            label2.Size = new Size(1978, 59);
            label2.TabIndex = 2;
            label2.Text = "BƯỚC 2 - CHỌN NHÂN VIÊN THEO CHỨC VỤ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CbxTenNhanVien
            // 
            CbxTenNhanVien.Dock = DockStyle.Fill;
            CbxTenNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxTenNhanVien.Font = new Font("Segoe UI", 11F);
            CbxTenNhanVien.Location = new Point(18, 204);
            CbxTenNhanVien.Name = "CbxTenNhanVien";
            CbxTenNhanVien.Size = new Size(1978, 48);
            CbxTenNhanVien.TabIndex = 3;
            CbxTenNhanVien.SelectedIndexChanged += CbxTenNhanVien_SelectedIndexChanged;
            // 
            // detailGrid
            // 
            detailGrid.ColumnCount = 3;
            detailGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            detailGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            detailGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.334F));
            detailGrid.Controls.Add(label1, 0, 0);
            detailGrid.Controls.Add(label6, 1, 0);
            detailGrid.Controls.Add(label4, 2, 0);
            detailGrid.Controls.Add(TxtMaLuong, 0, 1);
            detailGrid.Controls.Add(DtpNgayTinhLuong, 1, 1);
            detailGrid.Controls.Add(TxtSoNgayCong, 2, 1);
            detailGrid.Controls.Add(label5, 0, 2);
            detailGrid.Controls.Add(label7, 1, 2);
            detailGrid.Controls.Add(label8, 2, 2);
            detailGrid.Controls.Add(phuCapPanel, 0, 3);
            detailGrid.Controls.Add(TxtLuongCoBan, 1, 3);
            detailGrid.Controls.Add(TxtTongLuong, 2, 3);
            detailGrid.Dock = DockStyle.Fill;
            detailGrid.Location = new Point(3, 296);
            detailGrid.Name = "detailGrid";
            detailGrid.Padding = new Padding(10, 10, 10, 0);
            detailGrid.RowCount = 4;
            detailGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            detailGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            detailGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            detailGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            detailGrid.Size = new Size(2014, 367);
            detailGrid.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(658, 78);
            label1.TabIndex = 0;
            label1.Text = "Mã lương";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(677, 10);
            label6.Name = "label6";
            label6.Size = new Size(658, 78);
            label6.TabIndex = 1;
            label6.Text = "Ngày tính lương";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(1341, 10);
            label4.Name = "label4";
            label4.Size = new Size(660, 78);
            label4.TabIndex = 2;
            label4.Text = "Số ngày công";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TxtMaLuong
            // 
            TxtMaLuong.Dock = DockStyle.Fill;
            TxtMaLuong.Enabled = false;
            TxtMaLuong.Location = new Point(13, 91);
            TxtMaLuong.Name = "TxtMaLuong";
            TxtMaLuong.ReadOnly = true;
            TxtMaLuong.Size = new Size(658, 43);
            TxtMaLuong.TabIndex = 3;
            // 
            // DtpNgayTinhLuong
            // 
            DtpNgayTinhLuong.CustomFormat = "dd/MM/yyyy";
            DtpNgayTinhLuong.Dock = DockStyle.Fill;
            DtpNgayTinhLuong.Format = DateTimePickerFormat.Custom;
            DtpNgayTinhLuong.Location = new Point(677, 91);
            DtpNgayTinhLuong.Name = "DtpNgayTinhLuong";
            DtpNgayTinhLuong.Size = new Size(658, 43);
            DtpNgayTinhLuong.TabIndex = 4;
            // 
            // TxtSoNgayCong
            // 
            TxtSoNgayCong.Dock = DockStyle.Fill;
            TxtSoNgayCong.Location = new Point(1341, 91);
            TxtSoNgayCong.Name = "TxtSoNgayCong";
            TxtSoNgayCong.ReadOnly = true;
            TxtSoNgayCong.Size = new Size(660, 43);
            TxtSoNgayCong.TabIndex = 5;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(13, 187);
            label5.Name = "label5";
            label5.Size = new Size(658, 78);
            label5.TabIndex = 6;
            label5.Text = "Phụ cấp";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(677, 187);
            label7.Name = "label7";
            label7.Size = new Size(658, 78);
            label7.TabIndex = 7;
            label7.Text = "Lương cơ bản";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(1341, 187);
            label8.Name = "label8";
            label8.Size = new Size(660, 78);
            label8.TabIndex = 8;
            label8.Text = "Tổng lương";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // phuCapPanel
            // 
            phuCapPanel.Controls.Add(BtnTinhPhuCap);
            phuCapPanel.Controls.Add(TxtPhuCap);
            phuCapPanel.Dock = DockStyle.Fill;
            phuCapPanel.Location = new Point(13, 268);
            phuCapPanel.Name = "phuCapPanel";
            phuCapPanel.Size = new Size(658, 96);
            phuCapPanel.TabIndex = 9;
            // 
            // BtnTinhPhuCap
            // 
            BtnTinhPhuCap.BackColor = Color.FromArgb(35, 91, 155);
            BtnTinhPhuCap.Dock = DockStyle.Right;
            BtnTinhPhuCap.FlatStyle = FlatStyle.Flat;
            BtnTinhPhuCap.ForeColor = Color.White;
            BtnTinhPhuCap.Location = new Point(445, 0);
            BtnTinhPhuCap.Name = "BtnTinhPhuCap";
            BtnTinhPhuCap.Size = new Size(213, 96);
            BtnTinhPhuCap.TabIndex = 0;
            BtnTinhPhuCap.Text = "Tính phụ cấp";
            BtnTinhPhuCap.UseVisualStyleBackColor = false;
            BtnTinhPhuCap.Click += BtnTinhPhuCap_Click;
            // 
            // TxtPhuCap
            // 
            TxtPhuCap.Dock = DockStyle.Fill;
            TxtPhuCap.Location = new Point(0, 0);
            TxtPhuCap.Name = "TxtPhuCap";
            TxtPhuCap.ReadOnly = true;
            TxtPhuCap.Size = new Size(658, 43);
            TxtPhuCap.TabIndex = 1;
            // 
            // TxtLuongCoBan
            // 
            TxtLuongCoBan.Dock = DockStyle.Fill;
            TxtLuongCoBan.Location = new Point(677, 268);
            TxtLuongCoBan.Name = "TxtLuongCoBan";
            TxtLuongCoBan.ReadOnly = true;
            TxtLuongCoBan.Size = new Size(658, 43);
            TxtLuongCoBan.TabIndex = 10;
            // 
            // TxtTongLuong
            // 
            TxtTongLuong.BackColor = Color.FromArgb(235, 244, 255);
            TxtTongLuong.Dock = DockStyle.Fill;
            TxtTongLuong.Location = new Point(1341, 268);
            TxtTongLuong.Name = "TxtTongLuong";
            TxtTongLuong.ReadOnly = true;
            TxtTongLuong.Size = new Size(660, 43);
            TxtTongLuong.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(23, 884);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // roleActions
            // 
            roleActions.Location = new Point(0, 0);
            roleActions.Name = "roleActions";
            roleActions.Size = new Size(200, 100);
            roleActions.TabIndex = 0;
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
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(salaryActions);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(20, 1037);
            groupBox3.Margin = new Padding(0, 0, 0, 8);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 24, 10, 4);
            groupBox3.Size = new Size(2048, 540);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thao tác bảng lương";
            // 
            // salaryActions
            // 
            salaryActions.AutoScroll = true;
            salaryActions.Controls.Add(BtnTinhLuong);
            salaryActions.Controls.Add(BtnSua);
            salaryActions.Controls.Add(BtnXoa);
            salaryActions.Controls.Add(BtnLamMoi);
            salaryActions.Controls.Add(BtnLuuLuong);
            salaryActions.Dock = DockStyle.Fill;
            salaryActions.Location = new Point(10, 60);
            salaryActions.Name = "salaryActions";
            salaryActions.Size = new Size(2028, 476);
            salaryActions.TabIndex = 0;
            salaryActions.WrapContents = false;
            // 
            // BtnTinhLuong
            // 
            BtnTinhLuong.Location = new Point(3, 3);
            BtnTinhLuong.Name = "BtnTinhLuong";
            BtnTinhLuong.Size = new Size(270, 48);
            BtnTinhLuong.TabIndex = 0;
            BtnTinhLuong.Text = "Tính lương nhân viên";
            BtnTinhLuong.Click += BtnTinhLuong_Click;
            // 
            // BtnSua
            // 
            BtnSua.Location = new Point(279, 3);
            BtnSua.Name = "BtnSua";
            BtnSua.Size = new Size(180, 48);
            BtnSua.TabIndex = 1;
            BtnSua.Text = "Sửa";
            BtnSua.Click += BtnSua_Click;
            // 
            // BtnXoa
            // 
            BtnXoa.Location = new Point(465, 3);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(180, 48);
            BtnXoa.TabIndex = 2;
            BtnXoa.Text = "Xóa";
            BtnXoa.Click += BtnXoa_Click;
            // 
            // BtnLamMoi
            // 
            BtnLamMoi.Location = new Point(651, 3);
            BtnLamMoi.Name = "BtnLamMoi";
            BtnLamMoi.Size = new Size(180, 48);
            BtnLamMoi.TabIndex = 3;
            BtnLamMoi.Text = "Làm mới";
            BtnLamMoi.Click += BtnLamMoi_Click;
            // 
            // BtnLuuLuong
            // 
            BtnLuuLuong.Location = new Point(837, 3);
            BtnLuuLuong.Name = "BtnLuuLuong";
            BtnLuuLuong.Size = new Size(250, 48);
            BtnLuuLuong.TabIndex = 4;
            BtnLuuLuong.Text = "Lưu bảng lương";
            BtnLuuLuong.Click += BtnLuuLuong_Click;
            // 
            // DgvTinhLuong
            // 
            DgvTinhLuong.AllowUserToAddRows = false;
            DgvTinhLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTinhLuong.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 48, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvTinhLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvTinhLuong.ColumnHeadersHeight = 48;
            DgvTinhLuong.Columns.AddRange(new DataGridViewColumn[] { MaLuong, HoTen, NgayTinhLuong, SoNgayCong, TongPhuCap, TongLuong, TinhLuongID, TenChucVu });
            DgvTinhLuong.Dock = DockStyle.Fill;
            DgvTinhLuong.EnableHeadersVisualStyles = false;
            DgvTinhLuong.Location = new Point(23, 1588);
            DgvTinhLuong.Name = "DgvTinhLuong";
            DgvTinhLuong.ReadOnly = true;
            DgvTinhLuong.RowHeadersVisible = false;
            DgvTinhLuong.RowHeadersWidth = 82;
            DgvTinhLuong.RowTemplate.Height = 40;
            DgvTinhLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvTinhLuong.Size = new Size(2042, 16);
            DgvTinhLuong.TabIndex = 4;
            DgvTinhLuong.CellContentClick += DgvTinhLuong_CellContentClick;
            // 
            // MaLuong
            // 
            MaLuong.DataPropertyName = "MaLuong";
            MaLuong.HeaderText = "Mã lương";
            MaLuong.MinimumWidth = 10;
            MaLuong.Name = "MaLuong";
            MaLuong.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Tên nhân viên";
            HoTen.MinimumWidth = 10;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // NgayTinhLuong
            // 
            NgayTinhLuong.DataPropertyName = "NgayTinhLuong";
            NgayTinhLuong.HeaderText = "Ngày tính lương";
            NgayTinhLuong.MinimumWidth = 10;
            NgayTinhLuong.Name = "NgayTinhLuong";
            NgayTinhLuong.ReadOnly = true;
            // 
            // SoNgayCong
            // 
            SoNgayCong.DataPropertyName = "SoNgayCong";
            SoNgayCong.HeaderText = "Số ngày công";
            SoNgayCong.MinimumWidth = 10;
            SoNgayCong.Name = "SoNgayCong";
            SoNgayCong.ReadOnly = true;
            // 
            // TongPhuCap
            // 
            TongPhuCap.DataPropertyName = "TongPhuCap";
            TongPhuCap.HeaderText = "Tổng phụ cấp";
            TongPhuCap.MinimumWidth = 10;
            TongPhuCap.Name = "TongPhuCap";
            TongPhuCap.ReadOnly = true;
            // 
            // TongLuong
            // 
            TongLuong.DataPropertyName = "TongLuong";
            TongLuong.HeaderText = "Tổng lương";
            TongLuong.MinimumWidth = 10;
            TongLuong.Name = "TongLuong";
            TongLuong.ReadOnly = true;
            // 
            // TinhLuongID
            // 
            TinhLuongID.DataPropertyName = "TinhLuongID";
            TinhLuongID.MinimumWidth = 10;
            TinhLuongID.Name = "TinhLuongID";
            TinhLuongID.ReadOnly = true;
            TinhLuongID.Visible = false;
            // 
            // TenChucVu
            // 
            TenChucVu.DataPropertyName = "TenChucVu";
            TenChucVu.MinimumWidth = 10;
            TenChucVu.Name = "TenChucVu";
            TenChucVu.ReadOnly = true;
            TenChucVu.Visible = false;
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(245, 247, 251);
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(label3, 0, 0);
            mainLayout.Controls.Add(groupBox1, 0, 1);
            mainLayout.Controls.Add(groupBox2, 0, 2);
            mainLayout.Controls.Add(groupBox3, 0, 3);
            mainLayout.Controls.Add(DgvTinhLuong, 0, 4);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(20);
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.Size = new Size(2088, 1627);
            mainLayout.TabIndex = 0;
            // 
            // TinhLuong
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(mainLayout);
            Font = new Font("Segoe UI", 10F);
            Name = "TinhLuong";
            Size = new Size(2088, 1627);
            Load += TinhLuong_Load;
            groupBox1.ResumeLayout(false);
            contentLayout.ResumeLayout(false);
            employeeGrid.ResumeLayout(false);
            detailGrid.ResumeLayout(false);
            detailGrid.PerformLayout();
            phuCapPanel.ResumeLayout(false);
            phuCapPanel.PerformLayout();
            groupBox3.ResumeLayout(false);
            salaryActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvTinhLuong).EndInit();
            mainLayout.ResumeLayout(false);
            ResumeLayout(false);
        }


        // ==================================
        // HÀM TẠO Ô THÔNG TIN
        // ==================================
        private static void AddSalaryField(
            TableLayoutPanel parent,
            Label label,
            string title,
            Control input,
            int column,
            int row)
        {
            Panel field = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(8),
                Padding = new Padding(12, 12, 12, 8),
                BackColor = Color.White
            };

            label.Text = title;
            label.Dock = DockStyle.Top;
            label.Height = 45;
            label.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(65, 78, 95);

            input.Dock = DockStyle.Top;
            input.Font = new Font("Segoe UI", 11F);
            input.Height = 52;

            field.Controls.Add(input);
            field.Controls.Add(label);

            parent.Controls.Add(field, column, row);
        }


        private static Panel CreateSelectionField(
            string title,
            ComboBox combo)
        {
            Panel container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(235, 244, 255),
                Margin = new Padding(8, 5, 8, 5),
                Padding = new Padding(20, 8, 20, 8),
                BorderStyle = BorderStyle.FixedSingle
            };

            TableLayoutPanel layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2
            };

            layout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 38F));

            layout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            layout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            Label label = new Label
            {
                Text = title,
                Font = new Font(
                    "Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 48, 80),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            combo.Dock = DockStyle.Top;
            combo.Font = new Font("Segoe UI", 11F);
            combo.Margin = new Padding(0, 4, 0, 0);
            combo.BackColor = Color.White;

            layout.Controls.Add(label, 0, 0);
            layout.Controls.Add(combo, 0, 1);

            container.Controls.Add(layout);

            return container;
        }


        // ==================================
        // HÀM STYLE BUTTON
        // ==================================
        private static void StyleActionButton(
            Button btn,
            Color background,
            bool primary)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = primary ? 0 : 1;
            btn.FlatAppearance.BorderColor =
                Color.FromArgb(203, 213, 225);

            btn.BackColor = background;
            btn.ForeColor = primary
                ? Color.White
                : Color.FromArgb(35, 55, 80);

            btn.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
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
        private DataGridViewTextBoxColumn NhanVienID;
        private DataGridViewTextBoxColumn TenChucVu;
        private Button BtnLamMoi;
        private Button BtnXoa;
        private Button BtnSua;
        private Button BtnLuuLuong;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel contentLayout;
        private TableLayoutPanel employeeGrid;
        private TableLayoutPanel detailGrid;
        private FlowLayoutPanel roleActions;
        private FlowLayoutPanel salaryActions;
        private Panel phuCapPanel;
    }
}
