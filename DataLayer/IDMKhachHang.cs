using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDMKhachHang
    {
        List<khachhang> layDanhSachKhachHang(); 
        int themKhachHang(khachhang x);
        int suaKhachHang(khachhang x);
        int xoaKhachHang(string x);
    }
}
