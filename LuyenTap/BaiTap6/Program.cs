using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyKeoBanh qlKeoBanh = new QuanLyKeoBanh();
            qlKeoBanh.NhapBanhKeo();
            qlKeoBanh.XuatBanhKeo();
            qlKeoBanh.XuatKeoBanhConHan();
            qlKeoBanh.SapXepTheoSoLuong();
            qlKeoBanh.SapXepTheoTenKeoBanh();
            qlKeoBanh.XoaBanhKeoTheoCode();
        }
    }
}
