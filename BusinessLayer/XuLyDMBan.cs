using DataLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class XuLyDMBan
    {
        static IDMBan dMBan ;

        static XuLyDMBan()
        {
            dMBan = new DMBan();
        }
        public static List<ban> layDanhSachBan()
        {
          return dMBan.layDanhSachBan();
        }
        public static List<int?> layTrangThaiBan()
        {
            return dMBan.layTrangThaiBan();
        }
        public static int themBan(ban x)
        {
            return dMBan.themBan(x);
        }
        public static int suaBan(ban x)
        {
            return dMBan.suaBan(x);
        }
        public static int xoaBan(string x)
        {
            return dMBan.xoaBan(x);
        }
    }
}
