namespace QuanLyNhanSu.usercontrol
{
    partial class PhuCap
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
            TxtSoTienPhuCap = new TextBox();
            groupBox2 = new GroupBox();
            BtnXoaPhuCap = new Button();
            BtnSuaPhuCap = new Button();
            BtnTaoPhuCap = new Button();
            label2 = new Label();
            TxtTenPhuCap = new TextBox();
            label1 = new Label();
            TxtMaPhuCap = new TextBox();
            DgvPhuCap = new DataGridView();
            MaPhuCap = new DataGridViewTextBoxColumn();
            TenPhuCap = new DataGridViewTextBoxColumn();
            SoTien = new DataGridViewTextBoxColumn();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPhuCap).BeginInit();
            SuspendLayout();
            //
            // groupBox1
            //
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtSoTienPhuCap);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtTenPhuCap);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtMaPhuCap);
            groupBox1.Location = new Point(16, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2020, 548);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(19, 274);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 7;
            label4.Text = "Số tiền: ";
            //
            // TxtSoTienPhuCap
            //
            TxtSoTienPhuCap.Location = new Point(19, 318);
            TxtSoTienPhuCap.Name = "TxtSoTienPhuCap";
            TxtSoTienPhuCap.Size = new Size(2020, 39);
            TxtSoTienPhuCap.TabIndex = 6;
            //
            // groupBox2
            //
            groupBox2.Controls.Add(BtnXoaPhuCap);
            groupBox2.Controls.Add(BtnSuaPhuCap);
            groupBox2.Controls.Add(BtnTaoPhuCap);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(3, 381);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2014, 164);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            //
            // BtnXoaPhuCap
            //
            BtnXoaPhuCap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnXoaPhuCap.Location = new Point(1114, 60);
            BtnXoaPhuCap.Name = "BtnXoaPhuCap";
            BtnXoaPhuCap.Size = new Size(256, 56);
            BtnXoaPhuCap.TabIndex = 33;
            BtnXoaPhuCap.Text = "Xóa phụ cấp";
            BtnXoaPhuCap.UseVisualStyleBackColor = true;
            BtnXoaPhuCap.Click += BtnXoaPhuCap_Click;
            //
            // BtnSuaPhuCap
            //
            BtnSuaPhuCap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnSuaPhuCap.Location = new Point(852, 60);
            BtnSuaPhuCap.Name = "BtnSuaPhuCap";
            BtnSuaPhuCap.Size = new Size(256, 56);
            BtnSuaPhuCap.TabIndex = 33;
            BtnSuaPhuCap.Text = "Sửa phụ cấp";
            BtnSuaPhuCap.UseVisualStyleBackColor = true;
            BtnSuaPhuCap.Click += BtnSuaPhuCap_Click;
            //
            // BtnTaoPhuCap
            //
            BtnTaoPhuCap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTaoPhuCap.Location = new Point(590, 60);
            BtnTaoPhuCap.Name = "BtnTaoPhuCap";
            BtnTaoPhuCap.Size = new Size(256, 56);
            BtnTaoPhuCap.TabIndex = 33;
            BtnTaoPhuCap.Text = "Tạo phụ cấp";
            BtnTaoPhuCap.UseVisualStyleBackColor = true;
            BtnTaoPhuCap.Click += BtnTaoPhuCap_Click;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 158);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 5;
            label2.Text = "Tên phụ cấp:";
            //
            // TxtTenPhuCap
            //
            TxtTenPhuCap.Location = new Point(19, 202);
            TxtTenPhuCap.Name = "TxtTenPhuCap";
            TxtTenPhuCap.Size = new Size(2020, 39);
            TxtTenPhuCap.TabIndex = 4;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(19, 50);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 3;
            label1.Text = "Mã phụ cấp:";
            //
            // TxtMaPhuCap
            //
            TxtMaPhuCap.Location = new Point(19, 94);
            TxtMaPhuCap.Name = "TxtMaPhuCap";
            TxtMaPhuCap.Size = new Size(2020, 39);
            TxtMaPhuCap.TabIndex = 2;
            //
            // DgvPhuCap
            //
            DgvPhuCap.AllowUserToAddRows = false;
            DgvPhuCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPhuCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPhuCap.Columns.AddRange(new DataGridViewColumn[] { MaPhuCap, TenPhuCap, SoTien });
            DgvPhuCap.Dock = DockStyle.Bottom;
            DgvPhuCap.Location = new Point(0, 731);
            DgvPhuCap.Name = "DgvPhuCap";
            DgvPhuCap.RowHeadersVisible = false;
            DgvPhuCap.RowHeadersWidth = 82;
            DgvPhuCap.Size = new Size(2088, 896);
            DgvPhuCap.TabIndex = 11;
            DgvPhuCap.CellContentClick += DgvPhuCap_CellContentClick;
            //
            // MaPhuCap
            //
            MaPhuCap.DataPropertyName = "MaPhuCap";
            MaPhuCap.HeaderText = "Mã phụ cấp";
            MaPhuCap.MinimumWidth = 10;
            MaPhuCap.Name = "MaPhuCap";
            //
            // TenPhuCap
            //
            TenPhuCap.DataPropertyName = "TenPhuCap";
            TenPhuCap.HeaderText = "Tên phụ ";
            TenPhuCap.MinimumWidth = 10;
            TenPhuCap.Name = "TenPhuCap";
            //
            // SoTien
            //
            SoTien.DataPropertyName = "SoTien";
            SoTien.HeaderText = "Số tiền";
            SoTien.MinimumWidth = 10;
            SoTien.Name = "SoTien";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 12);
            label3.Name = "label3";
            label3.Size = new Size(437, 45);
            label3.TabIndex = 10;
            label3.Text = "Quản Lý Phụ Cấp Nhân Viên";
            //
            // PhuCap
            //
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(DgvPhuCap);
            Controls.Add(label3);
            Name = "PhuCap";
            Size = new Size(2088, 1627);
            Load += PhuCap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPhuCap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox TxtSoTienPhuCap;
        private GroupBox groupBox2;
        private Button BtnXoaPhuCap;
        private Button BtnSuaPhuCap;
        private Button BtnTaoPhuCap;
        private Label label2;
        private TextBox TxtTenPhuCap;
        private Label label1;
        private TextBox TxtMaPhuCap;
        private DataGridView DgvPhuCap;
        private Label label3;
        private DataGridViewTextBoxColumn MaPhuCap;
        private DataGridViewTextBoxColumn TenPhuCap;
        private DataGridViewTextBoxColumn SoTien;
    }
}
