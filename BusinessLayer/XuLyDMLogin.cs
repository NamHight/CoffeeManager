using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class XuLyDMLogin
    {
        static IDMLogin dMLogin;

        static XuLyDMLogin ()
        {
            dMLogin = new DMLogin ();
        }

        public static int kiemTraDangNhap(string user, string mk)
        {
            return dMLogin.kiemTraDangNhap (user, mk);
        }
    }
}
