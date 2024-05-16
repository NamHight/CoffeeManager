using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DMCaLamViec :IDMCaLamViec
    {
        public List<calamviec> layDanhSachCaLamViec()
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                return db.calamviecs.Where(x => x.tthai==1).ToList();
            }
        }
        public int themCaLamViec(calamviec x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // them nhan vien vao database
                db.calamviecs.Add(x);

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
        public int suaCaLamViec(calamviec x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fix = db.calamviecs.Find(x.maca);

                // Tien hanh sua
                fix.tenca = x.tenca;
                fix.tgianbd = x.tgianbd;
                fix.tgiankt = x.tgiankt; 

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
        public int xoaCaLamViec(string x)
        {
            using (QLCFEntities db = new QLCFEntities())
            {
                // tim nhan vien co ma can sua
                var fix = db.calamviecs.Find(x);

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
