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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            TxtTrangThaiLamVien = new TextBox();
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
            TxtGioiTinh = new TextBox();
            label5 = new Label();
            label2 = new Label();
            TxtTenNhanVien = new TextBox();
            label1 = new Label();
            TxtMaNhanVien = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(23, 23);
            label3.Name = "label3";
            label3.Size = new Size(297, 45);
            label3.TabIndex = 3;
            label3.Text = "Sửa nhân viên mới";
            // 
            // groupBox1
            // 
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
            groupBox1.Controls.Add(TxtTrangThaiLamVien);
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
            groupBox1.Controls.Add(TxtGioiTinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtTenNhanVien);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtMaNhanVien);
            groupBox1.Location = new Point(4, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2054, 1491);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // BtnQuayLai
            // 
            BtnQuayLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnQuayLai.Location = new Point(8, 1137);
            BtnQuayLai.Name = "BtnQuayLai";
            BtnQuayLai.Size = new Size(256, 56);
            BtnQuayLai.TabIndex = 42;
            BtnQuayLai.Text = "Quay lại";
            BtnQuayLai.UseVisualStyleBackColor = true;
            BtnQuayLai.Click += BtnQuayLai_Click;
            // 
            // DtpNgayVaoLam
            // 
            DtpNgayVaoLam.CustomFormat = "dd/MM/yyyy";
            DtpNgayVaoLam.Format = DateTimePickerFormat.Custom;
            DtpNgayVaoLam.Location = new Point(19, 577);
            DtpNgayVaoLam.Name = "DtpNgayVaoLam";
            DtpNgayVaoLam.Size = new Size(850, 39);
            DtpNgayVaoLam.TabIndex = 41;
            // 
            // DtpNgaySinh
            // 
            DtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            DtpNgaySinh.Format = DateTimePickerFormat.Custom;
            DtpNgaySinh.Location = new Point(19, 207);
            DtpNgaySinh.Name = "DtpNgaySinh";
            DtpNgaySinh.Size = new Size(850, 39);
            DtpNgaySinh.TabIndex = 40;
            // 
            // CbxChucVu
            // 
            CbxChucVu.FormattingEnabled = true;
            CbxChucVu.Location = new Point(1181, 690);
            CbxChucVu.Name = "CbxChucVu";
            CbxChucVu.Size = new Size(850, 40);
            CbxChucVu.TabIndex = 39;
            // 
            // CbxPhongBan
            // 
            CbxPhongBan.FormattingEnabled = true;
            CbxPhongBan.Location = new Point(19, 690);
            CbxPhongBan.Name = "CbxPhongBan";
            CbxPhongBan.Size = new Size(850, 40);
            CbxPhongBan.TabIndex = 38;
            // 
            // CbxTrinhDo
            // 
            CbxTrinhDo.FormattingEnabled = true;
            CbxTrinhDo.Location = new Point(19, 809);
            CbxTrinhDo.Name = "CbxTrinhDo";
            CbxTrinhDo.Size = new Size(850, 40);
            CbxTrinhDo.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(19, 765);
            label14.Name = "label14";
            label14.Size = new Size(123, 32);
            label14.TabIndex = 36;
            label14.Text = "Trình độ: ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label18.Location = new Point(1181, 533);
            label18.Name = "label18";
            label18.Size = new Size(244, 32);
            label18.TabIndex = 34;
            label18.Text = "Trạng thái làm việc: ";
            // 
            // BtnSuaNhanVien
            // 
            BtnSuaNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnSuaNhanVien.Location = new Point(270, 1137);
            BtnSuaNhanVien.Name = "BtnSuaNhanVien";
            BtnSuaNhanVien.Size = new Size(256, 56);
            BtnSuaNhanVien.TabIndex = 32;
            BtnSuaNhanVien.Text = "Sửa mới nhân viên";
            BtnSuaNhanVien.UseVisualStyleBackColor = true;
            BtnSuaNhanVien.Click += BtnSuaNhanVien_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(1181, 646);
            label10.Name = "label10";
            label10.Size = new Size(120, 32);
            label10.TabIndex = 23;
            label10.Text = "Chức vụ: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(19, 646);
            label11.Name = "label11";
            label11.Size = new Size(152, 32);
            label11.TabIndex = 21;
            label11.Text = "Phòng ban: ";
            // 
            // TxtTrangThaiLamVien
            // 
            TxtTrangThaiLamVien.Location = new Point(1181, 577);
            TxtTrangThaiLamVien.Name = "TxtTrangThaiLamVien";
            TxtTrangThaiLamVien.Size = new Size(850, 39);
            TxtTrangThaiLamVien.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(19, 533);
            label13.Name = "label13";
            label13.Size = new Size(192, 32);
            label13.TabIndex = 17;
            label13.Text = "Ngày vào làm:  ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(1181, 410);
            label6.Name = "label6";
            label6.Size = new Size(174, 32);
            label6.TabIndex = 15;
            label6.Text = "CMND_CCCD: ";
            // 
            // TxtCMND_CCCD
            // 
            TxtCMND_CCCD.Location = new Point(1181, 454);
            TxtCMND_CCCD.Name = "TxtCMND_CCCD";
            TxtCMND_CCCD.Size = new Size(850, 39);
            TxtCMND_CCCD.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(19, 410);
            label7.Name = "label7";
            label7.Size = new Size(97, 32);
            label7.TabIndex = 13;
            label7.Text = "Email:  ";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(19, 454);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(850, 39);
            TxtEmail.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(1181, 297);
            label8.Name = "label8";
            label8.Size = new Size(178, 32);
            label8.TabIndex = 11;
            label8.Text = "Số điện thoại: ";
            // 
            // TxtSoDienThoai
            // 
            TxtSoDienThoai.Location = new Point(1181, 341);
            TxtSoDienThoai.Name = "TxtSoDienThoai";
            TxtSoDienThoai.Size = new Size(850, 39);
            TxtSoDienThoai.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(19, 297);
            label9.Name = "label9";
            label9.Size = new Size(106, 32);
            label9.TabIndex = 9;
            label9.Text = "Địa chỉ: ";
            // 
            // TxtDiaChi
            // 
            TxtDiaChi.Location = new Point(19, 341);
            TxtDiaChi.Name = "TxtDiaChi";
            TxtDiaChi.Size = new Size(850, 39);
            TxtDiaChi.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(1181, 163);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 7;
            label4.Text = "Giới tính: ";
            // 
            // TxtGioiTinh
            // 
            TxtGioiTinh.Location = new Point(1181, 207);
            TxtGioiTinh.Name = "TxtGioiTinh";
            TxtGioiTinh.Size = new Size(850, 39);
            TxtGioiTinh.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(19, 163);
            label5.Name = "label5";
            label5.Size = new Size(135, 32);
            label5.TabIndex = 5;
            label5.Text = "Ngày sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(1181, 50);
            label2.Name = "label2";
            label2.Size = new Size(187, 32);
            label2.TabIndex = 3;
            label2.Text = "Tên nhân viên: ";
            // 
            // TxtTenNhanVien
            // 
            TxtTenNhanVien.Location = new Point(1181, 94);
            TxtTenNhanVien.Name = "TxtTenNhanVien";
            TxtTenNhanVien.Size = new Size(850, 39);
            TxtTenNhanVien.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(19, 50);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 1;
            label1.Text = "Mã nhân viên: ";
            // 
            // TxtMaNhanVien
            // 
            TxtMaNhanVien.Location = new Point(19, 94);
            TxtMaNhanVien.Name = "TxtMaNhanVien";
            TxtMaNhanVien.ReadOnly = true;
            TxtMaNhanVien.Size = new Size(850, 39);
            TxtMaNhanVien.TabIndex = 0;
            // 
            // FormSuaNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2062, 1556);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "FormSuaNhanVien";
            Text = "FormSuaNhanVien";
            Load += FormSuaNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox TxtTrangThaiLamVien;
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
        private TextBox TxtGioiTinh;
        private Label label5;
        private Label label2;
        private TextBox TxtTenNhanVien;
        private Label label1;
        private TextBox TxtMaNhanVien;
        private Button BtnQuayLai;
    }
}