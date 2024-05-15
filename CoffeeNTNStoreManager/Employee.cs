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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            hienThiDanhSachNhanVien(dgvNhanVien);
            hienThiDanhCaLamViec(cboTenCa);
            hienThiDanhRole(cboRole);
        }

        public void hienThiDanhSachNhanVien(DataGridView cv)
        {
            cv.DataSource = XuLyDMNhanVien.layDanhSachNhanVien();
        }

        public void hienThiDanhCaLamViec(ComboBox cv)
        {
            cv.DataSource = XuLyDMNhanVien.layDanhSachCaLamViec();
        }

        public void hienThiDanhRole(ComboBox cv)
        {
            cv.DataSource = XuLyDMNhanVien.layDanhSachRole();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            cboTenCa.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.CurrentRow.Cells[4].Value.ToString());
            txtSDT.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtCCCD.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtUserName.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            txtPass.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
            dtpNgayLap.Value = Convert.ToDateTime(dgvNhanVien.CurrentRow.Cells[9].Value.ToString());
            var gioitinh = dgvNhanVien.CurrentRow.Cells[10].Value.ToString();
            if (gioitinh.ToLower() == "nam")
            {
               radNam.Checked = true;
            }
            else if(gioitinh.ToLower()=="nu")
            {
               radNu.Checked = true;
            }
             cboRole.Text = dgvNhanVien.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Model.nhanvien abc = new Model.nhanvien()
            {
                manv = txtMaNV.Text,
                maca = cboTenCa.Text,
                tennv = txtTenNV.Text,
                dchi = txtDiaChi.Text,
                ngsinh = dtpNgaySinh.Value,
                sdt = txtSDT.Text,
                cccd = txtCCCD.Text,
                username = txtUserName.Text,
                passwork = txtPass.Text,
                ngaylap = dtpNgayLap.Value,
                gioitinh = radNam.Checked ? "Nam" : "Nu",
                roller = int.Parse(cboRole.Text),
                tthai = 1
            };
            int kq = XuLyDMNhanVien.themNhanVien(abc);
            if(kq > 0)
            {
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them That Bai");
            }
            hienThiDanhSachNhanVien(dgvNhanVien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac muon sua thong tin nay",
               "Thong Bao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                string ma = txtMaNV.Text;
                int kq = XuLyDMNhanVien.xoaNhanVien(ma);
                if (kq > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                }
                else
                {
                    MessageBox.Show("Xoa That Bai");
                }
                hienThiDanhSachNhanVien(dgvNhanVien);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac muon sua thong tin nay",
                "Thong Bao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                Model.nhanvien abc = new Model.nhanvien()
                {
                    manv = txtMaNV.Text,
                    maca = cboTenCa.Text,
                    tennv = txtTenNV.Text,
                    dchi = txtDiaChi.Text,
                    ngsinh = dtpNgaySinh.Value,
                    sdt = txtSDT.Text,
                    cccd = txtCCCD.Text,
                    username = txtUserName.Text,
                    passwork = txtPass.Text,
                    ngaylap = dtpNgayLap.Value,
                    gioitinh = radNam.Checked ? "Nam" : "Nu",
                    roller = int.Parse(cboRole.Text),
                };
                int kq = XuLyDMNhanVien.suaNhanVien(abc);
                if (kq > 0)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua That Bai");
                }
                hienThiDanhSachNhanVien(dgvNhanVien);
            }
        }
    }
}
