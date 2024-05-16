using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DMBan : IDMBan
    {
        public List<ban> layDanhSachBan()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.bans.Where(x => x.tthai == 1).ToList();
            }
        }
        public List<int?> layTrangThaiBan()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.bans.Select(x=>x.controng).Distinct().ToList();
            }
        }
        public int themBan(ban x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // them nhan vien vao database
                db.bans.Add(x);

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
        public int suaBan(ban x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fix = db.bans.Find(x.maban);

                // Tien hanh sua
                fix.tenban = x.tenban;
                fix.controng = x.controng;

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
        public int xoaBan(string x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fix = db.bans.Find(x);

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
