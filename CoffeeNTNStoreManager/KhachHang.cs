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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            hienThiDanhSachKhachHang(dgvKhachHang);
        }
        public void hienThiDanhSachKhachHang(DataGridView cv)
        {
            cv.DataSource = XuLyDMKhachHang.layDanhSachKhachHang();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Login.statusLogin == 2)
            {
                foreach (var form in Application.OpenForms.OfType<HomeAdmin>())
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }
            else if (Login.statusLogin == 1)
            {
                foreach (var form in Application.OpenForms.OfType<HomeEmployee>())
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Model.khachhang abc = new Model.khachhang()
            {
                makh = txtMaKH.Text,
                hoten = txtTenKH.Text,
                dchi = txtDiaChi.Text,
                ngsinh = dtpNgaySinh.Value,
                sdt = txtSDT.Text,
                cccd = txtCCCD.Text,
                gioitinh = radNam.Checked ? "Nam" : "Nu",
                tthai = 1
            };
            int kq = XuLyDMKhachHang.themKhachHang(abc);
            if (kq > 0)
            {
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them That Bai");
            }
            hienThiDanhSachKhachHang(dgvKhachHang);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            int kq = XuLyDMKhachHang.xoaKhachHang(ma);
            if (kq > 0)
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa That Bai");
            }
            hienThiDanhSachKhachHang(dgvKhachHang);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Model.khachhang abc = new Model.khachhang()
            {
                makh = txtMaKH.Text,
                hoten = txtTenKH.Text,
                dchi = txtDiaChi.Text,
                ngsinh = dtpNgaySinh.Value,
                sdt = txtSDT.Text,
                cccd = txtCCCD.Text,
                gioitinh = radNam.Checked ? "Nam" : "Nu",
            };
            int kq = XuLyDMKhachHang.suaKhachHang(abc);
            if (kq > 0)
            {
                MessageBox.Show("Sua thanh cong");
            }
            else
            {
                MessageBox.Show("Sua That Bai");
            }
            hienThiDanhSachKhachHang(dgvKhachHang);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvKhachHang.CurrentRow.Cells[3].Value.ToString());
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtCCCD.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
            string gt = dgvKhachHang.CurrentRow.Cells[6].Value.ToString().ToLower();
            if(gt == "nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
        }
    }
}
