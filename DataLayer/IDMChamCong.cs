using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDMChamCong
    {
        List<string> layDanhSachTenNhanVien();
        string layMaNhanVien(string name);
        string layTenNhanVien(string ma);
        List<chamcong> layDanhSachChamCong();
        int themChamCong(chamcong x);
        int suaChamCong(chamcong x);
        int xoaChamCong(string x);

    }
}
