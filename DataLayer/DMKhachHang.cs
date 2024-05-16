using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DMKhachHang : IDMKhachHang
    {
        public List<khachhang> layDanhSachKhachHang()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.khachhangs.Where(x => x.tthai == 1).ToList();
            }
        }
        public int themKhachHang(khachhang x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // them nhan vien vao database
                db.khachhangs.Add(x);

                // luu vao database sau do tra ve so dong anh huong
                int numRow = db.SaveChanges();

                if (numRow > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int suaKhachHang(khachhang x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fix = db.khachhangs.Find(x.makh);

                // Tien hanh sua
                fix.hoten = x.hoten;
                fix.dchi = x.dchi;
                fix.ngsinh = x.ngsinh;
                fix.sdt = x.sdt;
                fix.cccd = x.cccd;
                fix.gioitinh = x.gioitinh;

                // luu vao database sau do tra ve so dong anh huong
                int numRow = db.SaveChanges();

                if (numRow > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int xoaKhachHang(string x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fix = db.khachhangs.Find(x);

                // Tien hanh sua
                fix.tthai = 0;

                // luu vao database sau do tra ve so dong anh huong
                int numRow = db.SaveChanges();

                if (numRow > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
