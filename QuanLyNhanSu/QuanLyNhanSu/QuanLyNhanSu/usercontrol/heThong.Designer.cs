namespace QuanLyNhanSu.usercontrol
{
    partial class HeThong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {

            panelMain = new Panel();

            lblTitle = new Label();
            lblDescription = new Label();

            panelCards = new TableLayoutPanel();

            panelNhanVien = new Panel();
            lblNhanVienTitle = new Label();
            lblSoNhanVien = new Label();

            panelPhongBan = new Panel();
            lblPhongBanTitle = new Label();
            lblSoPhongBan = new Label();

            panelCongViec = new Panel();
            lblCongViecTitle = new Label();
            lblSoCongViec = new Label();

            panelDatabase = new Panel();
            lblDatabaseTitle = new Label();
            lblTrangThaiDatabase = new Label();

            groupThongTinAdmin = new GroupBox();
            tableAdmin = new TableLayoutPanel();

            lblTenAdminTitle = new Label();
            lblTenAdmin = new Label();

            lblQuyenTitle = new Label();
            lblQuyen = new Label();

            lblUserIDTitle = new Label();
            lblUserID = new Label();

            groupDatabase = new GroupBox();
            tableDatabase = new TableLayoutPanel();

            lblServerTitle = new Label();
            lblServer = new Label();

            lblDatabaseNameTitle = new Label();
            lblDatabaseName = new Label();

            lblConnectionTitle = new Label();
            lblConnection = new Label();

            lblLastCheckTitle = new Label();
            lblLastCheck = new Label();

            panelButtons = new FlowLayoutPanel();

            BtnKiemTraKetNoi = new Button();
            BtnLamMoi = new Button();


            SuspendLayout();

            // =========================================================
            // MAIN PANEL
            // =========================================================

            panelMain.Dock = DockStyle.Fill;

            panelMain.BackColor =
                Color.FromArgb(248, 250, 252);

            panelMain.Padding =
                new Padding(30);

            panelMain.Margin =
                new Padding(0);


            // =========================================================
            // MAIN LAYOUT
            //
            // 0: TITLE
            // 1: DESCRIPTION
            // 2: CARDS
            // 3: INFORMATION
            // 4: BUTTONS
            // 5: SPACE
            // =========================================================

            TableLayoutPanel mainLayout =
                new TableLayoutPanel();

            mainLayout.Dock =
                DockStyle.Fill;

            mainLayout.ColumnCount =
                1;

            mainLayout.RowCount =
                6;

            mainLayout.Margin =
                new Padding(0);

            mainLayout.Padding =
                new Padding(0);

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    100F
                )
            );

            // TITLE
            mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    75F
                )
            );

            // DESCRIPTION
            mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    50F
                )
            );

            // CARDS
            mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    210F
                )
            );

            // INFORMATION
            mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    390F
                )
            );

            // BUTTON
            mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    90F
                )
            );

            // SPACE
            mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F
                )
            );


            // =========================================================
            // TITLE
            // =========================================================

            lblTitle.AutoSize =
                false;

            lblTitle.Dock =
                DockStyle.Fill;

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    24F,
                    FontStyle.Bold
                );

            lblTitle.ForeColor =
                Color.FromArgb(
                    31,
                    41,
                    55
                );

            lblTitle.Margin =
                new Padding(0);

            lblTitle.Name =
                "lblTitle";

            lblTitle.Text =
                "Hệ Thống";

            lblTitle.TextAlign =
                ContentAlignment.MiddleLeft;


            // =========================================================
            // DESCRIPTION
            // =========================================================

            lblDescription.AutoSize =
                false;

            lblDescription.Dock =
                DockStyle.Fill;

            lblDescription.Font =
                new Font(
                    "Segoe UI",
                    10F
                );

            lblDescription.ForeColor =
                Color.FromArgb(
                    107,
                    114,
                    128
                );

            lblDescription.Margin =
                new Padding(2, 0, 0, 10);

            lblDescription.Name =
                "lblDescription";

            lblDescription.Text =
                "Thông tin tổng quan và trạng thái hoạt động của hệ thống quản lý nhân sự";

            lblDescription.TextAlign =
                ContentAlignment.MiddleLeft;


            // =========================================================
            // CARDS LAYOUT
            // =========================================================

            panelCards.ColumnCount =
                4;

            panelCards.RowCount =
                1;

            panelCards.Dock =
                DockStyle.Fill;

            panelCards.Margin =
                new Padding(0, 10, 0, 20);

            panelCards.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    25F
                )
            );

            panelCards.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    25F
                )
            );

            panelCards.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    25F
                )
            );

            panelCards.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    25F
                )
            );

            panelCards.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F
                )
            );


            // =========================================================
            // CARD NHÂN VIÊN
            // =========================================================

            SetupCardPanel(
                panelNhanVien,
                lblNhanVienTitle,
                lblSoNhanVien,
                "Tổng nhân viên",
                Color.FromArgb(37, 99, 235)
            );

            panelNhanVien.Margin =
                new Padding(0, 0, 10, 0);


            // =========================================================
            // CARD PHÒNG BAN
            // =========================================================

            SetupCardPanel(
                panelPhongBan,
                lblPhongBanTitle,
                lblSoPhongBan,
                "Tổng phòng ban",
                Color.FromArgb(22, 163, 74)
            );

            panelPhongBan.Margin =
                new Padding(10, 0, 10, 0);


            // =========================================================
            // CARD CÔNG VIỆC
            // =========================================================

            SetupCardPanel(
                panelCongViec,
                lblCongViecTitle,
                lblSoCongViec,
                "Tổng công việc",
                Color.FromArgb(217, 119, 6)
            );

            panelCongViec.Margin =
                new Padding(10, 0, 10, 0);


            // =========================================================
            // CARD DATABASE
            // =========================================================

            SetupCardPanel(
                panelDatabase,
                lblDatabaseTitle,
                lblTrangThaiDatabase,
                "Database",
                Color.FromArgb(107, 114, 128)
            );

            panelDatabase.Margin =
                new Padding(10, 0, 0, 0);

            lblTrangThaiDatabase.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold
                );

            lblTrangThaiDatabase.Text =
                "Đang kiểm tra...";


            panelCards.Controls.Add(
                panelNhanVien,
                0,
                0
            );

            panelCards.Controls.Add(
                panelPhongBan,
                1,
                0
            );

            panelCards.Controls.Add(
                panelCongViec,
                2,
                0
            );

            panelCards.Controls.Add(
                panelDatabase,
                3,
                0
            );


            // =========================================================
            // INFORMATION LAYOUT
            // =========================================================

            TableLayoutPanel informationLayout =
                new TableLayoutPanel();

            informationLayout.Dock =
                DockStyle.Fill;

            informationLayout.ColumnCount =
                2;

            informationLayout.RowCount =
                1;

            informationLayout.Margin =
                new Padding(0, 15, 0, 15);

            informationLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F
                )
            );

            informationLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F
                )
            );

            informationLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F
                )
            );


            // =========================================================
            // GROUP ADMIN
            // =========================================================

            groupThongTinAdmin.Dock =
                DockStyle.Fill;

            groupThongTinAdmin.Margin =
                new Padding(0, 0, 12, 0);

            groupThongTinAdmin.Padding =
                new Padding(20);

            groupThongTinAdmin.Font =
                new Font(
                    "Segoe UI",
                    10.5F,
                    FontStyle.Bold
                );

            groupThongTinAdmin.ForeColor =
                Color.FromArgb(
                    31,
                    41,
                    55
                );

            groupThongTinAdmin.Text =
                "Thông tin quản trị viên";


            // =========================================================
            // TABLE ADMIN
            // =========================================================

            tableAdmin.ColumnCount =
                2;

            tableAdmin.RowCount =
                3;

            tableAdmin.Dock =
                DockStyle.Fill;

            tableAdmin.Margin =
                new Padding(0);

            tableAdmin.Padding =
                new Padding(25, 25, 25, 20);

            tableAdmin.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    38F
                )
            );

            tableAdmin.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    62F
                )
            );

            tableAdmin.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    33.33F
                )
            );

            tableAdmin.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    33.33F
                )
            );

            tableAdmin.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    33.34F
                )
            );


            SetupInfoLabel(
                lblTenAdminTitle,
                "Tên người dùng:",
                true
            );

            SetupInfoLabel(
                lblTenAdmin,
                "-",
                false
            );

            SetupInfoLabel(
                lblQuyenTitle,
                "Quyền:",
                true
            );

            SetupInfoLabel(
                lblQuyen,
                "-",
                false
            );

            SetupInfoLabel(
                lblUserIDTitle,
                "Mã nhân viên:",
                true
            );

            SetupInfoLabel(
                lblUserID,
                "-",
                false
            );


            tableAdmin.Controls.Add(
                lblTenAdminTitle,
                0,
                0
            );

            tableAdmin.Controls.Add(
                lblTenAdmin,
                1,
                0
            );

            tableAdmin.Controls.Add(
                lblQuyenTitle,
                0,
                1
            );

            tableAdmin.Controls.Add(
                lblQuyen,
                1,
                1
            );

            tableAdmin.Controls.Add(
                lblUserIDTitle,
                0,
                2
            );

            tableAdmin.Controls.Add(
                lblUserID,
                1,
                2
            );

            groupThongTinAdmin.Controls.Add(
                tableAdmin
            );


            // =========================================================
            // DATABASE GROUP
            // =========================================================

            groupDatabase.Dock =
                DockStyle.Fill;

            groupDatabase.Margin =
                new Padding(12, 0, 0, 0);

            groupDatabase.Padding =
                new Padding(20);

            groupDatabase.Font =
                new Font(
                    "Segoe UI",
                    10.5F,
                    FontStyle.Bold
                );

            groupDatabase.ForeColor =
                Color.FromArgb(
                    31,
                    41,
                    55
                );

            groupDatabase.Text =
                "Thông tin cơ sở dữ liệu";


            // =========================================================
            // DATABASE TABLE
            // =========================================================

            tableDatabase.ColumnCount =
                2;

            tableDatabase.RowCount =
                4;

            tableDatabase.Dock =
                DockStyle.Fill;

            tableDatabase.Margin =
                new Padding(0);

            tableDatabase.Padding =
                new Padding(25, 20, 25, 15);

            tableDatabase.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    38F
                )
            );

            tableDatabase.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    62F
                )
            );

            for (int i = 0; i < 4; i++)
            {
                tableDatabase.RowStyles.Add(
                    new RowStyle(
                        SizeType.Percent,
                        25F
                    )
                );
            }


            SetupInfoLabel(
                lblServerTitle,
                "SQL Server:",
                true
            );

            SetupInfoLabel(
                lblServer,
                "-",
                false
            );

            SetupInfoLabel(
                lblDatabaseNameTitle,
                "Database:",
                true
            );

            SetupInfoLabel(
                lblDatabaseName,
                "-",
                false
            );

            SetupInfoLabel(
                lblConnectionTitle,
                "Trạng thái:",
                true
            );

            SetupInfoLabel(
                lblConnection,
                "Chưa kiểm tra",
                false
            );

            SetupInfoLabel(
                lblLastCheckTitle,
                "Kiểm tra lần cuối:",
                true
            );

            SetupInfoLabel(
                lblLastCheck,
                "-",
                false
            );


            tableDatabase.Controls.Add(
                lblServerTitle,
                0,
                0
            );

            tableDatabase.Controls.Add(
                lblServer,
                1,
                0
            );

            tableDatabase.Controls.Add(
                lblDatabaseNameTitle,
                0,
                1
            );

            tableDatabase.Controls.Add(
                lblDatabaseName,
                1,
                1
            );

            tableDatabase.Controls.Add(
                lblConnectionTitle,
                0,
                2
            );

            tableDatabase.Controls.Add(
                lblConnection,
                1,
                2
            );

            tableDatabase.Controls.Add(
                lblLastCheckTitle,
                0,
                3
            );

            tableDatabase.Controls.Add(
                lblLastCheck,
                1,
                3
            );


            groupDatabase.Controls.Add(
                tableDatabase
            );


            informationLayout.Controls.Add(
                groupThongTinAdmin,
                0,
                0
            );

            informationLayout.Controls.Add(
                groupDatabase,
                1,
                0
            );


            // =========================================================
            // BUTTON PANEL
            // =========================================================

            panelButtons.Dock =
                DockStyle.Fill;

            panelButtons.Margin =
                new Padding(0);

            panelButtons.Padding =
                new Padding(0, 12, 0, 0);

            panelButtons.FlowDirection =
                FlowDirection.LeftToRight;

            panelButtons.WrapContents =
                false;


            // =========================================================
            // KIỂM TRA KẾT NỐI
            // =========================================================

            BtnKiemTraKetNoi.BackColor =
                Color.FromArgb(
                    37,
                    99,
                    235
                );

            BtnKiemTraKetNoi.FlatAppearance.BorderSize =
                0;

            BtnKiemTraKetNoi.FlatStyle =
                FlatStyle.Flat;

            BtnKiemTraKetNoi.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold
                );

            BtnKiemTraKetNoi.ForeColor =
                Color.White;

            BtnKiemTraKetNoi.Margin =
                new Padding(0, 0, 15, 0);

            BtnKiemTraKetNoi.Name =
                "BtnKiemTraKetNoi";

            BtnKiemTraKetNoi.Size =
                new Size(220, 52);

            BtnKiemTraKetNoi.Text =
                "Kiểm tra kết nối";

            BtnKiemTraKetNoi.UseVisualStyleBackColor =
                false;

            BtnKiemTraKetNoi.Click +=
                BtnKiemTraKetNoi_Click;


            // =========================================================
            // LÀM MỚI
            // =========================================================

            BtnLamMoi.BackColor =
                Color.White;

            BtnLamMoi.FlatAppearance.BorderColor =
                Color.FromArgb(
                    209,
                    213,
                    219
                );

            BtnLamMoi.FlatAppearance.BorderSize =
                1;

            BtnLamMoi.FlatStyle =
                FlatStyle.Flat;

            BtnLamMoi.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold
                );

            BtnLamMoi.ForeColor =
                Color.FromArgb(
                    31,
                    41,
                    55
                );

            BtnLamMoi.Margin =
                new Padding(0);

            BtnLamMoi.Name =
                "BtnLamMoi";

            BtnLamMoi.Size =
                new Size(150, 52);

            BtnLamMoi.Text =
                "Làm mới";

            BtnLamMoi.UseVisualStyleBackColor =
                false;

            BtnLamMoi.Click +=
                BtnLamMoi_Click;


            panelButtons.Controls.Add(
                BtnKiemTraKetNoi
            );

            panelButtons.Controls.Add(
                BtnLamMoi
            );


            // =========================================================
            // ADD MAIN LAYOUT
            // =========================================================

            mainLayout.Controls.Add(
                lblTitle,
                0,
                0
            );

            mainLayout.Controls.Add(
                lblDescription,
                0,
                1
            );

            mainLayout.Controls.Add(
                panelCards,
                0,
                2
            );

            mainLayout.Controls.Add(
                informationLayout,
                0,
                3
            );

            mainLayout.Controls.Add(
                panelButtons,
                0,
                4
            );


            panelMain.Controls.Add(
                mainLayout
            );


            // =========================================================
            // HE THONG USERCONTROL
            // =========================================================

            AutoScaleMode =
                AutoScaleMode.None;

            BackColor =
                Color.FromArgb(
                    248,
                    250,
                    252
                );

            Controls.Add(
                panelMain
            );

            Margin =
                new Padding(0);

            Name =
                "HeThong";

            Size =
                new Size(
                    2088,
                    1627
                );

            Load +=
                HeThong_Load;


            ResumeLayout(false);
        }
        private void SetupCardPanel(
    Panel panel,
    Label title,
    Label value,
    string titleText,
    Color valueColor)
        {
            panel.BackColor =
                Color.White;

            panel.BorderStyle =
                BorderStyle.FixedSingle;

            panel.Dock =
                DockStyle.Fill;


            TableLayoutPanel layout =
                new TableLayoutPanel();

            layout.Dock =
                DockStyle.Fill;

            layout.ColumnCount =
                1;

            layout.RowCount =
                2;

            layout.Padding =
                new Padding(25, 20, 20, 15);

            layout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    100F
                )
            );

            layout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    45F
                )
            );

            layout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    55F
                )
            );


            title.AutoSize =
                false;

            title.Dock =
                DockStyle.Fill;

            title.Font =
                new Font(
                    "Segoe UI",
                    10.5F,
                    FontStyle.Bold
                );

            title.ForeColor =
                Color.FromArgb(
                    107,
                    114,
                    128
                );

            title.Text =
                titleText;

            title.TextAlign =
                ContentAlignment.MiddleLeft;


            value.AutoSize =
                false;

            value.Dock =
                DockStyle.Fill;

            value.Font =
                new Font(
                    "Segoe UI",
                    25F,
                    FontStyle.Bold
                );

            value.ForeColor =
                valueColor;

            value.Text =
                "0";

            value.TextAlign =
                ContentAlignment.MiddleLeft;


            layout.Controls.Add(
                title,
                0,
                0
            );

            layout.Controls.Add(
                value,
                0,
                1
            );


            panel.Controls.Add(
                layout
            );
        }

        private void SetupInfoLabel(
    Label label,
    string text,
    bool bold)
        {
            label.AutoSize =
                false;

            label.Dock =
                DockStyle.Fill;

            label.Margin =
                new Padding(5);

            label.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    bold
                        ? FontStyle.Bold
                        : FontStyle.Regular
                );

            label.ForeColor =
                bold
                    ? Color.FromArgb(55, 65, 81)
                    : Color.FromArgb(31, 41, 55);

            label.Text =
                text;

            label.TextAlign =
                ContentAlignment.MiddleLeft;
        }
        #endregion


        private Panel panelMain;

        private Label lblTitle;
        private Label lblDescription;

        private TableLayoutPanel panelCards;

        private Panel panelNhanVien;
        private Label lblNhanVienTitle;
        private Label lblSoNhanVien;

        private Panel panelPhongBan;
        private Label lblPhongBanTitle;
        private Label lblSoPhongBan;

        private Panel panelCongViec;
        private Label lblCongViecTitle;
        private Label lblSoCongViec;

        private Panel panelDatabase;
        private Label lblDatabaseTitle;
        private Label lblTrangThaiDatabase;

        private GroupBox groupThongTinAdmin;
        private TableLayoutPanel tableAdmin;

        private Label lblTenAdminTitle;
        private Label lblTenAdmin;

        private Label lblQuyenTitle;
        private Label lblQuyen;

        private Label lblUserIDTitle;
        private Label lblUserID;

        private GroupBox groupDatabase;
        private TableLayoutPanel tableDatabase;

        private Label lblServerTitle;
        private Label lblServer;

        private Label lblDatabaseNameTitle;
        private Label lblDatabaseName;

        private Label lblConnectionTitle;
        private Label lblConnection;

        private Label lblLastCheckTitle;
        private Label lblLastCheck;

        private FlowLayoutPanel panelButtons;

        private Button BtnKiemTraKetNoi;
        private Button BtnLamMoi;
    }
}