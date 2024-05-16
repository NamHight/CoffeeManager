using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DMLogin : IDMLogin
    {
        public int kiemTraDangNhap(string user, string mk)
        {
            int kq = -100;
            using (QLCFEntities db = new QLCFEntities())
            {
                var username = db.nhanviens.Where(x => x.username == user);
                if(username.ToList().Count()> 0) // kiểm tra xem có dòng kết quả nào k
                {
                    if(username.FirstOrDefault().passwork == mk) // kiểm tra mật khẩu
                    {
                        if(username.FirstOrDefault().roller ==2) // kiểm tra vai trò
                        {
                            kq = 2; // dang nhap dung voi vai tro admin
                        }else if(username.FirstOrDefault().roller == 1)
                        {
                            kq = 1; // dang nhapj dung voi vai tro nhanvien
                        }
                    }
                    else
                    {
                        kq = 0; // dang nhap dung username, nhung sai mk
                    }
                }
                else
                {
                    kq = -1; // dang nhap sai username hay username chua ton tai
                }
            }
            return kq;
        }
    }
}
