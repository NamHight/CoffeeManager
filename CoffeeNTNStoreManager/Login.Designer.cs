namespace CoffeeNTNStoreManager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPassword.BackgroundImage")));
            this.pnlPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPassword.Location = new System.Drawing.Point(40, 229);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(76, 62);
            this.pnlPassword.TabIndex = 39;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.DarkSalmon;
            this.txtMatKhau.Location = new System.Drawing.Point(131, 239);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '♥';
            this.txtMatKhau.Size = new System.Drawing.Size(316, 49);
            this.txtMatKhau.TabIndex = 37;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUsername.BackgroundImage")));
            this.pnlUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUsername.Location = new System.Drawing.Point(40, 119);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(76, 62);
            this.pnlUsername.TabIndex = 38;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.DarkSalmon;
            this.txtTaiKhoan.Location = new System.Drawing.Point(131, 129);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(316, 45);
            this.txtTaiKhoan.TabIndex = 36;
            this.txtTaiKhoan.WordWrap = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogIn.Location = new System.Drawing.Point(122, 337);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(263, 59);
            this.btnLogIn.TabIndex = 40;
            this.btnLogIn.Text = "Đăng nhập";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 539);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.btnLogIn);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btnLogIn;
    }
}

