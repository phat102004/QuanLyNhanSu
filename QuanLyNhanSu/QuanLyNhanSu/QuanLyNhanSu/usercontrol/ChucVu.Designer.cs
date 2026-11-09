namespace QuanLyNhanSu.usercontrol
{
    partial class ChucVu
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
            label4 = new Label();
            TxtLuongChucVu = new TextBox();
            groupBox2 = new GroupBox();
            BtnXoaChucVu = new Button();
            BtnSuaChucVu = new Button();
            BtnTaoChucVu = new Button();
            label2 = new Label();
            TxtTenChucVu = new TextBox();
            label1 = new Label();
            TxtMaChucVu = new TextBox();
            label3 = new Label();
            DgvChucVu = new DataGridView();
            MaChucVu = new DataGridViewTextBoxColumn();
            TenChucVu = new DataGridViewTextBoxColumn();
            Luong = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvChucVu).BeginInit();
            SuspendLayout();
            //
            // groupBox1
            //
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtLuongChucVu);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtTenChucVu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtMaChucVu);
            groupBox1.Location = new Point(16, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2020, 548);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(19, 274);
            label4.Name = "label4";
            label4.Size = new Size(190, 32);
            label4.TabIndex = 7;
            label4.Text = "Lương chức vụ:";
            //
            // TxtLuongChucVu
            //
            TxtLuongChucVu.Location = new Point(19, 318);
            TxtLuongChucVu.Name = "TxtLuongChucVu";
            TxtLuongChucVu.Size = new Size(2020, 39);
            TxtLuongChucVu.TabIndex = 6;
            //
            // groupBox2
            //
            groupBox2.Controls.Add(BtnXoaChucVu);
            groupBox2.Controls.Add(BtnSuaChucVu);
            groupBox2.Controls.Add(BtnTaoChucVu);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(3, 381);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2014, 164);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            //
            // BtnXoaChucVu
            //
            BtnXoaChucVu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnXoaChucVu.Location = new Point(1114, 60);
            BtnXoaChucVu.Name = "BtnXoaChucVu";
            BtnXoaChucVu.Size = new Size(256, 56);
            BtnXoaChucVu.TabIndex = 33;
            BtnXoaChucVu.Text = "Xóa chức vụ";
            BtnXoaChucVu.UseVisualStyleBackColor = true;
            BtnXoaChucVu.Click += BtnXoaChucVu_Click;
            //
            // BtnSuaChucVu
            //
            BtnSuaChucVu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnSuaChucVu.Location = new Point(852, 60);
            BtnSuaChucVu.Name = "BtnSuaChucVu";
            BtnSuaChucVu.Size = new Size(256, 56);
            BtnSuaChucVu.TabIndex = 33;
            BtnSuaChucVu.Text = "Sửa chức vụ";
            BtnSuaChucVu.UseVisualStyleBackColor = true;
            BtnSuaChucVu.Click += BtnSuaChucVu_Click;
            //
            // BtnTaoChucVu
            //
            BtnTaoChucVu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTaoChucVu.Location = new Point(590, 60);
            BtnTaoChucVu.Name = "BtnTaoChucVu";
            BtnTaoChucVu.Size = new Size(256, 56);
            BtnTaoChucVu.TabIndex = 33;
            BtnTaoChucVu.Text = "Tạo chức vụ";
            BtnTaoChucVu.UseVisualStyleBackColor = true;
            BtnTaoChucVu.Click += BtnTaoChucVu_Click;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 158);
            label2.Name = "label2";
            label2.Size = new Size(157, 32);
            label2.TabIndex = 5;
            label2.Text = "Tên chức vụ:";
            //
            // TxtTenChucVu
            //
            TxtTenChucVu.Location = new Point(19, 202);
            TxtTenChucVu.Name = "TxtTenChucVu";
            TxtTenChucVu.Size = new Size(2020, 39);
            TxtTenChucVu.TabIndex = 4;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(19, 50);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 3;
            label1.Text = "Mã chức vụ:";
            //
            // TxtMaChucVu
            //
            TxtMaChucVu.Location = new Point(19, 94);
            TxtMaChucVu.Name = "TxtMaChucVu";
            TxtMaChucVu.Size = new Size(2020, 39);
            TxtMaChucVu.TabIndex = 2;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 12);
            label3.Name = "label3";
            label3.Size = new Size(437, 45);
            label3.TabIndex = 7;
            label3.Text = "Quản Lý Chức Vụ Nhân Viên";
            //
            // DgvChucVu
            //
            DgvChucVu.AllowUserToAddRows = false;
            DgvChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvChucVu.Columns.AddRange(new DataGridViewColumn[] { MaChucVu, TenChucVu, Luong });
            DgvChucVu.Dock = DockStyle.Bottom;
            DgvChucVu.Location = new Point(0, 731);
            DgvChucVu.Name = "DgvChucVu";
            DgvChucVu.RowHeadersVisible = false;
            DgvChucVu.RowHeadersWidth = 82;
            DgvChucVu.Size = new Size(2088, 896);
            DgvChucVu.TabIndex = 8;
            DgvChucVu.CellContentClick += DgvChucVu_CellContentClick;
            //
            // MaChucVu
            //
            MaChucVu.DataPropertyName = "MaChucVu";
            MaChucVu.HeaderText = "Mã chức vụ";
            MaChucVu.MinimumWidth = 10;
            MaChucVu.Name = "MaChucVu";
            //
            // TenChucVu
            //
            TenChucVu.DataPropertyName = "TenChucVu";
            TenChucVu.HeaderText = "Tên chức ";
            TenChucVu.MinimumWidth = 10;
            TenChucVu.Name = "TenChucVu";
            //
            // Luong
            //
            Luong.DataPropertyName = "Luong";
            Luong.HeaderText = "Lương";
            Luong.MinimumWidth = 10;
            Luong.Name = "Luong";
            //
            // ChucVu
            //
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DgvChucVu);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "ChucVu";
            Size = new Size(2088, 1627);
            Load += ChucVu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvChucVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnXoaChucVu;
        private Button BtnSuaChucVu;
        private Button BtnTaoChucVu;
        private Label label2;
        private TextBox TxtTenChucVu;
        private Label label1;
        private TextBox TxtMaChucVu;
        private Label label3;
        private DataGridView DgvChucVu;
        private Label label4;
        private TextBox TxtLuongChucVu;
        private DataGridViewTextBoxColumn MaChucVu;
        private DataGridViewTextBoxColumn TenChucVu;
        private DataGridViewTextBoxColumn Luong;
    }
}
