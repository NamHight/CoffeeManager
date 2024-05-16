using DataLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class XuLyDMDoUong
    {
        static IDMDoUong dMDoUong;
        static XuLyDMDoUong()
        {
            dMDoUong = new DMDoUong();
        }
        public static List<douong> layDanhSachDoUong()
        {
            return dMDoUong.layDanhSachDoUong();
        }
        public static List<string> layDanhSachTenLoaiDoUong()
        {
            return dMDoUong.layDanhSachTenLoaiDoUong();
        }
        public static string layMaLoaiDoUong(string ten)
        {
            return dMDoUong.layMaLoaiDoUong(ten);
        }
        public static string layTenLoaiDoUong(string ma)
        {
            return dMDoUong.layTenLoaiDoUong(ma);
        }
        public static int themDoUong(douong x)
        {
            return dMDoUong.themDoUong(x);
        }
        public static int suaDoUong(douong x)
        {
            return dMDoUong.suaDoUong(x);
        }
        public static int xoaDoUong(string x)
        {
            return dMDoUong.xoaDoUong(x);
        }
    }
}
