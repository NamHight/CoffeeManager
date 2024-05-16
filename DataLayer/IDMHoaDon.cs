using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDMHoaDon
    {
        List<View_HoaDonTong> layDanhSachHoaDon();
        List<string> layDanhSachDoUong();
        List<string> layDanhSachTenNhanVien();
        string layMaNhanVien(string name);
        string layMaDoUong(string name);
        int themHoaDon(hoadon x);
        int themCTHoaDon(cthoadon x);
        int suaHoaDon(hoadon x);
        int xoaHoaDon(string x);
    }
}
