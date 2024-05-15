using DataLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class XuLyDMNhanVien
    {
        static IDMNhanVien dmNhanVien;
        static XuLyDMNhanVien()
        {
            dmNhanVien = new DMNhanVien();
        }
        public static List<nhanvien> layDanhSachNhanVien()
        {
            return dmNhanVien.layDanhSachNhanVien();
        }

        public static List<string> layDanhSachCaLamViec()
        {
            return dmNhanVien.layDanhSachCaLamViec();
        }

        public static List<int?> layDanhSachRole()
        {
            return dmNhanVien.layDanhSachRole();
        }

        public static int themNhanVien(nhanvien x)
        {
            return dmNhanVien.themNhanVien(x);
        }

        public static int suaNhanVien(nhanvien x)
        {
            return dmNhanVien.suaNhanVien(x);
        }

        public static int xoaNhanVien(string x)
        {
            return dmNhanVien.xoaNhanVien(x);
        }
    }
}
