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
    public partial class Table : Form
    {
        private List<string> abc = new List<string>()
        {
            "empty", "no empty"
        };
        public Table()
        {
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            hienThiDanhSachBan(dgvBan);
            hienThiTrangThaiBan(cboTThai);
        }

        public void hienThiDanhSachBan(DataGridView cv)
        {
            cv.DataSource = XuLyDMBan.layDanhSachBan();
        }

        public void hienThiTrangThaiBan(ComboBox cv)
        {
            cv.DataSource = abc;
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
            int tthaiban = cboTThai.Text =="empty" ? 1 : 0;
            Model.ban abc = new Model.ban()
            {
                maban = txtMaBan.Text,
                tenban = txtTenBan.Text,
                controng = tthaiban,
                tthai = 1
            };
            int kq = XuLyDMBan.themBan(abc);
            if (kq > 0)
            {
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them That Bai");
            }
            hienThiDanhSachBan(dgvBan);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaBan.Text;
            int kq = XuLyDMBan.xoaBan(ma);
            if (kq > 0)
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa That Bai");
            }
            hienThiDanhSachBan(dgvBan);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Model.ban abc = new Model.ban()
            {
                maban = txtMaBan.Text,
                tenban = txtTenBan.Text,
                controng =  cboTThai.Text.ToLower() =="empty" ? 1 : 0,
                
            };
            int kq = XuLyDMBan.suaBan(abc);
            if (kq > 0)
            {
                MessageBox.Show("Sua thanh cong");
            }
            else
            {
                MessageBox.Show("Sua That Bai");
            }
            hienThiDanhSachBan(dgvBan);
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBan.Text = dgvBan.CurrentRow.Cells[0].Value.ToString();
            txtTenBan.Text = dgvBan.CurrentRow.Cells[1].Value.ToString();
            string status_Ban = dgvBan.CurrentRow.Cells[3].Value.ToString();
            if(status_Ban =="1") 
            { 
                cboTThai.Text = "empty"; 
            }else if(status_Ban == "0")
            {
                cboTThai.Text = "no empty";
            }
        }
    }
}
