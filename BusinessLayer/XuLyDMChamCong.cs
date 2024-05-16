using DataLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class XuLyDMChamCong
    {
        static IDMChamCong dMChamCong;
        static XuLyDMChamCong()
        {
            dMChamCong = new DMChamCong();
        }

        public static List<string> layDanhSachTenNhanVien()
        {
            return dMChamCong.layDanhSachTenNhanVien();
        }

        public static string layMaNhanVien(string name)
        {
            return dMChamCong.layMaNhanVien(name);
        }

        public static List<chamcong> layDanhSachChamCong()
        {
            return dMChamCong.layDanhSachChamCong();
        }
        public static string layTenNhanVien(string ma)
        {
            return dMChamCong.layTenNhanVien(ma);
        }

        public static int themChamCong(chamcong x)
        {
            return dMChamCong.themChamCong(x);
        }
        public static int suaChamCong(chamcong x)
        {
            return dMChamCong.suaChamCong(x);
        }
        public static int xoaChamCong(string x)
        {
            return dMChamCong.xoaChamCong(x);
        }
    }
}
