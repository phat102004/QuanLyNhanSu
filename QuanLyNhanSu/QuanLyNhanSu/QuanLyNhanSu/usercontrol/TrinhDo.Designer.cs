namespace QuanLyNhanSu.usercontrol
{
    partial class TrinhDo
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
            TxtMaTrinhDo = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            BtnXoaTrinhDo = new Button();
            BtnSuaTrinhDo = new Button();
            BtnTaoTrinhDo = new Button();
            label2 = new Label();
            TxtTenTrinhDo = new TextBox();
            label1 = new Label();
            DgvTrinhDo = new DataGridView();
            MaTrinhDo = new DataGridViewTextBoxColumn();
            TenTrinhDo = new DataGridViewTextBoxColumn();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTrinhDo).BeginInit();
            SuspendLayout();
            // 
            // TxtMaTrinhDo
            // 
            TxtMaTrinhDo.Location = new Point(19, 94);
            TxtMaTrinhDo.Name = "TxtMaTrinhDo";
            TxtMaTrinhDo.Size = new Size(1980, 39);
            TxtMaTrinhDo.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtTenTrinhDo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtMaTrinhDo);
            groupBox1.Location = new Point(16, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2020, 548);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnXoaTrinhDo);
            groupBox2.Controls.Add(BtnSuaTrinhDo);
            groupBox2.Controls.Add(BtnTaoTrinhDo);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(3, 345);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2014, 200);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // BtnXoaTrinhDo
            // 
            BtnXoaTrinhDo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnXoaTrinhDo.Location = new Point(1114, 72);
            BtnXoaTrinhDo.Name = "BtnXoaTrinhDo";
            BtnXoaTrinhDo.Size = new Size(256, 56);
            BtnXoaTrinhDo.TabIndex = 33;
            BtnXoaTrinhDo.Text = "Xóa trình độ";
            BtnXoaTrinhDo.UseVisualStyleBackColor = true;
            BtnXoaTrinhDo.Click += BtnXoaTrinhDo_Click;
            // 
            // BtnSuaTrinhDo
            // 
            BtnSuaTrinhDo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnSuaTrinhDo.Location = new Point(852, 72);
            BtnSuaTrinhDo.Name = "BtnSuaTrinhDo";
            BtnSuaTrinhDo.Size = new Size(256, 56);
            BtnSuaTrinhDo.TabIndex = 33;
            BtnSuaTrinhDo.Text = "Sửa trình độ";
            BtnSuaTrinhDo.UseVisualStyleBackColor = true;
            BtnSuaTrinhDo.Click += BtnSuaTrinhDo_Click;
            // 
            // BtnTaoTrinhDo
            // 
            BtnTaoTrinhDo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTaoTrinhDo.Location = new Point(590, 72);
            BtnTaoTrinhDo.Name = "BtnTaoTrinhDo";
            BtnTaoTrinhDo.Size = new Size(256, 56);
            BtnTaoTrinhDo.TabIndex = 33;
            BtnTaoTrinhDo.Text = "Tạo trình độ";
            BtnTaoTrinhDo.UseVisualStyleBackColor = true;
            BtnTaoTrinhDo.Click += BtnTaoTrinhDo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 187);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 5;
            label2.Text = "Tên trình độ: ";
            // 
            // TxtTenTrinhDo
            // 
            TxtTenTrinhDo.Location = new Point(19, 231);
            TxtTenTrinhDo.Name = "TxtTenTrinhDo";
            TxtTenTrinhDo.Size = new Size(1980, 39);
            TxtTenTrinhDo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(19, 50);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 3;
            label1.Text = "Mã trình độ: ";
            // 
            // DgvTrinhDo
            // 
            DgvTrinhDo.AllowUserToAddRows = false;
            DgvTrinhDo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTrinhDo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTrinhDo.Columns.AddRange(new DataGridViewColumn[] { MaTrinhDo, TenTrinhDo });
            DgvTrinhDo.Dock = DockStyle.Bottom;
            DgvTrinhDo.Location = new Point(0, 731);
            DgvTrinhDo.Name = "DgvTrinhDo";
            DgvTrinhDo.RowHeadersVisible = false;
            DgvTrinhDo.RowHeadersWidth = 82;
            DgvTrinhDo.Size = new Size(2088, 896);
            DgvTrinhDo.TabIndex = 6;
            DgvTrinhDo.CellContentClick += DgvTrinhDo_CellContentClick;
            // 
            // MaTrinhDo
            // 
            MaTrinhDo.DataPropertyName = "MaTrinhDo";
            MaTrinhDo.HeaderText = "Mã trình độ";
            MaTrinhDo.MinimumWidth = 10;
            MaTrinhDo.Name = "MaTrinhDo";
            // 
            // TenTrinhDo
            // 
            TenTrinhDo.DataPropertyName = "TenTrinhDo";
            TenTrinhDo.HeaderText = "Tên trình ";
            TenTrinhDo.MinimumWidth = 10;
            TenTrinhDo.Name = "TenTrinhDo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 12);
            label3.Name = "label3";
            label3.Size = new Size(443, 45);
            label3.TabIndex = 5;
            label3.Text = "Quản Lý Trình Độ Nhân Viên";
            // 
            // TrinhDo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(DgvTrinhDo);
            Controls.Add(label3);
            Name = "TrinhDo";
            Size = new Size(2088, 1627);
            Load += TrinhDo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvTrinhDo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtMaTrinhDo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnXoaTrinhDo;
        private Button BtnSuaTrinhDo;
        private Button BtnTaoTrinhDo;
        private Label label2;
        private TextBox TxtTenTrinhDo;
        private Label label1;
        private DataGridView DgvTrinhDo;
        private Label label3;
        private DataGridViewTextBoxColumn MaTrinhDo;
        private DataGridViewTextBoxColumn TenTrinhDo;
    }
}
