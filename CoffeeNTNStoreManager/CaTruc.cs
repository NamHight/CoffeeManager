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
    public partial class CaTruc : Form
    {
        public CaTruc()
        {
            InitializeComponent();
        }

        private void CaTruc_Load(object sender, EventArgs e)
        {
            hienThiDanhSachCaLamViec(dgvCaTruc);
        }
        public void hienThiDanhSachCaLamViec(DataGridView cb)
        {
            cb.DataSource = XuLyDMCaLamViec.layDanhSachCaLamViec();
        }
        private void dgvCaTruc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCa.Text = dgvCaTruc.CurrentRow.Cells[0].Value.ToString();
            txtTenCa.Text = dgvCaTruc.CurrentRow.Cells[1].Value.ToString();
            txtNgayBatDau.Text = dgvCaTruc.CurrentRow.Cells[2].Value.ToString();
            txtNgayKetThuc.Text = dgvCaTruc.CurrentRow.Cells[3].Value.ToString();
           
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Model.calamviec abc = new Model.calamviec()
            {
                maca = txtMaCa.Text,
                tenca = txtTenCa.Text,
                tgianbd = TimeSpan.Parse(txtNgayBatDau.Text),
                tgiankt = TimeSpan.Parse(txtNgayKetThuc.Text),
            };

            // Them cham cong vao model
            int kq = XuLyDMCaLamViec.themCaLamViec(abc);

            if (kq > 0)
            {
                MessageBox.Show("Them hoa don thanh cong");
            }
            else
            {
                MessageBox.Show("Them hoa don that bai");
            }
            hienThiDanhSachCaLamViec(dgvCaTruc);
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac muon sua thong tin nay",
              "Thong Bao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string ma = txtMaCa.Text;
                int kq = XuLyDMCaLamViec.xoaCaLamViec(ma);
                if (kq > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                }
                else
                {
                    MessageBox.Show("Xoa That Bai");
                }
                hienThiDanhSachCaLamViec(dgvCaTruc);
            }
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac muon sua thong tin nay",
               "Thong Bao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Model.calamviec abc = new Model.calamviec()
                {
                    maca = txtMaCa.Text,
                    tenca = txtTenCa.Text,
                    tgianbd = TimeSpan.Parse(txtNgayBatDau.Text),
                    tgiankt = TimeSpan.Parse(txtNgayKetThuc.Text),
                };
                int kq = XuLyDMCaLamViec.suaCaLamViec(abc);
                if (kq > 0)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua That Bai");
                }
                hienThiDanhSachCaLamViec(dgvCaTruc);
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (Login.statusLogin == 2) // neu dang nhap bang admin
            {
                foreach (var form in Application.OpenForms.OfType<HomeAdmin>())
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }
            else if (Login.statusLogin == 1) // neu dang nhap bang nhanvien
            {
                foreach (var form in Application.OpenForms.OfType<HomeEmployee>())
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }
        }
    }
}
