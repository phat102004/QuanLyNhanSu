namespace QuanLyNhanSu
{
    partial class FormPhuCap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            CbxPhuCap = new ComboBox();
            groupBox2 = new GroupBox();
            BtnXong = new Button();
            BtnThemPhuCap = new Button();
            TxtTongTien = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            DgvPhuCap = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPhuCap).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CbxPhuCap);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1450, 321);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // CbxPhuCap
            // 
            CbxPhuCap.FormattingEnabled = true;
            CbxPhuCap.Location = new Point(184, 49);
            CbxPhuCap.Name = "CbxPhuCap";
            CbxPhuCap.Size = new Size(336, 40);
            CbxPhuCap.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnXong);
            groupBox2.Controls.Add(BtnThemPhuCap);
            groupBox2.Controls.Add(TxtTongTien);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(19, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1391, 151);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // BtnXong
            // 
            BtnXong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnXong.Location = new Point(319, 49);
            BtnXong.Name = "BtnXong";
            BtnXong.Size = new Size(256, 56);
            BtnXong.TabIndex = 33;
            BtnXong.Text = "Xong";
            BtnXong.UseVisualStyleBackColor = true;
            BtnXong.Click += BtnXong_Click;
            // 
            // BtnThemPhuCap
            // 
            BtnThemPhuCap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnThemPhuCap.Location = new Point(40, 49);
            BtnThemPhuCap.Name = "BtnThemPhuCap";
            BtnThemPhuCap.Size = new Size(256, 56);
            BtnThemPhuCap.TabIndex = 33;
            BtnThemPhuCap.Text = "Thêm";
            BtnThemPhuCap.UseVisualStyleBackColor = true;
            BtnThemPhuCap.Click += BtnThemPhuCap_Click;
            // 
            // TxtTongTien
            // 
            TxtTongTien.Location = new Point(959, 58);
            TxtTongTien.Name = "TxtTongTien";
            TxtTongTien.Size = new Size(356, 39);
            TxtTongTien.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(804, 61);
            label5.Name = "label5";
            label5.Size = new Size(131, 32);
            label5.TabIndex = 5;
            label5.Text = "Tổng tiền:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 52);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 5;
            label2.Text = "Tên phụ cấp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(31, 19);
            label3.Name = "label3";
            label3.Size = new Size(219, 45);
            label3.TabIndex = 11;
            label3.Text = "Tinh Phụ Cấp";
            // 
            // DgvPhuCap
            // 
            DgvPhuCap.AllowUserToAddRows = false;
            DgvPhuCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPhuCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPhuCap.Dock = DockStyle.Bottom;
            DgvPhuCap.Location = new Point(0, 406);
            DgvPhuCap.Name = "DgvPhuCap";
            DgvPhuCap.RowHeadersVisible = false;
            DgvPhuCap.RowHeadersWidth = 82;
            DgvPhuCap.Size = new Size(1474, 523);
            DgvPhuCap.TabIndex = 12;
            // 
            // FormPhuCap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 929);
            Controls.Add(DgvPhuCap);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "FormPhuCap";
            Text = "FormPhuCap";
            Load += FormPhuCap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPhuCap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnXong;
        private Button BtnThemPhuCap;
        private Label label2;
        private Label label3;
        private TextBox TxtTongTien;
        private Label label5;
        private DataGridView DgvPhuCap;
        private ComboBox CbxPhuCap;
    }
}