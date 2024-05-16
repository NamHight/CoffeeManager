using DataLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class XuLyDMKhachHang
    {
        static IDMKhachHang dMKhach;
        static XuLyDMKhachHang()
        {
            dMKhach = new DMKhachHang();
        }
        public static List<khachhang> layDanhSachKhachHang()
        {
            return dMKhach.layDanhSachKhachHang();
        }
        public static int  themKhachHang(khachhang x)
        {
            return dMKhach.themKhachHang(x);
        }

        public static int suaKhachHang(khachhang x)
        {
            return dMKhach.suaKhachHang(x);
        }

        public static int xoaKhachHang(string x)
        {               
            return dMKhach.xoaKhachHang(x);
        }
    }
}
