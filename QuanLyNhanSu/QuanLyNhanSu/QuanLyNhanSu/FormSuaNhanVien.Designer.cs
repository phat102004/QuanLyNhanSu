namespace QuanLyNhanSu
{
    partial class FormSuaNhanVien
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

        private void InitializeComponent()
        {
            label3 = new Label();
            groupBox1 = new GroupBox();
            BtnQuayLai = new Button();
            DtpNgayVaoLam = new DateTimePicker();
            DtpNgaySinh = new DateTimePicker();
            CbxChucVu = new ComboBox();
            CbxPhongBan = new ComboBox();
            CbxTrinhDo = new ComboBox();
            label14 = new Label();
            label18 = new Label();
            BtnSuaNhanVien = new Button();
            label10 = new Label();
            label11 = new Label();
            CbxTrangThaiLamViec = new ComboBox();
            label13 = new Label();
            label6 = new Label();
            TxtCMND_CCCD = new TextBox();
            label7 = new Label();
            TxtEmail = new TextBox();
            label8 = new Label();
            TxtSoDienThoai = new TextBox();
            label9 = new Label();
            TxtDiaChi = new TextBox();
            label4 = new Label();
            CbxGioiTinh = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            TxtTenNhanVien = new TextBox();
            label1 = new Label();
            TxtMaNhanVien = new TextBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(28, 20);
            label3.Name = "label3";
            label3.Size = new Size(571, 65);
            label3.TabIndex = 3;
            label3.Text = "Sửa thông tin nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(BtnQuayLai);
            groupBox1.Controls.Add(DtpNgayVaoLam);
            groupBox1.Controls.Add(DtpNgaySinh);
            groupBox1.Controls.Add(CbxChucVu);
            groupBox1.Controls.Add(CbxPhongBan);
            groupBox1.Controls.Add(CbxTrinhDo);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(BtnSuaNhanVien);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(CbxTrangThaiLamViec);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TxtCMND_CCCD);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtEmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(TxtSoDienThoai);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(TxtDiaChi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(CbxGioiTinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtTenNhanVien);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtMaNhanVien);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(20, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2020, 1440);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // BtnQuayLai
            // 
            BtnQuayLai.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnQuayLai.Location = new Point(1040, 805);
            BtnQuayLai.Name = "BtnQuayLai";
            BtnQuayLai.Size = new Size(210, 55);
            BtnQuayLai.TabIndex = 42;
            BtnQuayLai.Text = "Quay lại";
            BtnQuayLai.UseVisualStyleBackColor = true;
            BtnQuayLai.Click += BtnQuayLai_Click;
            // 
            // DtpNgayVaoLam
            // 
            DtpNgayVaoLam.CustomFormat = "dd/MM/yyyy";
            DtpNgayVaoLam.Font = new Font("Segoe UI", 11F);
            DtpNgayVaoLam.Format = DateTimePickerFormat.Custom;
            DtpNgayVaoLam.Location = new Point(30, 570);
            DtpNgayVaoLam.Name = "DtpNgayVaoLam";
            DtpNgayVaoLam.Size = new Size(900, 47);
            DtpNgayVaoLam.TabIndex = 41;
            // 
            // DtpNgaySinh
            // 
            DtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            DtpNgaySinh.Font = new Font("Segoe UI", 11F);
            DtpNgaySinh.Format = DateTimePickerFormat.Custom;
            DtpNgaySinh.Location = new Point(30, 210);
            DtpNgaySinh.Name = "DtpNgaySinh";
            DtpNgaySinh.Size = new Size(900, 47);
            DtpNgaySinh.TabIndex = 40;
            // 
            // CbxChucVu
            // 
            CbxChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxChucVu.Font = new Font("Segoe UI", 11F);
            CbxChucVu.FormattingEnabled = true;
            CbxChucVu.Location = new Point(1040, 690);
            CbxChucVu.Name = "CbxChucVu";
            CbxChucVu.Size = new Size(930, 48);
            CbxChucVu.TabIndex = 39;
            // 
            // CbxPhongBan
            // 
            CbxPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxPhongBan.Font = new Font("Segoe UI", 11F);
            CbxPhongBan.FormattingEnabled = true;
            CbxPhongBan.Location = new Point(30, 690);
            CbxPhongBan.Name = "CbxPhongBan";
            CbxPhongBan.Size = new Size(900, 48);
            CbxPhongBan.TabIndex = 38;
            // 
            // CbxTrinhDo
            // 
            CbxTrinhDo.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxTrinhDo.Font = new Font("Segoe UI", 11F);
            CbxTrinhDo.FormattingEnabled = true;
            CbxTrinhDo.Location = new Point(30, 810);
            CbxTrinhDo.Name = "CbxTrinhDo";
            CbxTrinhDo.Size = new Size(900, 48);
            CbxTrinhDo.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label14.Location = new Point(30, 775);
            label14.Name = "label14";
            label14.Size = new Size(144, 41);
            label14.TabIndex = 36;
            label14.Text = "Trình độ:";
            // 
            // label18
            // 
            label18.Location = new Point(0, 0);
            label18.Name = "label18";
            label18.Size = new Size(100, 23);
            label18.TabIndex = 43;
            // 
            // BtnSuaNhanVien
            // 
            BtnSuaNhanVien.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnSuaNhanVien.Location = new Point(1270, 805);
            BtnSuaNhanVien.Name = "BtnSuaNhanVien";
            BtnSuaNhanVien.Size = new Size(250, 55);
            BtnSuaNhanVien.TabIndex = 32;
            BtnSuaNhanVien.Text = "Lưu thay đổi";
            BtnSuaNhanVien.UseVisualStyleBackColor = true;
            BtnSuaNhanVien.Click += BtnSuaNhanVien_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.Location = new Point(1040, 655);
            label10.Name = "label10";
            label10.Size = new Size(139, 41);
            label10.TabIndex = 23;
            label10.Text = "Chức vụ:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.Location = new Point(30, 655);
            label11.Name = "label11";
            label11.Size = new Size(178, 41);
            label11.TabIndex = 21;
            label11.Text = "Phòng ban:";
            // 
            // CbxTrangThaiLamViec
            // 
            CbxTrangThaiLamViec.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxTrangThaiLamViec.Font = new Font("Segoe UI", 12F);
            CbxTrangThaiLamViec.FormattingEnabled = true;
            CbxTrangThaiLamViec.Items.AddRange(new object[] { "Đang làm việc", "Thử việc", "Tạm nghỉ", "Nghỉ việc" });
            CbxTrangThaiLamViec.Location = new Point(1040, 568);
            CbxTrangThaiLamViec.Name = "CbxTrangThaiLamViec";
            CbxTrangThaiLamViec.Size = new Size(900, 53);
            CbxTrangThaiLamViec.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.Location = new Point(30, 535);
            label13.Name = "label13";
            label13.Size = new Size(219, 41);
            label13.TabIndex = 17;
            label13.Text = "Ngày vào làm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(1040, 415);
            label6.Name = "label6";
            label6.Size = new Size(210, 41);
            label6.TabIndex = 15;
            label6.Text = "CMND/CCCD:";
            // 
            // TxtCMND_CCCD
            // 
            TxtCMND_CCCD.Font = new Font("Segoe UI", 11F);
            TxtCMND_CCCD.Location = new Point(1040, 450);
            TxtCMND_CCCD.Name = "TxtCMND_CCCD";
            TxtCMND_CCCD.Size = new Size(930, 47);
            TxtCMND_CCCD.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(30, 415);
            label7.Name = "label7";
            label7.Size = new Size(103, 41);
            label7.TabIndex = 13;
            label7.Text = "Email:";
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Segoe UI", 11F);
            TxtEmail.Location = new Point(30, 450);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(900, 47);
            TxtEmail.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.Location = new Point(1040, 295);
            label8.Name = "label8";
            label8.Size = new Size(212, 41);
            label8.TabIndex = 11;
            label8.Text = "Số điện thoại:";
            // 
            // TxtSoDienThoai
            // 
            TxtSoDienThoai.Font = new Font("Segoe UI", 11F);
            TxtSoDienThoai.Location = new Point(1040, 330);
            TxtSoDienThoai.Name = "TxtSoDienThoai";
            TxtSoDienThoai.Size = new Size(930, 47);
            TxtSoDienThoai.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.Location = new Point(30, 295);
            label9.Name = "label9";
            label9.Size = new Size(122, 41);
            label9.TabIndex = 9;
            label9.Text = "Địa chỉ:";
            // 
            // TxtDiaChi
            // 
            TxtDiaChi.Font = new Font("Segoe UI", 11F);
            TxtDiaChi.Location = new Point(30, 330);
            TxtDiaChi.Name = "TxtDiaChi";
            TxtDiaChi.Size = new Size(900, 47);
            TxtDiaChi.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(1040, 175);
            label4.Name = "label4";
            label4.Size = new Size(149, 41);
            label4.TabIndex = 7;
            label4.Text = "Giới tính:";
            // 
            // CbxGioiTinh
            // 
            CbxGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxGioiTinh.Font = new Font("Segoe UI", 12F);
            CbxGioiTinh.FormattingEnabled = true;
            CbxGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            CbxGioiTinh.Location = new Point(1035, 198);
            CbxGioiTinh.Name = "CbxGioiTinh";
            CbxGioiTinh.Size = new Size(900, 53);
            CbxGioiTinh.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(30, 175);
            label5.Name = "label5";
            label5.Size = new Size(167, 41);
            label5.TabIndex = 5;
            label5.Text = "Ngày sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(1040, 55);
            label2.Name = "label2";
            label2.Size = new Size(220, 41);
            label2.TabIndex = 3;
            label2.Text = "Tên nhân viên:";
            // 
            // TxtTenNhanVien
            // 
            TxtTenNhanVien.Font = new Font("Segoe UI", 11F);
            TxtTenNhanVien.Location = new Point(1040, 90);
            TxtTenNhanVien.Name = "TxtTenNhanVien";
            TxtTenNhanVien.Size = new Size(930, 47);
            TxtTenNhanVien.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(30, 55);
            label1.Name = "label1";
            label1.Size = new Size(216, 41);
            label1.TabIndex = 1;
            label1.Text = "Mã nhân viên:";
            // 
            // TxtMaNhanVien
            // 
            TxtMaNhanVien.Font = new Font("Segoe UI", 11F);
            TxtMaNhanVien.Location = new Point(30, 90);
            TxtMaNhanVien.Name = "TxtMaNhanVien";
            TxtMaNhanVien.ReadOnly = true;
            TxtMaNhanVien.Size = new Size(900, 47);
            TxtMaNhanVien.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.Location = new Point(1040, 524);
            label12.Name = "label12";
            label12.Size = new Size(293, 41);
            label12.TabIndex = 44;
            label12.Text = "Trạng thái làm việc:";
            // 
            // FormSuaNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2062, 1556);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "FormSuaNhanVien";
            Text = "Sửa thông tin nhân viên";
            Load += FormSuaNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label3;
        private GroupBox groupBox1;
        private DateTimePicker DtpNgayVaoLam;
        private DateTimePicker DtpNgaySinh;
        private ComboBox CbxChucVu;
        private ComboBox CbxPhongBan;
        private ComboBox CbxTrinhDo;
        private Label label14;
        private Label label18;
        private Button BtnSuaNhanVien;
        private Label label10;
        private Label label11;
        private ComboBox CbxTrangThaiLamViec;
        private Label label13;
        private Label label6;
        private TextBox TxtCMND_CCCD;
        private Label label7;
        private TextBox TxtEmail;
        private Label label8;
        private TextBox TxtSoDienThoai;
        private Label label9;
        private TextBox TxtDiaChi;
        private Label label4;
        private ComboBox CbxGioiTinh;
        private Label label5;
        private Label label2;
        private TextBox TxtTenNhanVien;
        private Label label1;
        private TextBox TxtMaNhanVien;
        private Button BtnQuayLai;
        private Label label12;
    }
}