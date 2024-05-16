using BusinessLayer;
using Model;
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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide(); // ẩn giao diện quản lý
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
          
        }

        private void btnLogOut_Click(object sender, EventArgs e) 
        {
            // duyet vong lap để mở form login đang hide lên
            if (!Application.OpenForms.OfType<Login>().Any())
            {
                Login abc = new Login();
                abc.Show();
                this.Hide();
            }
            else
            {
                foreach (var form in Application.OpenForms.OfType<Login>())
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Show();
            this.Hide();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            ChamCong x = new ChamCong();    
            x.Show();
            this.Hide();
        }

        private void btnCaLamViec_Click(object sender, EventArgs e)
        {
            CaTruc x = new CaTruc();
            x.Show();
            this.Hide();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang x = new KhachHang();
            x.Show();
            this.Hide();
        }

        private void btnDoUong_Click(object sender, EventArgs e)
        {
            DoUong x = new DoUong();
            x.Show();
            this.Hide();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            Table x = new Table();
            x.Show();
            this.Hide();
        }
    }
}
