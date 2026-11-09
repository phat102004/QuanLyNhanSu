
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    partial class LuongCaNhan
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel statsLayout;

        private Panel pnlHeader;
        private Panel pnlSalary;
        private Panel pnlNgayCong;
        private Panel pnlPhuCap;
        private Panel pnlLichSu;

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblTongLuongTitle;
        private Label lblNgayCongTitle;
        private Label lblPhuCapTitle;
        private Label lblLichSuTitle;

        private Label LblTongLuong;
        private Label LblNgayCong;
        private Label LblPhuCap;
        private Label LblKyLuong;

        private DataGridView DgvLichSuLuong;

        private readonly Color navy =
            Color.FromArgb(25, 48, 80);

        private readonly Color muted =
            Color.FromArgb(100, 116, 139);

        private readonly Color bg =
            Color.FromArgb(245, 247, 251);

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            SuspendLayout();

            // ============================
            // USER CONTROL
            // ============================

            Name = "LuongCaNhan";
            Size = new Size(2088, 1627);

            AutoScaleMode = AutoScaleMode.Font;
            BackColor = bg;
            Font = new Font("Segoe UI", 10F);

            // ============================
            // MAIN LAYOUT
            // ============================

            mainLayout = new TableLayoutPanel
            {
                Name = "mainLayout",
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(28),
                BackColor = bg
            };

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent, 100F)
            );

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 110F)
            );

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 215F)
            );

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 180F)
            );

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F)
            );

            // ============================
            // HEADER
            // ============================

            pnlHeader = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = bg,
                Padding = new Padding(8)
            };

            lblTitle = new Label
            {
                Text = "LƯƠNG CỦA TÔI",
                Font = new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold
                ),
                ForeColor = navy,
                AutoSize = true,
                Location = new Point(8, 6)
            };

            lblSubtitle = new Label
            {
                Text = "Tổng quan thu nhập và lịch sử lương",
                Font = new Font("Segoe UI", 10F),
                ForeColor = muted,
                AutoSize = true,
                Location = new Point(10, 64)
            };

            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);

            // ============================
            // SALARY CARD
            // ============================

            pnlSalary = CreateCard();

            pnlSalary.BackColor =
                Color.FromArgb(29, 64, 105);

            TableLayoutPanel salaryLayout =
                new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 1,
                    RowCount = 3,
                    BackColor = Color.Transparent,
                    Padding = new Padding(24, 14, 24, 14)
                };

            salaryLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 30F));

            salaryLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 45F));

            salaryLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));

            salaryLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            lblTongLuongTitle = new Label
            {
                Text = "TỔNG LƯƠNG KỲ GẦN NHẤT",
                Dock = DockStyle.Fill,
                Font = new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold
                ),
                ForeColor =
                    Color.FromArgb(205, 225, 245),
                TextAlign = ContentAlignment.MiddleLeft
            };

            LblTongLuong = new Label
            {
                Name = "LblTongLuong",
                Text = "0 VNĐ",
                Dock = DockStyle.Fill,
                Font = new Font(
                    "Segoe UI",
                    28F,
                    FontStyle.Bold
                ),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            LblKyLuong = new Label
            {
                Name = "LblKyLuong",
                Text = "Chưa có kỳ lương",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F),
                ForeColor =
                    Color.FromArgb(220, 235, 250),
                TextAlign = ContentAlignment.MiddleLeft
            };

            salaryLayout.Controls.Add(
                lblTongLuongTitle, 0, 0);

            salaryLayout.Controls.Add(
                LblTongLuong, 0, 1);

            salaryLayout.Controls.Add(
                LblKyLuong, 0, 2);

            pnlSalary.Controls.Add(salaryLayout);

            // ============================
            // STATS CARDS
            // ============================

            statsLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(0, 12, 0, 12),
                BackColor = bg
            };

            statsLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent, 50F)
            );

            statsLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent, 50F)
            );

            statsLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent, 100F)
            );

            pnlNgayCong = CreateCard();
            pnlPhuCap = CreateCard();

            lblNgayCongTitle = new Label
            {
                Text = "SỐ NGÀY CÔNG",
                Dock = DockStyle.Top,
                Height = 40,
                Font = new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold
                ),
                ForeColor = muted,
                TextAlign = ContentAlignment.MiddleLeft
            };

            LblNgayCong = new Label
            {
                Name = "LblNgayCong",
                Text = "0 ngày",
                Dock = DockStyle.Fill,
                Font = new Font(
                    "Segoe UI",
                    20F,
                    FontStyle.Bold
                ),
                ForeColor = navy,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            lblPhuCapTitle = new Label
            {
                Text = "TỔNG PHỤ CẤP",
                Dock = DockStyle.Top,
                Height = 40,
                Font = new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold
                ),
                ForeColor = muted,
                TextAlign = ContentAlignment.MiddleLeft
            };

            LblPhuCap = new Label
            {
                Name = "LblPhuCap",
                Text = "0 VNĐ",
                Dock = DockStyle.Fill,
                Font = new Font(
                    "Segoe UI",
                    20F,
                    FontStyle.Bold
                ),
                ForeColor = navy,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            pnlNgayCong.Controls.Add(LblNgayCong);
            pnlNgayCong.Controls.Add(lblNgayCongTitle);

            pnlPhuCap.Controls.Add(LblPhuCap);
            pnlPhuCap.Controls.Add(lblPhuCapTitle);

            statsLayout.Controls.Add(pnlNgayCong, 0, 0);
            statsLayout.Controls.Add(pnlPhuCap, 1, 0);

            // ============================
            // SALARY HISTORY
            // ============================

            pnlLichSu = CreateCard();
            pnlLichSu.Padding =
                new Padding(18, 14, 18, 18);

            lblLichSuTitle = new Label
            {
                Text = "LỊCH SỬ BẢNG LƯƠNG",
                Dock = DockStyle.Top,
                Height = 55,
                Font = new Font(
                    "Segoe UI",
                    13F,
                    FontStyle.Bold
                ),
                ForeColor = navy,
                TextAlign = ContentAlignment.MiddleLeft
            };

            DgvLichSuLuong = new DataGridView
            {
                Name = "DgvLichSuLuong",
                Dock = DockStyle.Fill,

                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,

                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,

                ReadOnly = true,
                MultiSelect = false,
                RowHeadersVisible = false,

                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,

                AutoGenerateColumns = true,

                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,

                CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal,

                ColumnHeadersHeight = 52,

                ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode
                        .DisableResizing,

                RowTemplate =
                {
                    Height = 45
                },

                EnableHeadersVisualStyles = false
            };

            DgvLichSuLuong.ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = navy,
                    ForeColor = Color.White,
                    Font = new Font(
                        "Segoe UI",
                        10F,
                        FontStyle.Bold
                    ),
                    Alignment =
                        DataGridViewContentAlignment.MiddleLeft
                };

            DgvLichSuLuong.DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Color.White,
                    ForeColor =
                        Color.FromArgb(40, 55, 75),

                    SelectionBackColor =
                        Color.FromArgb(221, 235, 249),

                    SelectionForeColor = navy,

                    Font = new Font("Segoe UI", 10F),
                    Padding = new Padding(7, 0, 7, 0)
                };

            DgvLichSuLuong.AlternatingRowsDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor =
                        Color.FromArgb(247, 250, 253)
                };

            // Dock.Fill phải được thêm trước tiêu đề Dock.Top
            pnlLichSu.Controls.Add(DgvLichSuLuong);
            pnlLichSu.Controls.Add(lblLichSuTitle);

            // ============================
            // ASSEMBLE LAYOUT
            // ============================

            mainLayout.Controls.Add(pnlHeader, 0, 0);
            mainLayout.Controls.Add(pnlSalary, 0, 1);
            mainLayout.Controls.Add(statsLayout, 0, 2);
            mainLayout.Controls.Add(pnlLichSu, 0, 3);

            Controls.Add(mainLayout);

            ResumeLayout(false);
        }

        private Panel CreateCard()
        {
            return new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Margin = new Padding(6),
                Padding = new Padding(22),
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        #endregion
    }
}
