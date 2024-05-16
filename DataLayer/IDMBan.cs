using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDMBan
    {
        List<ban> layDanhSachBan();
        List<int?> layTrangThaiBan();
        int themBan(ban x);
        int suaBan(ban x);
        int xoaBan(string x);
    }
}
