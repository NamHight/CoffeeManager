using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDMCaLamViec
    {
        List<calamviec> layDanhSachCaLamViec();
        int themCaLamViec(calamviec x);
        int suaCaLamViec(calamviec x);
        int xoaCaLamViec(string x);
    }
}
