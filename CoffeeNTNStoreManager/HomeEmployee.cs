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
    public partial class HomeEmployee : Form
    {
        public HomeEmployee()
        {
            InitializeComponent();
        }

        private void HomeEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Login>().Any())
            {
                // kiem tra neu k ton tai form login nao dang dc mo thi tien hanh mo form login
                Login abc = new Login();
                abc.Show();
                this.Hide();
            }
            else
            {// neeu co form login nao dang mo, nhung bi hidden thi show len lai
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
