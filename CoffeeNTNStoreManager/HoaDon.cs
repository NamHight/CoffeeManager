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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Login.statusLogin ==2)
            {
                foreach (var form in Application.OpenForms.OfType<HomeAdmin>())
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }
            else if(Login.statusLogin == 1)
            {
                foreach (var form in Application.OpenForms.OfType<HomeEmployee>())
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            hienThiDanhSachHoaDon(dgvBill);
            hienThiDanhSachDouong(cboDoUong);
            hienThiDanhSachTenNV(cboTenNV);
        }

        public void hienThiDanhSachHoaDon(DataGridView vc)
        {
            vc.DataSource = XuLyDMHoaDon.layDanhSachHoaDon();
        }

        public void hienThiDanhSachDouong(ComboBox cb )
        {
            cb.DataSource = XuLyDMHoaDon.layDanhSachDoUong();
        }

        public void hienThiDanhSachTenNV(ComboBox cb)
        {
            cb.DataSource = XuLyDMHoaDon.layDanhSachTenNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            Model.hoadon a = new Model.hoadon();
            a.mahd = txtMaHDon.Text;
            a.ngaylap = dtpNgayLap.Value;
            a.manv = XuLyDMHoaDon.layMaNhanVien(cboTenNV.Text);

            int kq1= XuLyDMHoaDon.themHoaDon(a);

            Model.cthoadon b = new Model.cthoadon();    
            b.mahd = txtMaHDon.Text;
            b.madouong = XuLyDMHoaDon.layMaDoUong(cboDoUong.Text);
            b.soluong = int.Parse(txtSoLuong.Text);
            b.dongia = int.Parse(txtDonGia.Text);

            int kq2 = XuLyDMHoaDon.themCTHoaDon(b);

            if(kq1 >0 && kq2 > 0)
            {
                MessageBox.Show("Them hoa don thanh cong");
            }
            else
            {
                MessageBox.Show("Them hoa don that bai");
            }
            hienThiDanhSachHoaDon(dgvBill);
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDon.Text = dgvBill.CurrentRow.Cells[0].Value.ToString();
            cboTenNV.Text = dgvBill.CurrentRow.Cells[1].Value.ToString();
            txtKHang.Text = dgvBill.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dgvBill.CurrentRow.Cells[3].Value.ToString();
            dtpNgayLap.Value = Convert.ToDateTime(dgvBill.CurrentRow.Cells[4].Value.ToString());
            cboDoUong.Text = dgvBill.CurrentRow.Cells[5].Value.ToString();
            txtSoLuong .Text = dgvBill.CurrentRow.Cells[6].Value.ToString();
            lblTongTien.Text = dgvBill.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
