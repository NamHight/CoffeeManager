using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DMHoaDon : IDMHoaDon
    {
        public List<View_HoaDonTong> layDanhSachHoaDon()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.View_HoaDonTong.ToList();
            }
        }

        public List<string> layDanhSachDoUong()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
               return db.douongs.Select(x=>x.tendouong).ToList();  
            }
        }

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
        public string layMaDoUong(string name)
        {
            string ma = "";
            using (QLCFEntities db = new QLCFEntities())
            {
                ma = db.douongs.Where(x => x.tendouong == name).FirstOrDefault().madouong;
            }
            return ma;
        }
        public int themHoaDon(hoadon x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // them nhan vien vao database
                db.hoadons.Add(x);

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
        public int themCTHoaDon(cthoadon x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // them nhan vien vao database
                db.cthoadons.Add(x);

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

        public int suaHoaDon(hoadon x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fix = db.hoadons.Find(x.manv);

                // Tien hanh sua
                fix.mahd = x.mahd;
                fix.manv = x.manv;
                fix.makh = x.makh;
                fix.ngaylap = x.ngaylap;
                

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

        public int xoaHoaDon(string x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fixNV = db.nhanviens.Find(x);

                // Tien hanh sua
                fixNV.tthai = 0;

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
