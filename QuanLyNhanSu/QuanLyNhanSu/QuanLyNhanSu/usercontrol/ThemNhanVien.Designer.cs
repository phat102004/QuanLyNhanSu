namespace QuanLyNhanSu.usercontrol
{
    partial class ThemNhanVien
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
            components = new System.ComponentModel.Container();

            // Khởi tạo lại toàn bộ control có sẵn
            groupBox1 = new GroupBox();

            DtpNgayVaoLam = new DateTimePicker();
            DtpNgaySinh = new DateTimePicker();

            CbxChucVu = new ComboBox();
            CbxPhongBan = new ComboBox();
            CbxTrinhDo = new ComboBox();
            CbxTrangThaiLamViec = new ComboBox();
            CbxGioiTinh = new ComboBox();

            TxtCMND_CCCD = new TextBox();
            TxtEmail = new TextBox();
            TxtSoDienThoai = new TextBox();
            TxtDiaChi = new TextBox();
            TxtTenNhanVien = new TextBox();
            TxtMaNhanVien = new TextBox();

            BtnThemNhanVien = new Button();

            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label18 = new Label();

            contextMenuStrip1 =
                new ContextMenuStrip(components);

            Color navy = Color.FromArgb(25, 48, 80);
            Color blue = Color.FromArgb(35, 91, 155);
            Color background = Color.FromArgb(245, 247, 251);

            SuspendLayout();

            // =========================================
            // USERCONTROL
            // =========================================
            Name = "ThemNhanVien";
            Size = new Size(2088, 1627);
            BackColor = background;
            AutoScaleMode = AutoScaleMode.None;
            Font = new Font("Segoe UI", 11F);

            // =========================================
            // LAYOUT TỔNG THỂ
            // =========================================
            TableLayoutPanel mainLayout =
                new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 1,
                    RowCount = 2,
                    Padding = new Padding(28),
                    BackColor = background
                };

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 115F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            // =========================================
            // HEADER
            // =========================================
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = background
            };

            label3.Text = "THÊM NHÂN VIÊN MỚI";
            label3.Font = new Font(
                "Segoe UI", 22F, FontStyle.Bold);

            label3.ForeColor = navy;
            label3.Dock = DockStyle.Top;
            label3.Height = 76;
            label3.TextAlign =
                ContentAlignment.MiddleLeft;

            Label subtitle = new Label
            {
                Text = "Nhập thông tin để tạo hồ sơ nhân viên",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.DimGray,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            headerPanel.Controls.Add(subtitle);
            headerPanel.Controls.Add(label3);

            // =========================================
            // GROUPBOX
            // =========================================
            groupBox1.Text = "Thông tin nhân viên";
            groupBox1.Name = "groupBox1";
            groupBox1.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);

            groupBox1.ForeColor = navy;
            groupBox1.Dock = DockStyle.Fill;

            groupBox1.Margin =
                new Padding(0, 4, 0, 0);

            groupBox1.Padding =
                new Padding(22, 54, 22, 24);

            groupBox1.BackColor = Color.White;

            // =========================================
            // FORM 2 CỘT, 7 HÀNG
            // =========================================
            TableLayoutPanel fieldsLayout =
                new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 2,
                    RowCount = 7,
                    BackColor = Color.White,
                    Margin = new Padding(0),
                    Padding = new Padding(8)
                };

            fieldsLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 50F));

            fieldsLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 50F));

            for (int i = 0; i < 7; i++)
            {
                fieldsLayout.RowStyles.Add(
                    new RowStyle(
                        SizeType.Percent,
                        100F / 7F
                    )
                );
            }

            // =========================================
            // CẤU HÌNH CÁC CONTROL
            // =========================================
            TextBox[] textBoxes =
            {
        TxtMaNhanVien,
        TxtTenNhanVien,
        TxtDiaChi,
        TxtSoDienThoai,
        TxtEmail,
        TxtCMND_CCCD
    };

            foreach (TextBox txt in textBoxes)
            {
                txt.Font = new Font("Segoe UI", 12F);
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = Color.FromArgb(250, 252, 255);
            }

            ComboBox[] comboBoxes =
            {
        CbxGioiTinh,
        CbxTrangThaiLamViec,
        CbxPhongBan,
        CbxChucVu,
        CbxTrinhDo
    };

            foreach (ComboBox cbx in comboBoxes)
            {
                cbx.Font = new Font("Segoe UI", 12F);
                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
                cbx.FlatStyle = FlatStyle.Flat;
                cbx.BackColor = Color.FromArgb(250, 252, 255);
            }

            CbxGioiTinh.Items.AddRange(
                new object[] { "Nam", "Nữ" });

            CbxTrangThaiLamViec.Items.AddRange(
                new object[]
                {
            "Đang làm việc",
            "Thử việc",
            "Tạm nghỉ",
            "Nghỉ việc"
                });

            DtpNgaySinh.Format =
                DateTimePickerFormat.Custom;

            DtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            DtpNgaySinh.Font =
                new Font("Segoe UI", 12F);

            DtpNgayVaoLam.Format =
                DateTimePickerFormat.Custom;

            DtpNgayVaoLam.CustomFormat = "dd/MM/yyyy";
            DtpNgayVaoLam.Font =
                new Font("Segoe UI", 12F);

            // =========================================
            // HÀNG 1: MÃ / TÊN
            // =========================================
            AddField(
                fieldsLayout,
                label1,
                "Mã nhân viên",
                TxtMaNhanVien,
                0, 0
            );

            AddField(
                fieldsLayout,
                label2,
                "Họ và tên",
                TxtTenNhanVien,
                1, 0
            );

            // =========================================
            // HÀNG 2: NGÀY SINH / GIỚI TÍNH
            // =========================================
            AddField(
                fieldsLayout,
                label5,
                "Ngày sinh",
                DtpNgaySinh,
                0, 1
            );

            AddField(
                fieldsLayout,
                label4,
                "Giới tính",
                CbxGioiTinh,
                1, 1
            );

            // =========================================
            // HÀNG 3: ĐỊA CHỈ / ĐIỆN THOẠI
            // =========================================
            AddField(
                fieldsLayout,
                label9,
                "Địa chỉ",
                TxtDiaChi,
                0, 2
            );

            AddField(
                fieldsLayout,
                label8,
                "Số điện thoại",
                TxtSoDienThoai,
                1, 2
            );

            // =========================================
            // HÀNG 4: EMAIL / CCCD
            // =========================================
            AddField(
                fieldsLayout,
                label7,
                "Email",
                TxtEmail,
                0, 3
            );

            AddField(
                fieldsLayout,
                label6,
                "CMND / CCCD",
                TxtCMND_CCCD,
                1, 3
            );

            // =========================================
            // HÀNG 5: NGÀY VÀO / TRẠNG THÁI
            // =========================================
            AddField(
                fieldsLayout,
                label13,
                "Ngày vào làm",
                DtpNgayVaoLam,
                0, 4
            );

            AddField(
                fieldsLayout,
                label18,
                "Trạng thái làm việc",
                CbxTrangThaiLamViec,
                1, 4
            );

            // =========================================
            // HÀNG 6: PHÒNG BAN / CHỨC VỤ
            // =========================================
            AddField(
                fieldsLayout,
                label11,
                "Phòng ban",
                CbxPhongBan,
                0, 5
            );

            AddField(
                fieldsLayout,
                label10,
                "Chức vụ",
                CbxChucVu,
                1, 5
            );

            // =========================================
            // HÀNG 7: TRÌNH ĐỘ / NÚT THÊM
            // =========================================
            AddField(
                fieldsLayout,
                label14,
                "Trình độ",
                CbxTrinhDo,
                0, 6
            );

            Panel buttonContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20, 60, 20, 20)
            };

            BtnThemNhanVien.Name = "BtnThemNhanVien";
            BtnThemNhanVien.Text = "＋  THÊM NHÂN VIÊN";

            BtnThemNhanVien.Dock = DockStyle.Top;
            BtnThemNhanVien.Height = 72;

            BtnThemNhanVien.BackColor = blue;
            BtnThemNhanVien.ForeColor = Color.White;

            BtnThemNhanVien.FlatStyle = FlatStyle.Flat;
            BtnThemNhanVien.FlatAppearance.BorderSize = 0;

            BtnThemNhanVien.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);

            BtnThemNhanVien.Cursor = Cursors.Hand;

            BtnThemNhanVien.Click += BtnThemNhanVien_Click;

            buttonContainer.Controls.Add(BtnThemNhanVien);

            fieldsLayout.Controls.Add(
                buttonContainer, 1, 6);

            // =========================================
            // HOÀN THÀNH BỐ CỤC
            // =========================================
            groupBox1.Controls.Add(fieldsLayout);

            mainLayout.Controls.Add(headerPanel, 0, 0);
            mainLayout.Controls.Add(groupBox1, 0, 1);

            Controls.Add(mainLayout);

            contextMenuStrip1.ImageScalingSize =
                new Size(32, 32);

            // Giữ sự kiện Load cũ
            Load += ThemNhanVien_Load;

            ResumeLayout(false);
        }

        // =============================================
        // HÀM HỖ TRỢ THÊM Ô THÔNG TIN
        // Đặt bên ngoài InitializeComponent()
        // nhưng vẫn nằm trong class ThemNhanVien
        // =============================================
        private void AddField(
            TableLayoutPanel parent,
            Label label,
            string labelText,
            Control input,
            int column,
            int row)
        {
            Panel fieldPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(8),
                Padding = new Padding(16, 14, 16, 8),
                BackColor = Color.White
            };

            TableLayoutPanel fieldLayout =
                new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 1,
                    RowCount = 2,
                    Margin = new Padding(0)
                };

            fieldLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            fieldLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 48F));

            fieldLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 65F));

            label.Text = labelText;
            label.Dock = DockStyle.Fill;
            label.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            label.ForeColor =
                Color.FromArgb(55, 65, 81);

            label.TextAlign = ContentAlignment.MiddleLeft;

            input.Dock = DockStyle.Fill;
            input.Margin = new Padding(0, 4, 0, 4);

            fieldLayout.Controls.Add(label, 0, 0);
            fieldLayout.Controls.Add(input, 0, 1);

            fieldPanel.Controls.Add(fieldLayout);
            parent.Controls.Add(fieldPanel, column, row);
        }


        #endregion

        private GroupBox groupBox1;
        private TextBox TxtMaNhanVien;
        private Label label2;
        private TextBox TxtTenNhanVien;
        private Label label1;
        private Button BtnThemNhanVien;
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
        private Label label3;
        private Label label18;
        private ComboBox CbxChucVu;
        private ComboBox CbxPhongBan;
        private ComboBox CbxTrinhDo;
        private Label label14;
        private ContextMenuStrip contextMenuStrip1;
        private DateTimePicker DtpNgaySinh;
        private DateTimePicker DtpNgayVaoLam;
    }
}
