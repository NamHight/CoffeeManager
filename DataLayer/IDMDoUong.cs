using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDMDoUong
    {
        List<douong> layDanhSachDoUong();
        List<string> layDanhSachTenLoaiDoUong();
        string layMaLoaiDoUong(string ten);
        string layTenLoaiDoUong(string ma);
        int themDoUong(douong x);
        int suaDoUong(douong x);
        int xoaDoUong(string x);
    }
}
