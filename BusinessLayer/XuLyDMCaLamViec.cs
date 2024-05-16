using DataLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class XuLyDMCaLamViec 
    {
        static IDMCaLamViec dMcalamviec;
        static XuLyDMCaLamViec()
        {
            dMcalamviec = new DMCaLamViec();
        }
        public static List<calamviec> layDanhSachCaLamViec()
        {
            return dMcalamviec.layDanhSachCaLamViec();
        }
        public static int themCaLamViec(calamviec x)
        {
            return dMcalamviec.themCaLamViec(x);
        }
        public static int suaCaLamViec(calamviec x)
        {
            return dMcalamviec.suaCaLamViec(x);
        }
        public static int xoaCaLamViec(string x)
        {
            return dMcalamviec.xoaCaLamViec(x);
        }
    }
}
