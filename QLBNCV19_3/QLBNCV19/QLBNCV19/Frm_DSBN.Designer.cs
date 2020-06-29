namespace QLBNCV19
{
    partial class Frm_DSBN
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
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.btnTuVong = new System.Windows.Forms.Button();
            this.btnAmTinh = new System.Windows.Forms.Button();
            this.btnDuongTinh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoVaTenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.AllowUserToAddRows = false;
            this.dgvBenhNhan.AllowUserToDeleteRows = false;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBN,
            this.colHoVaTen,
            this.colDiaChi,
            this.colNgaySinh,
            this.colTinhTrang,
            this.colHoVaTenBS,
            this.colMoTa});
            this.dgvBenhNhan.Location = new System.Drawing.Point(12, 166);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.RowHeadersVisible = false;
            this.dgvBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenhNhan.Size = new System.Drawing.Size(773, 242);
            this.dgvBenhNhan.TabIndex = 2;
            // 
            // btnTuVong
            // 
            this.btnTuVong.Location = new System.Drawing.Point(668, 88);
            this.btnTuVong.Name = "btnTuVong";
            this.btnTuVong.Size = new System.Drawing.Size(75, 23);
            this.btnTuVong.TabIndex = 21;
            this.btnTuVong.Text = "Tử vong";
            this.btnTuVong.UseVisualStyleBackColor = true;
            this.btnTuVong.Click += new System.EventHandler(this.btnTuVong_Click);
            // 
            // btnAmTinh
            // 
            this.btnAmTinh.Location = new System.Drawing.Point(573, 88);
            this.btnAmTinh.Name = "btnAmTinh";
            this.btnAmTinh.Size = new System.Drawing.Size(75, 23);
            this.btnAmTinh.TabIndex = 20;
            this.btnAmTinh.Text = "Âm tính";
            this.btnAmTinh.UseVisualStyleBackColor = true;
            this.btnAmTinh.Click += new System.EventHandler(this.btnAmTinh_Click);
            // 
            // btnDuongTinh
            // 
            this.btnDuongTinh.Location = new System.Drawing.Point(479, 88);
            this.btnDuongTinh.Name = "btnDuongTinh";
            this.btnDuongTinh.Size = new System.Drawing.Size(75, 23);
            this.btnDuongTinh.TabIndex = 19;
            this.btnDuongTinh.Text = "Dương tính";
            this.btnDuongTinh.UseVisualStyleBackColor = true;
            this.btnDuongTinh.Click += new System.EventHandler(this.btnDuongTinh_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(797, 47);
            this.label2.TabIndex = 23;
            this.label2.Text = "Quản lý bệnh nhân covid-19";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(115, 140);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(36, 18);
            this.lblSoLuong.TabIndex = 25;
            this.lblSoLuong.Text = "lblS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Số lượng:";
            // 
            // colMaBN
            // 
            this.colMaBN.DataPropertyName = "MaBN";
            this.colMaBN.HeaderText = "MSBN";
            this.colMaBN.Name = "colMaBN";
            this.colMaBN.Width = 50;
            // 
            // colHoVaTen
            // 
            this.colHoVaTen.DataPropertyName = "HoVaTen";
            this.colHoVaTen.HeaderText = "Họ và tên";
            this.colHoVaTen.Name = "colHoVaTen";
            this.colHoVaTen.Width = 150;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.DataPropertyName = "TinhTrang";
            this.colTinhTrang.HeaderText = "Tình trạng";
            this.colTinhTrang.Name = "colTinhTrang";
            // 
            // colHoVaTenBS
            // 
            this.colHoVaTenBS.DataPropertyName = "HoVaTenBS";
            this.colHoVaTenBS.HeaderText = "Bác sĩ phụ trách";
            this.colHoVaTenBS.Name = "colHoVaTenBS";
            this.colHoVaTenBS.Width = 150;
            // 
            // colMoTa
            // 
            this.colMoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.Name = "colMoTa";
            // 
            // Frm_DSBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 407);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTuVong);
            this.Controls.Add(this.btnAmTinh);
            this.Controls.Add(this.btnDuongTinh);
            this.Controls.Add(this.dgvBenhNhan);
            this.Name = "Frm_DSBN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DSBN";
            this.Load += new System.EventHandler(this.Frm_DSBN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.Button btnTuVong;
        private System.Windows.Forms.Button btnAmTinh;
        private System.Windows.Forms.Button btnDuongTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTenBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
    }
}