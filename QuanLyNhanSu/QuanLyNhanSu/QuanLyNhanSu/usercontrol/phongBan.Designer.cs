namespace QuanLyNhanSu.usercontrol
{
    partial class Uc_phongBan
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            BtnXoaPhongBan = new Button();
            BtnSuaPhongBan = new Button();
            BtnTaoPhongBan = new Button();
            label2 = new Label();
            TxtTenPhongBan = new TextBox();
            label1 = new Label();
            TxtMaPhongBan = new TextBox();
            label3 = new Label();
            Dgv_phongBan = new DataGridView();
            MaPhongBan = new DataGridViewTextBoxColumn();
            TenPhongBan = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_phongBan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtTenPhongBan);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtMaPhongBan);
            groupBox1.Location = new Point(16, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2020, 548);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnXoaPhongBan);
            groupBox2.Controls.Add(BtnSuaPhongBan);
            groupBox2.Controls.Add(BtnTaoPhongBan);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(3, 345);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2014, 200);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // BtnXoaPhongBan
            // 
            BtnXoaPhongBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnXoaPhongBan.Location = new Point(1114, 72);
            BtnXoaPhongBan.Name = "BtnXoaPhongBan";
            BtnXoaPhongBan.Size = new Size(256, 56);
            BtnXoaPhongBan.TabIndex = 33;
            BtnXoaPhongBan.Text = "Xóa phòng ban";
            BtnXoaPhongBan.UseVisualStyleBackColor = true;
            BtnXoaPhongBan.Click += BtnXoaPhongBan_Click;
            // 
            // BtnSuaPhongBan
            // 
            BtnSuaPhongBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnSuaPhongBan.Location = new Point(852, 72);
            BtnSuaPhongBan.Name = "BtnSuaPhongBan";
            BtnSuaPhongBan.Size = new Size(256, 56);
            BtnSuaPhongBan.TabIndex = 33;
            BtnSuaPhongBan.Text = "Sửa phòng ban";
            BtnSuaPhongBan.UseVisualStyleBackColor = true;
            BtnSuaPhongBan.Click += BtnSuaPhongBan_Click;
            // 
            // BtnTaoPhongBan
            // 
            BtnTaoPhongBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTaoPhongBan.Location = new Point(590, 72);
            BtnTaoPhongBan.Name = "BtnTaoPhongBan";
            BtnTaoPhongBan.Size = new Size(256, 56);
            BtnTaoPhongBan.TabIndex = 33;
            BtnTaoPhongBan.Text = "Tạo phòng ban";
            BtnTaoPhongBan.UseVisualStyleBackColor = true;
            BtnTaoPhongBan.Click += BtnTaoPhongBan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 187);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 5;
            label2.Text = "Tên phòng ban: ";
            // 
            // TxtTenPhongBan
            // 
            TxtTenPhongBan.Location = new Point(19, 231);
            TxtTenPhongBan.Name = "TxtTenPhongBan";
            TxtTenPhongBan.Size = new Size(1980, 39);
            TxtTenPhongBan.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(19, 50);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 3;
            label1.Text = "Mã phòng ban: ";
            // 
            // TxtMaPhongBan
            // 
            TxtMaPhongBan.Location = new Point(19, 94);
            TxtMaPhongBan.Name = "TxtMaPhongBan";
            TxtMaPhongBan.Size = new Size(1980, 39);
            TxtMaPhongBan.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 24);
            label3.Name = "label3";
            label3.Size = new Size(313, 45);
            label3.TabIndex = 2;
            label3.Text = "Quản Lý Phòng Ban";
            // 
            // Dgv_phongBan
            // 
            Dgv_phongBan.AllowUserToAddRows = false;
            Dgv_phongBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_phongBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_phongBan.Columns.AddRange(new DataGridViewColumn[] { MaPhongBan, TenPhongBan });
            Dgv_phongBan.Dock = DockStyle.Bottom;
            Dgv_phongBan.Location = new Point(0, 632);
            Dgv_phongBan.Name = "Dgv_phongBan";
            Dgv_phongBan.RowHeadersVisible = false;
            Dgv_phongBan.RowHeadersWidth = 82;
            Dgv_phongBan.Size = new Size(2054, 896);
            Dgv_phongBan.TabIndex = 3;
            Dgv_phongBan.CellContentClick += Dgv_phongBan_CellContentClick;
            // 
            // MaPhongBan
            // 
            MaPhongBan.DataPropertyName = "MaPhongBan";
            MaPhongBan.HeaderText = "Mã phòng ban";
            MaPhongBan.MinimumWidth = 10;
            MaPhongBan.Name = "MaPhongBan";
            // 
            // TenPhongBan
            // 
            TenPhongBan.DataPropertyName = "TenPhongBan";
            TenPhongBan.HeaderText = "Tên phòng ban";
            TenPhongBan.MinimumWidth = 10;
            TenPhongBan.Name = "TenPhongBan";
            // 
            // Uc_phongBan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Dgv_phongBan);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "Uc_phongBan";
            Size = new Size(2054, 1528);
            Load += Uc_phongBan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_phongBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private TextBox TxtMaPhongBan;
        private Label label2;
        private TextBox TxtTenPhongBan;
        private Button BtnXoaPhongBan;
        private Button BtnSuaPhongBan;
        private Button BtnTaoPhongBan;
        private GroupBox groupBox2;
        private DataGridView Dgv_phongBan;
        private DataGridViewTextBoxColumn MaPhongBan;
        private DataGridViewTextBoxColumn TenPhongBan;
    }
}
