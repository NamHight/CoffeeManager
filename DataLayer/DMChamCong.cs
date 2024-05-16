using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DMChamCong : IDMChamCong
    {
        public List<string> layDanhSachTenNhanVien()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.nhanviens.Select(x => x.tennv).ToList();
            }
        }
        public string layMaNhanVien(string name)
        {
            string ma = "";
            using (QLCFEntities db = new QLCFEntities())
            {
                ma = db.nhanviens.Where(x => x.tennv == name).FirstOrDefault().manv;
            }
            return ma;
        }
        public List<chamcong> layDanhSachChamCong()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.chamcongs.Where(x=> x.tthai==1).ToList();
            }
        }

        public string layTenNhanVien(string ma)
        {
            string name = "";
            using (QLCFEntities db = new QLCFEntities())
            {
                name = db.nhanviens.Where(x => x.manv == ma).FirstOrDefault().tennv;
            }
            return name;
        }
        public int themChamCong(chamcong x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // them nhan vien vao database
                db.chamcongs.Add(x);

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
        public int suaChamCong(chamcong x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fix = db.chamcongs.Find(x.macc);

                // Tien hanh sua
                fix.manv = x.manv;
                fix.tgianbd = x.tgianbd;
                fix.tgiankt = x.tgiankt;
                fix.ngaynghi = x.ngaynghi;
               
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
        public int xoaChamCong(string x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fix = db.chamcongs.Find(x);

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
