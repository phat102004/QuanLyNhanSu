
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    partial class CongViecCaNhan
    {
        private System.ComponentModel.IContainer? components = null;

        private TableLayoutPanel mainLayout = null!;
        private TableLayoutPanel statsLayout = null!;

        private Panel pnlHeader = null!;
        private Panel pnlActions = null!;

        private DataGridView DgvCongViec = null!;

        private Label LblTongCongViec = null!;
        private Label LblChuaHoanThanh = null!;
        private Label LblDaHoanThanh = null!;
        private Label LblHuongDan = null!;

        private Button BtnHoanThanh = null!;
        private Button BtnLamMoi = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Color navy = Color.FromArgb(25, 48, 80);
            Color background = Color.FromArgb(245, 247, 251);
            Color muted = Color.FromArgb(100, 116, 139);

            SuspendLayout();

            // ==================================
            // USER CONTROL
            // ==================================
            Name = "CongViecCaNhan";
            Size = new Size(2088, 1627);

            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 10F);
            BackColor = background;

            // ==================================
            // MAIN LAYOUT
            // ==================================
            mainLayout = new TableLayoutPanel
            {
                Name = "mainLayout",
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(26),
                BackColor = background
            };

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F)
            );

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 105F)
            );

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 175F)
            );

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 100F)
            );

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F)
            );

            // ==================================
            // HEADER
            // ==================================
            pnlHeader = new Panel
            {
                Name = "pnlHeader",
                Dock = DockStyle.Fill,
                BackColor = background
            };

            Label title = new Label
            {
                Text = "CÔNG VIỆC CỦA TÔI",
                Dock = DockStyle.Top,
                Height = 58,

                Font = new Font(
                    "Segoe UI",
                    21F,
                    FontStyle.Bold
                ),

                ForeColor = navy,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label subtitle = new Label
            {
                Text =
                    "Theo dõi tiến độ và xác nhận công việc được giao",

                Dock = DockStyle.Fill,
                ForeColor = muted,

                TextAlign =
                    ContentAlignment.MiddleLeft
            };

            pnlHeader.Controls.Add(subtitle);
            pnlHeader.Controls.Add(title);

            // ==================================
            // THREE STATISTIC CARDS
            // ==================================
            statsLayout = new TableLayoutPanel
            {
                Name = "statsLayout",
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 1,
                BackColor = background,

                Padding = new Padding(0, 6, 0, 12)
            };

            for (int i = 0; i < 3; i++)
            {
                statsLayout.ColumnStyles.Add(
                    new ColumnStyle(
                        SizeType.Percent,
                        100F / 3
                    )
                );
            }

            statsLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F)
            );

            LblTongCongViec = new Label
            {
                Name = "LblTongCongViec"
            };

            LblChuaHoanThanh = new Label
            {
                Name = "LblChuaHoanThanh"
            };

            LblDaHoanThanh = new Label
            {
                Name = "LblDaHoanThanh"
            };

            statsLayout.Controls.Add(
                CreateStatCard(
                    "TẤT CẢ CÔNG VIỆC",
                    LblTongCongViec,
                    navy
                ),
                0, 0
            );

            statsLayout.Controls.Add(
                CreateStatCard(
                    "CHƯA HOÀN THÀNH",
                    LblChuaHoanThanh,
                    Color.FromArgb(161, 98, 7)
                ),
                1, 0
            );

            statsLayout.Controls.Add(
                CreateStatCard(
                    "ĐÃ HOÀN THÀNH",
                    LblDaHoanThanh,
                    Color.FromArgb(22, 101, 52)
                ),
                2, 0
            );

            // ==================================
            // ACTION PANEL
            // ==================================
            pnlActions = new Panel
            {
                Name = "pnlActions",
                Dock = DockStyle.Fill,

                BackColor = Color.White,

                Margin = new Padding(6, 0, 6, 12),
                Padding = new Padding(20, 12, 20, 12),

                BorderStyle = BorderStyle.FixedSingle
            };

            BtnLamMoi = new Button
            {
                Name = "BtnLamMoi",
                Text = "Làm mới",

                Dock = DockStyle.Right,
                Width = 150,

                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = navy
            };

            BtnLamMoi.FlatAppearance.BorderColor =
                Color.FromArgb(203, 213, 225);

            BtnHoanThanh = new Button
            {
                Name = "BtnHoanThanh",
                Text = "✓ Hoàn thành",

                Dock = DockStyle.Right,
                Width = 200,

                Margin = new Padding(6),
                Visible = false,

                FlatStyle = FlatStyle.Flat,

                BackColor = navy,
                ForeColor = Color.White,

                Font = new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold
                )
            };

            BtnHoanThanh.FlatAppearance.BorderSize = 0;

            LblHuongDan = new Label
            {
                Name = "LblHuongDan",

                Text =
                    "Chọn công việc chưa hoàn thành để xác nhận.",

                Dock = DockStyle.Fill,

                ForeColor = muted,

                TextAlign =
                    ContentAlignment.MiddleLeft,

                AutoEllipsis = true
            };

            pnlActions.Controls.Add(LblHuongDan);
            pnlActions.Controls.Add(BtnLamMoi);
            pnlActions.Controls.Add(BtnHoanThanh);

            // ==================================
            // DATAGRIDVIEW
            // ==================================
            DgvCongViec = new DataGridView
            {
                Name = "DgvCongViec",

                Dock = DockStyle.Fill,
                Margin = new Padding(6, 0, 6, 0),

                BackgroundColor = Color.White,

                BorderStyle =
                    BorderStyle.FixedSingle,

                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,

                MultiSelect = false,
                ReadOnly = true,

                RowHeadersVisible = false,
                AutoGenerateColumns = true,

                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,

                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,

                CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal,

                EnableHeadersVisualStyles = false,

                ColumnHeadersHeight = 55,

                ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode
                        .DisableResizing
            };

            DgvCongViec.RowTemplate.Height = 45;

            // HEADER STYLE
            DgvCongViec.ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = navy,
                    ForeColor = Color.White,

                    SelectionBackColor = navy,
                    SelectionForeColor = Color.White,

                    Font = new Font(
                        "Segoe UI",
                        10F,
                        FontStyle.Bold
                    ),

                    Alignment =
                        DataGridViewContentAlignment.MiddleLeft
                };

            // ROW STYLE
            DgvCongViec.DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    ForeColor =
                        Color.FromArgb(35, 50, 70),

                    SelectionBackColor =
                        Color.FromArgb(220, 235, 250),

                    SelectionForeColor = navy,

                    Font = new Font("Segoe UI", 10F)
                };

            // ==================================
            // ASSEMBLE
            // ==================================
            mainLayout.Controls.Add(pnlHeader, 0, 0);
            mainLayout.Controls.Add(statsLayout, 0, 1);
            mainLayout.Controls.Add(pnlActions, 0, 2);
            mainLayout.Controls.Add(DgvCongViec, 0, 3);

            Controls.Add(mainLayout);

            ResumeLayout(false);
        }

        // ==================================
        // HELPER: CREATE STATISTIC CARD
        // ==================================
        private static Panel CreateStatCard(
            string caption,
            Label valueLabel,
            Color valueColor)
        {
            Panel card = new Panel
            {
                Dock = DockStyle.Fill,

                Margin = new Padding(6),
                Padding = new Padding(20, 12, 20, 12),

                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            valueLabel.Dock = DockStyle.Fill;

            valueLabel.Text = "0";

            valueLabel.Font = new Font(
                "Segoe UI",
                26F,
                FontStyle.Bold
            );

            valueLabel.ForeColor = valueColor;

            valueLabel.TextAlign =
                ContentAlignment.MiddleLeft;

            Label label = new Label
            {
                Text = caption,

                Dock = DockStyle.Top,
                Height = 38,

                Font = new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold
                ),

                ForeColor =
                    Color.FromArgb(100, 116, 139),

                TextAlign =
                    ContentAlignment.MiddleLeft
            };

            card.Controls.Add(valueLabel);
            card.Controls.Add(label);

            return card;
        }
    }
}
