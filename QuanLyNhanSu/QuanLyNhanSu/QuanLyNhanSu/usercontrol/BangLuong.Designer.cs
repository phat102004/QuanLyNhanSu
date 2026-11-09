namespace QuanLyNhanSu.usercontrol
{
    partial class BangLuong
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
            DgvLuong = new DataGridView();
            MaLuongTong = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            SoNgayCong = new DataGridViewTextBoxColumn();
            TongPhuCap = new DataGridViewTextBoxColumn();
            TongLuong = new DataGridViewTextBoxColumn();
            NgayTinhLuong = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            TxtTimKiem = new TextBox();
            CbxPhongBan = new ComboBox();
            BtnLamMoi = new Button();
            BtnTimKiem = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            DtpNgayLuong = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvLuong).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            //
            // DgvLuong
            //
            DgvLuong.AllowUserToAddRows = false;
            DgvLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvLuong.Columns.AddRange(new DataGridViewColumn[] { MaLuongTong, HoTen, SoNgayCong, TongPhuCap, TongLuong, NgayTinhLuong, NgayLap });
            DgvLuong.Dock = DockStyle.Bottom;
            DgvLuong.Location = new Point(0, 445);
            DgvLuong.Name = "DgvLuong";
            DgvLuong.RowHeadersVisible = false;
            DgvLuong.RowHeadersWidth = 82;
            DgvLuong.Size = new Size(2088, 1182);
            DgvLuong.TabIndex = 11;
            //
            // MaLuongTong
            //
            MaLuongTong.DataPropertyName = "MaLuongTong";
            MaLuongTong.HeaderText = "Mã Lương";
            MaLuongTong.MinimumWidth = 10;
            MaLuongTong.Name = "MaLuongTong";
            //
            // HoTen
            //
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 10;
            HoTen.Name = "HoTen";
            //
            // SoNgayCong
            //
            SoNgayCong.DataPropertyName = "SoNgayCong";
            SoNgayCong.HeaderText = "Sô ngày công";
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
            // NgayTinhLuong
            //
            NgayTinhLuong.DataPropertyName = "NgayTinhLuong";
            NgayTinhLuong.HeaderText = "Ngày Tính Lương";
            NgayTinhLuong.MinimumWidth = 10;
            NgayTinhLuong.Name = "NgayTinhLuong";
            //
            // NgayLap
            //
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 10;
            NgayLap.Name = "NgayLap";
            //
            // groupBox1
            //
            groupBox1.Controls.Add(TxtTimKiem);
            groupBox1.Controls.Add(CbxPhongBan);
            groupBox1.Controls.Add(BtnLamMoi);
            groupBox1.Controls.Add(BtnTimKiem);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DtpNgayLuong);
            groupBox1.Location = new Point(16, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2020, 548);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            //
            // TxtTimKiem
            //
            TxtTimKiem.Location = new Point(408, 171);
            TxtTimKiem.Name = "TxtTimKiem";
            TxtTimKiem.Size = new Size(400, 39);
            TxtTimKiem.TabIndex = 36;
            TxtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            //
            // CbxPhongBan
            //
            CbxPhongBan.FormattingEnabled = true;
            CbxPhongBan.Location = new Point(1021, 86);
            CbxPhongBan.Name = "CbxPhongBan";
            CbxPhongBan.Size = new Size(385, 40);
            CbxPhongBan.TabIndex = 35;
            //
            // BtnLamMoi
            //
            BtnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnLamMoi.Location = new Point(1150, 162);
            BtnLamMoi.Name = "BtnLamMoi";
            BtnLamMoi.Size = new Size(256, 56);
            BtnLamMoi.TabIndex = 33;
            BtnLamMoi.Text = "Làm mới";
            BtnLamMoi.UseVisualStyleBackColor = true;
            BtnLamMoi.Click += BtnLamMoi_Click;
            //
            // BtnTimKiem
            //
            BtnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTimKiem.Location = new Point(870, 162);
            BtnTimKiem.Name = "BtnTimKiem";
            BtnTimKiem.Size = new Size(256, 56);
            BtnTimKiem.TabIndex = 33;
            BtnTimKiem.Text = "Tìm kiếm";
            BtnTimKiem.UseVisualStyleBackColor = true;
            BtnTimKiem.Click += BtnTimKiem_Click;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(870, 89);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 7;
            label1.Text = "Phòng ban:";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(246, 174);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 7;
            label2.Text = "Tìm kiếm: ";
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(246, 84);
            label4.Name = "label4";
            label4.Size = new Size(156, 32);
            label4.TabIndex = 7;
            label4.Text = "Ngày lương:";
            //
            // DtpNgayLuong
            //
            DtpNgayLuong.CustomFormat = "MM/yyyy\r\n";
            DtpNgayLuong.Format = DateTimePickerFormat.Custom;
            DtpNgayLuong.Location = new Point(408, 84);
            DtpNgayLuong.Name = "DtpNgayLuong";
            DtpNgayLuong.ShowUpDown = true;
            DtpNgayLuong.Size = new Size(400, 39);
            DtpNgayLuong.TabIndex = 34;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 6);
            label3.Name = "label3";
            label3.Size = new Size(195, 45);
            label3.TabIndex = 10;
            label3.Text = "Bảng lương";
            //
            // BangLuong
            //
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DgvLuong);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "BangLuong";
            Size = new Size(2088, 1627);
            ((System.ComponentModel.ISupportInitialize)DgvLuong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvLuong;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private DateTimePicker DtpNgayLuong;
        private TextBox TxtTimKiem;
        private ComboBox CbxPhongBan;
        private Button BtnLamMoi;
        private Button BtnTimKiem;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn MaLuongTong;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn SoNgayCong;
        private DataGridViewTextBoxColumn TongPhuCap;
        private DataGridViewTextBoxColumn TongLuong;
        private DataGridViewTextBoxColumn NgayTinhLuong;
        private DataGridViewTextBoxColumn NgayLap;
    }
}
