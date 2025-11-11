namespace Bai09
{
    partial class Form1
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
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lstbMonDaChon = new System.Windows.Forms.ListBox();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.lstbMonChuaChon = new System.Windows.Forms.ListBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.cmbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongTin
            // 
            this.grThongTin.Controls.Add(this.dgvSinhVien);
            this.grThongTin.Controls.Add(this.btnXoaChon);
            this.grThongTin.Controls.Add(this.btnLuu);
            this.grThongTin.Controls.Add(this.lstbMonDaChon);
            this.grThongTin.Controls.Add(this.btnBoChon);
            this.grThongTin.Controls.Add(this.btnChon);
            this.grThongTin.Controls.Add(this.lstbMonChuaChon);
            this.grThongTin.Controls.Add(this.radNu);
            this.grThongTin.Controls.Add(this.radNam);
            this.grThongTin.Controls.Add(this.cmbChuyenNganh);
            this.grThongTin.Controls.Add(this.txtHoTen);
            this.grThongTin.Controls.Add(this.txtMSSV);
            this.grThongTin.Controls.Add(this.label5);
            this.grThongTin.Controls.Add(this.label4);
            this.grThongTin.Controls.Add(this.label3);
            this.grThongTin.Controls.Add(this.label2);
            this.grThongTin.Controls.Add(this.label1);
            this.grThongTin.Location = new System.Drawing.Point(27, 0);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(886, 687);
            this.grThongTin.TabIndex = 0;
            this.grThongTin.TabStop = false;
            this.grThongTin.Text = "Thông Tin Sinh Viên";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colHoTen,
            this.colChuyenNganh,
            this.colGioiTinh,
            this.colSoMon});
            this.dgvSinhVien.Location = new System.Drawing.Point(82, 429);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(747, 252);
            this.dgvSinhVien.TabIndex = 16;
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Width = 125;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 150;
            // 
            // colChuyenNganh
            // 
            this.colChuyenNganh.HeaderText = "Chuyên Ngành";
            this.colChuyenNganh.MinimumWidth = 6;
            this.colChuyenNganh.Name = "colChuyenNganh";
            this.colChuyenNganh.Width = 150;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 125;
            // 
            // colSoMon
            // 
            this.colSoMon.HeaderText = "Số Môn";
            this.colSoMon.MinimumWidth = 6;
            this.colSoMon.Name = "colSoMon";
            this.colSoMon.Width = 125;
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(514, 394);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(83, 29);
            this.btnXoaChon.TabIndex = 15;
            this.btnXoaChon.Text = "Xóa Chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(348, 394);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 29);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu Thông Tin";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lstbMonDaChon
            // 
            this.lstbMonDaChon.FormattingEnabled = true;
            this.lstbMonDaChon.ItemHeight = 16;
            this.lstbMonDaChon.Location = new System.Drawing.Point(514, 224);
            this.lstbMonDaChon.Name = "lstbMonDaChon";
            this.lstbMonDaChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbMonDaChon.Size = new System.Drawing.Size(315, 164);
            this.lstbMonDaChon.TabIndex = 13;
            // 
            // btnBoChon
            // 
            this.btnBoChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoChon.Location = new System.Drawing.Point(429, 330);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(43, 42);
            this.btnBoChon.TabIndex = 12;
            this.btnBoChon.Text = "< ";
            this.btnBoChon.UseVisualStyleBackColor = true;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(429, 267);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(43, 42);
            this.btnChon.TabIndex = 11;
            this.btnChon.Text = ">";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // lstbMonChuaChon
            // 
            this.lstbMonChuaChon.FormattingEnabled = true;
            this.lstbMonChuaChon.ItemHeight = 16;
            this.lstbMonChuaChon.Location = new System.Drawing.Point(75, 224);
            this.lstbMonChuaChon.Name = "lstbMonChuaChon";
            this.lstbMonChuaChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbMonChuaChon.Size = new System.Drawing.Size(315, 164);
            this.lstbMonChuaChon.TabIndex = 10;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(387, 150);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 9;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(267, 150);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 8;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // cmbChuyenNganh
            // 
            this.cmbChuyenNganh.FormattingEnabled = true;
            this.cmbChuyenNganh.Location = new System.Drawing.Point(267, 103);
            this.cmbChuyenNganh.Name = "cmbChuyenNganh";
            this.cmbChuyenNganh.Size = new System.Drawing.Size(304, 24);
            this.cmbChuyenNganh.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(267, 66);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(304, 22);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(267, 33);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(238, 22);
            this.txtMSSV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn Các Môn Học Tham Gia: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuyên Ngành: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 699);
            this.Controls.Add(this.grThongTin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Quản Lí Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.ComboBox cmbChuyenNganh;
        private System.Windows.Forms.ListBox lstbMonChuaChon;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ListBox lstbMonDaChon;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoMon;
    }
}

