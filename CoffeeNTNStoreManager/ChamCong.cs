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
    public partial class ChamCong : Form
    {
        public ChamCong()
        {
            InitializeComponent();
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            hienThiDanhSachChamCong(dgvChamCong);
            hienThiDanhSachNhanVien(cboTenNVien);
        }

        public void hienThiDanhSachNhanVien(ComboBox cb)
        {
            cb.DataSource = XuLyDMChamCong.layDanhSachTenNhanVien();
        }
        public void hienThiDanhSachChamCong(DataGridView cb)
        {
            cb.DataSource = XuLyDMChamCong.layDanhSachChamCong();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<HomeAdmin>())
            {
                form.Show();
                this.Close();
                return;
            }
        }

        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dgvChamCong.CurrentRow.Cells[1].Value.ToString();
            txtMaChamCong.Text = dgvChamCong.CurrentRow.Cells[0].Value.ToString();
            cboTenNVien.Text = XuLyDMChamCong.layTenNhanVien(ma);
            dtpNgayBDau.Value = Convert.ToDateTime(dgvChamCong.CurrentRow.Cells[2].Value.ToString());
            dtpNgayKThuc.Value = Convert.ToDateTime(dgvChamCong.CurrentRow.Cells[3].Value.ToString());
            txtSoNgayNghi.Text = dgvChamCong.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Model.chamcong abc = new Model.chamcong()
            {
                macc = txtMaChamCong.Text,
                manv = XuLyDMChamCong.layMaNhanVien(cboTenNVien.Text),
                tgianbd = dtpNgayBDau.Value,
                tgiankt = dtpNgayKThuc.Value,
                ngaynghi = int.Parse(txtSoNgayNghi.Text)
            };

            // Them cham cong vao model
            int kq = XuLyDMChamCong.themChamCong(abc);

            if (kq > 0)
            {
                MessageBox.Show("Them hoa don thanh cong");
            }
            else
            {
                MessageBox.Show("Them hoa don that bai");
            }
            hienThiDanhSachChamCong(dgvChamCong);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac muon sua thong tin nay",
              "Thong Bao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string ma = txtMaChamCong.Text;
                int kq = XuLyDMChamCong.xoaChamCong(ma);
                if (kq > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                }
                else
                {
                    MessageBox.Show("Xoa That Bai");
                }
                hienThiDanhSachChamCong(dgvChamCong);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac muon sua thong tin nay",
                "Thong Bao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Model.chamcong abc = new Model.chamcong()
                {
                    macc = txtMaChamCong.Text,
                    manv = XuLyDMChamCong.layMaNhanVien(cboTenNVien.Text),
                    tgianbd = dtpNgayBDau.Value,
                    tgiankt = dtpNgayKThuc.Value,
                    ngaynghi = int.Parse(txtSoNgayNghi.Text),
                };
                int kq = XuLyDMChamCong.suaChamCong(abc);
                if (kq > 0)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua That Bai");
                }
                hienThiDanhSachChamCong(dgvChamCong);
            }
        }
    }
}
