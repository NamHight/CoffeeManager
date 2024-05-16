using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DMDoUong : IDMDoUong
    {
        public List<douong> layDanhSachDoUong()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.douongs.Where(x => x.tthai == 1).ToList();
            }
        }
        public List<string> layDanhSachTenLoaiDoUong()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.loaidouongs.Select(x => x.tenloai).ToList();
            }
        }
        public string layMaLoaiDoUong(string ten)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.loaidouongs.Where(x => x.tenloai == ten).FirstOrDefault().maloai;
            }
        }
        public string layTenLoaiDoUong(string ma)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.loaidouongs.Where(x => x.maloai == ma).FirstOrDefault().tenloai;
            }
        }
        public int themDoUong(douong x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // them nhan vien vao database
                db.douongs.Add(x);

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
        public int suaDoUong(douong x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fix = db.douongs.Find(x.madouong);

                // Tien hanh sua
                fix.tendouong = x.tendouong;
                fix.madouong = x.madouong;
                fix.mota = x.mota;

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
        public int xoaDoUong(string x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fix = db.douongs.Find(x);

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
