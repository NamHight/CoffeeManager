namespace CoffeeNTNStoreManager
{
    partial class CaTruc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaTruc));
            this.dgvCaTruc = new System.Windows.Forms.DataGridView();
            this.maca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgianbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgiankt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCaTruc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dtpNgayTruc = new System.Windows.Forms.DateTimePicker();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaTruc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaTruc
            // 
            this.dgvCaTruc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaTruc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.dgvCaTruc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaTruc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maca,
            this.tenca,
            this.tgianbd,
            this.tgiankt});
            this.dgvCaTruc.Location = new System.Drawing.Point(41, 246);
            this.dgvCaTruc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCaTruc.Name = "dgvCaTruc";
            this.dgvCaTruc.RowHeadersWidth = 51;
            this.dgvCaTruc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaTruc.Size = new System.Drawing.Size(946, 244);
            this.dgvCaTruc.TabIndex = 45;
            // 
            // maca
            // 
            this.maca.DataPropertyName = "maca";
            this.maca.HeaderText = "maca";
            this.maca.MinimumWidth = 6;
            this.maca.Name = "maca";
            // 
            // tenca
            // 
            this.tenca.DataPropertyName = "tenca";
            this.tenca.HeaderText = "tenca";
            this.tenca.MinimumWidth = 6;
            this.tenca.Name = "tenca";
            // 
            // tgianbd
            // 
            this.tgianbd.DataPropertyName = "tgianbd";
            this.tgianbd.HeaderText = "tgianbd";
            this.tgianbd.MinimumWidth = 6;
            this.tgianbd.Name = "tgianbd";
            // 
            // tgiankt
            // 
            this.tgiankt.DataPropertyName = "tgiankt";
            this.tgiankt.HeaderText = "tgiankt";
            this.tgiankt.MinimumWidth = 6;
            this.tgiankt.Name = "tgiankt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(78, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ca trực";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(78, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 59;
            this.label1.Text = "Ngày trực :";
            // 
            // cboCaTruc
            // 
            this.cboCaTruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaTruc.FormattingEnabled = true;
            this.cboCaTruc.Items.AddRange(new object[] {
            "Ca sáng",
            "Ca chiều",
            "Ca tối"});
            this.cboCaTruc.Location = new System.Drawing.Point(306, 166);
            this.cboCaTruc.Name = "cboCaTruc";
            this.cboCaTruc.Size = new System.Drawing.Size(288, 39);
            this.cboCaTruc.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(78, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 32);
            this.label3.TabIndex = 55;
            this.label3.Text = "Mã Nhân viên";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(220)))), ((int)(((byte)(201)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(945, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 49);
            this.btnExit.TabIndex = 63;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(306, 60);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(288, 38);
            this.txtMaNV.TabIndex = 93;
            // 
            // dtpNgayTruc
            // 
            this.dtpNgayTruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTruc.Location = new System.Drawing.Point(306, 118);
            this.dtpNgayTruc.Name = "dtpNgayTruc";
            this.dtpNgayTruc.Size = new System.Drawing.Size(288, 27);
            this.dtpNgayTruc.TabIndex = 94;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(884, 118);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 71);
            this.btnSua.TabIndex = 109;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(772, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 71);
            this.btnXoa.TabIndex = 108;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(654, 118);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 71);
            this.btnThem.TabIndex = 107;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // CaTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(220)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1017, 524);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayTruc);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCaTruc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCaTruc);
            this.Name = "CaTruc";
            this.Text = "CaTruc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaTruc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaTruc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCaTruc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maca;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenca;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgianbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgiankt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayTruc;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}