using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeNTNStoreManager
{
    public partial class Login : Form
    {
        public static int statusLogin = -2;
        

        private HomeAdmin formAdmin;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string passwork = txtMatKhau.Text;
            statusLogin = XuLyDMLogin.kiemTraDangNhap(username, passwork);
            if(statusLogin == -1)
            {
                MessageBox.Show("Tai khoan da nhap chua ton tai, vui long kiem tra lai");
            }else if(statusLogin == 0)
            {
                MessageBox.Show("Sai mat khau vui long kiem tra lai");
            }else if(statusLogin == 1)
            {
                HomeEmployee homeEmployee = new HomeEmployee();
                homeEmployee.Show(); // show dùng để triển khai các trang chính,
                // showdialog để triển khai trang phụ
                this.Hide(); 

            }
            else if(statusLogin == 2)
            {
                formAdmin = new HomeAdmin();
                formAdmin.Show();
                this.Hide();// show trang admin thì ẩn trang login
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
