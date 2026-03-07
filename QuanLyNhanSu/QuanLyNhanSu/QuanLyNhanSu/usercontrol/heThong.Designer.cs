namespace QuanLyNhanSu.usercontrol // Changed namespace
{
    partial class heThong // Changed class name
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
            labelTitle = new Label();
            flowLayoutPanelMain = new FlowLayoutPanel();
            btnQLTaiKhoan = new Button();
            btnCoCauToChuc = new Button();
            btnCauHinhChamCong = new Button();
            btnCauHinhLuong = new Button();
            btnCauHinhNghiPhep = new Button();
            btnNhatKyHeThong = new Button();
            btnSaoLuu = new Button();
            flowLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(51, 51, 76);
            labelTitle.Location = new Point(20, 20);
            labelTitle.Margin = new Padding(6, 0, 6, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(399, 51);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Quản Lý Hệ Thống";
            // 
            // flowLayoutPanelMain
            // 
            flowLayoutPanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelMain.Controls.Add(btnQLTaiKhoan);
            flowLayoutPanelMain.Controls.Add(btnCoCauToChuc);
            flowLayoutPanelMain.Controls.Add(btnCauHinhChamCong);
            flowLayoutPanelMain.Controls.Add(btnCauHinhLuong);
            flowLayoutPanelMain.Controls.Add(btnCauHinhNghiPhep);
            flowLayoutPanelMain.Controls.Add(btnNhatKyHeThong);
            flowLayoutPanelMain.Controls.Add(btnSaoLuu);
            flowLayoutPanelMain.Location = new Point(39, 73);
            flowLayoutPanelMain.Margin = new Padding(6, 7, 6, 7);
            flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            flowLayoutPanelMain.Padding = new Padding(20);
            flowLayoutPanelMain.Size = new Size(1472, 854);
            flowLayoutPanelMain.TabIndex = 1;
            // 
            // btnQLTaiKhoan
            // 
            btnQLTaiKhoan.BackColor = Color.FromArgb(51, 51, 76);
            btnQLTaiKhoan.FlatAppearance.BorderSize = 0;
            btnQLTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnQLTaiKhoan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLTaiKhoan.ForeColor = Color.White;
            btnQLTaiKhoan.Location = new Point(40, 40);
            btnQLTaiKhoan.Margin = new Padding(20);
            btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            btnQLTaiKhoan.Size = new Size(350, 200);
            btnQLTaiKhoan.TabIndex = 0;
            btnQLTaiKhoan.Text = "👤 Quản lý Truy cập\r\n(Tài khoản && Phân quyền)";
            btnQLTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btnCoCauToChuc
            // 
            btnCoCauToChuc.BackColor = Color.FromArgb(0, 150, 136);
            btnCoCauToChuc.FlatAppearance.BorderSize = 0;
            btnCoCauToChuc.FlatStyle = FlatStyle.Flat;
            btnCoCauToChuc.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCoCauToChuc.ForeColor = Color.White;
            btnCoCauToChuc.Location = new Point(430, 40);
            btnCoCauToChuc.Margin = new Padding(20);
            btnCoCauToChuc.Name = "btnCoCauToChuc";
            btnCoCauToChuc.Size = new Size(350, 200);
            btnCoCauToChuc.TabIndex = 1;
            btnCoCauToChuc.Text = "🏢 Cơ cấu Tổ chức\r\n(Phòng ban && Chức vụ)";
            btnCoCauToChuc.UseVisualStyleBackColor = false;
            // 
            // btnCauHinhChamCong
            // 
            btnCauHinhChamCong.BackColor = Color.FromArgb(255, 152, 0);
            btnCauHinhChamCong.FlatAppearance.BorderSize = 0;
            btnCauHinhChamCong.FlatStyle = FlatStyle.Flat;
            btnCauHinhChamCong.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCauHinhChamCong.ForeColor = Color.White;
            btnCauHinhChamCong.Location = new Point(820, 40);
            btnCauHinhChamCong.Margin = new Padding(20);
            btnCauHinhChamCong.Name = "btnCauHinhChamCong";
            btnCauHinhChamCong.Size = new Size(350, 200);
            btnCauHinhChamCong.TabIndex = 2;
            btnCauHinhChamCong.Text = "⏰ Cấu hình Chấm công\r\n(Ca làm việc, Ngày lễ)";
            btnCauHinhChamCong.UseVisualStyleBackColor = false;
            // 
            // btnCauHinhLuong
            // 
            btnCauHinhLuong.BackColor = Color.FromArgb(96, 125, 139);
            btnCauHinhLuong.FlatAppearance.BorderSize = 0;
            btnCauHinhLuong.FlatStyle = FlatStyle.Flat;
            btnCauHinhLuong.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCauHinhLuong.ForeColor = Color.White;
            btnCauHinhLuong.Location = new Point(40, 280);
            btnCauHinhLuong.Margin = new Padding(20);
            btnCauHinhLuong.Name = "btnCauHinhLuong";
            btnCauHinhLuong.Size = new Size(350, 200);
            btnCauHinhLuong.TabIndex = 3;
            btnCauHinhLuong.Text = "💰 Cấu hình Lương\r\n(Phụ cấp, Hợp đồng...)";
            btnCauHinhLuong.UseVisualStyleBackColor = false;
            // 
            // btnCauHinhNghiPhep
            // 
            btnCauHinhNghiPhep.BackColor = Color.FromArgb(3, 169, 244);
            btnCauHinhNghiPhep.FlatAppearance.BorderSize = 0;
            btnCauHinhNghiPhep.FlatStyle = FlatStyle.Flat;
            btnCauHinhNghiPhep.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCauHinhNghiPhep.ForeColor = Color.White;
            btnCauHinhNghiPhep.Location = new Point(430, 280);
            btnCauHinhNghiPhep.Margin = new Padding(20);
            btnCauHinhNghiPhep.Name = "btnCauHinhNghiPhep";
            btnCauHinhNghiPhep.Size = new Size(350, 200);
            btnCauHinhNghiPhep.TabIndex = 4;
            btnCauHinhNghiPhep.Text = "🌴 Cấu hình Nghỉ phép\r\n(Loại phép)";
            btnCauHinhNghiPhep.UseVisualStyleBackColor = false;
            // 
            // btnNhatKyHeThong
            // 
            btnNhatKyHeThong.BackColor = Color.FromArgb(158, 158, 158);
            btnNhatKyHeThong.FlatAppearance.BorderSize = 0;
            btnNhatKyHeThong.FlatStyle = FlatStyle.Flat;
            btnNhatKyHeThong.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhatKyHeThong.ForeColor = Color.White;
            btnNhatKyHeThong.Location = new Point(820, 280);
            btnNhatKyHeThong.Margin = new Padding(20);
            btnNhatKyHeThong.Name = "btnNhatKyHeThong";
            btnNhatKyHeThong.Size = new Size(350, 200);
            btnNhatKyHeThong.TabIndex = 5;
            btnNhatKyHeThong.Text = "📜 Nhật ký Hệ thống\r\n(Audit Log)";
            btnNhatKyHeThong.UseVisualStyleBackColor = false;
            // 
            // btnSaoLuu
            // 
            btnSaoLuu.BackColor = Color.FromArgb(233, 30, 99);
            btnSaoLuu.FlatAppearance.BorderSize = 0;
            btnSaoLuu.FlatStyle = FlatStyle.Flat;
            btnSaoLuu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaoLuu.ForeColor = Color.White;
            btnSaoLuu.Location = new Point(40, 520);
            btnSaoLuu.Margin = new Padding(20);
            btnSaoLuu.Name = "btnSaoLuu";
            btnSaoLuu.Size = new Size(350, 200);
            btnSaoLuu.TabIndex = 6;
            btnSaoLuu.Text = "💾 Sao lưu && Phục hồi\r\n(Backup && Restore)";
            btnSaoLuu.UseVisualStyleBackColor = false;
            // 
            // heThong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(flowLayoutPanelMain);
            Controls.Add(labelTitle);
            Margin = new Padding(6, 7, 6, 7);
            Name = "heThong";
            Size = new Size(1550, 1000);
            flowLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // --- Declare Controls ---
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Button btnQLTaiKhoan;
        private System.Windows.Forms.Button btnCoCauToChuc;
        private System.Windows.Forms.Button btnCauHinhChamCong;
        private System.Windows.Forms.Button btnCauHinhLuong;
        private System.Windows.Forms.Button btnCauHinhNghiPhep;
        private System.Windows.Forms.Button btnNhatKyHeThong;
        private System.Windows.Forms.Button btnSaoLuu;
    }
}