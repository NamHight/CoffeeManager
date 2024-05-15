using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDMNhanVien
    {
        List<nhanvien> layDanhSachNhanVien();
        List<string> layDanhSachCaLamViec();
        List<int?> layDanhSachRole();
        int themNhanVien(nhanvien x);
        int suaNhanVien(nhanvien x);
        int xoaNhanVien(string x);

    }
}
