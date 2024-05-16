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
    public partial class DoUong : Form
    {
        public DoUong()
        {
            InitializeComponent();
        }

        private void DoUong_Load(object sender, EventArgs e)
        {
            hienThiDanhSachDoUong(dgvDoUong);
            hienThiDanhSachTenLoaiDoUong(cboLoaiDoUong);
        }
        public void hienThiDanhSachDoUong(DataGridView cv)
        {
            cv.DataSource = XuLyDMDoUong.layDanhSachDoUong();
        }

        public void hienThiDanhSachTenLoaiDoUong(ComboBox cv)
        {
            cv.DataSource = XuLyDMDoUong.layDanhSachTenLoaiDoUong();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            Model.douong abc = new Model.douong()
            {
                madouong = txtMaDoUong.Text,
                tendouong = txtTenDoUong.Text,
                maloaidouong = XuLyDMDoUong.layMaLoaiDoUong(cboLoaiDoUong.Text),
                mota = rtbMoTa.Text,
                tthai=1
            };
            int kq = XuLyDMDoUong.themDoUong(abc);
            if (kq > 0)
            {
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them That Bai");
            }
            hienThiDanhSachDoUong(dgvDoUong);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Model.douong abc = new Model.douong()
            {
                madouong = txtMaDoUong.Text,
                tendouong = txtTenDoUong.Text,
                maloaidouong = XuLyDMDoUong.layMaLoaiDoUong(cboLoaiDoUong.Text),
                mota = rtbMoTa.Text
            };
            int kq = XuLyDMDoUong.suaDoUong(abc);
            if (kq > 0)
            {
                MessageBox.Show("Sua thanh cong");
            }
            else
            {
                MessageBox.Show("Sua That Bai");
            }
            hienThiDanhSachDoUong(dgvDoUong);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaDoUong.Text;
            int kq = XuLyDMDoUong.xoaDoUong(ma);
            if (kq > 0)
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa That Bai");
            }
            hienThiDanhSachDoUong(dgvDoUong);
        }

        private void dgvDoUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDoUong.Text = dgvDoUong.CurrentRow.Cells[0].Value.ToString();
            cboLoaiDoUong.Text = XuLyDMDoUong.layTenLoaiDoUong(dgvDoUong.CurrentRow.Cells[1].Value.ToString());
            txtTenDoUong.Text = dgvDoUong.CurrentRow.Cells[2].Value.ToString();
            rtbMoTa.Text = dgvDoUong.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
