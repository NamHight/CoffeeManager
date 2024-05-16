using DataLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class XuLyDMHoaDon
    {
        static IDMHoaDon dMHoaDon;

        static XuLyDMHoaDon()
        {
            dMHoaDon = new DMHoaDon();
        }

        public static List<View_HoaDonTong> layDanhSachHoaDon()
        {
            return dMHoaDon.layDanhSachHoaDon();
        }

        public static List<string> layDanhSachDoUong()
        {
            return dMHoaDon.layDanhSachDoUong();
        }

        public static List<string> layDanhSachTenNhanVien()
        {
            return dMHoaDon.layDanhSachTenNhanVien();
        }

        public static string layMaNhanVien(string name)
        {
            return dMHoaDon.layMaNhanVien(name);
        }

        public static string layMaDoUong(string name)
        {
            return dMHoaDon.layMaDoUong(name);
        }

        public static int themHoaDon(hoadon x)
        {
            return dMHoaDon.themHoaDon(x);
        }
        public static int themCTHoaDon(cthoadon x)
        {
            return dMHoaDon.themCTHoaDon(x);
        }
    }
}
