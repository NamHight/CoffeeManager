using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DMNhanVien : IDMNhanVien
    {
        public List<nhanvien> layDanhSachNhanVien()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.nhanviens.Where(x => x.tthai==1).ToList();
            }
        }

        public List<string> layDanhSachCaLamViec()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                var maca = db.calamviecs.Select(x => x.maca).ToList();
                // lấy cột maca và lọc trùng
                return maca;
                
            }
        }

        public List<int?> layDanhSachRole() // int? để đảm bảo lấy cả giá trị null
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                var role = db.nhanviens.Select(x => x.roller).Distinct();
                // lấy cột roller và lọc trùng
                return role.ToList();   
            }
        }

        public int themNhanVien(nhanvien x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // them nhan vien vao database
                db.nhanviens.Add(x);

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

        public int suaNhanVien(nhanvien x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fixNV = db.nhanviens.Find(x.manv);

                // Tien hanh sua
                fixNV.tennv = x.tennv;
                fixNV.maca = x.maca;
                fixNV.dchi = x.dchi;
                fixNV.ngsinh = x.ngsinh;
                fixNV.sdt = x.sdt;
                fixNV.cccd = x.cccd;
                fixNV.cccd = x.cccd;
                fixNV.username = x.username;
                fixNV.passwork = x.passwork;
                fixNV.ngaylap = x.ngaylap;
                fixNV.gioitinh = x.gioitinh;
                fixNV.roller = x.roller;

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

        public int xoaNhanVien(string x)
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
