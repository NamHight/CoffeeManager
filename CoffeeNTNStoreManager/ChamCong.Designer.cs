namespace CoffeeNTNStoreManager
{
    partial class ChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChamCong));
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.macc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgianbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgiankt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayNghi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaChamCong = new System.Windows.Forms.TextBox();
            this.cboTenNVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayKThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayBDau = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macc,
            this.manv,
            this.tgianbd,
            this.tgiankt,
            this.ngaynghi});
            this.dgvChamCong.Location = new System.Drawing.Point(12, 218);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(993, 285);
            this.dgvChamCong.TabIndex = 31;
            // 
            // macc
            // 
            this.macc.DataPropertyName = "macc";
            this.macc.HeaderText = "macc";
            this.macc.MinimumWidth = 6;
            this.macc.Name = "macc";
            this.macc.Width = 125;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "manv";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 125;
            // 
            // tgianbd
            // 
            this.tgianbd.DataPropertyName = "tgianbd";
            this.tgianbd.HeaderText = "tgianbd";
            this.tgianbd.MinimumWidth = 6;
            this.tgianbd.Name = "tgianbd";
            this.tgianbd.Width = 125;
            // 
            // tgiankt
            // 
            this.tgiankt.DataPropertyName = "tgiankt";
            this.tgiankt.HeaderText = "tgiankt";
            this.tgiankt.MinimumWidth = 6;
            this.tgiankt.Name = "tgiankt";
            this.tgiankt.Width = 125;
            // 
            // ngaynghi
            // 
            this.ngaynghi.DataPropertyName = "ngaynghi";
            this.ngaynghi.HeaderText = "ngaynghi";
            this.ngaynghi.MinimumWidth = 6;
            this.ngaynghi.Name = "ngaynghi";
            this.ngaynghi.Width = 125;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(220)))), ((int)(((byte)(201)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(967, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 44);
            this.btnExit.TabIndex = 42;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(878, 139);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(62, 42);
            this.btnSua.TabIndex = 121;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(755, 139);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(62, 42);
            this.btnXoa.TabIndex = 120;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(639, 139);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(62, 42);
            this.btnThem.TabIndex = 119;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dtpNgayNghi
            // 
            this.dtpNgayNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNghi.Location = new System.Drawing.Point(606, 35);
            this.dtpNgayNghi.Name = "dtpNgayNghi";
            this.dtpNgayNghi.Size = new System.Drawing.Size(277, 27);
            this.dtpNgayNghi.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(446, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 112;
            this.label4.Text = "Ngày Nghỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(58, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 111;
            this.label3.Text = "Tên Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 109;
            this.label1.Text = "Mã Chấm Công:";
            // 
            // txtMaChamCong
            // 
            this.txtMaChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChamCong.Location = new System.Drawing.Point(231, 28);
            this.txtMaChamCong.Name = "txtMaChamCong";
            this.txtMaChamCong.Size = new System.Drawing.Size(167, 30);
            this.txtMaChamCong.TabIndex = 108;
            // 
            // cboTenNVien
            // 
            this.cboTenNVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenNVien.FormattingEnabled = true;
            this.cboTenNVien.Location = new System.Drawing.Point(231, 79);
            this.cboTenNVien.Name = "cboTenNVien";
            this.cboTenNVien.Size = new System.Drawing.Size(167, 33);
            this.cboTenNVien.TabIndex = 123;
            // 
            // dtpNgayKThuc
            // 
            this.dtpNgayKThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKThuc.Location = new System.Drawing.Point(231, 137);
            this.dtpNgayKThuc.Name = "dtpNgayKThuc";
            this.dtpNgayKThuc.Size = new System.Drawing.Size(297, 27);
            this.dtpNgayKThuc.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(59, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 124;
            this.label2.Text = "Ngày Kết Thúc:";
            // 
            // dtpNgayBDau
            // 
            this.dtpNgayBDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBDau.Location = new System.Drawing.Point(606, 85);
            this.dtpNgayBDau.Name = "dtpNgayBDau";
            this.dtpNgayBDau.Size = new System.Drawing.Size(277, 27);
            this.dtpNgayBDau.TabIndex = 127;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(446, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 126;
            this.label5.Text = "Ngày Bắt Đầu:";
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(220)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1017, 524);
            this.Controls.Add(this.dtpNgayBDau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgayKThuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTenNVien);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayNghi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaChamCong);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvChamCong);
            this.Name = "ChamCong";
            this.Text = "Chấm Công";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayNghi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaChamCong;
        private System.Windows.Forms.ComboBox cboTenNVien;
        private System.Windows.Forms.DateTimePicker dtpNgayKThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayBDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn macc;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgianbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgiankt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynghi;
    }
}