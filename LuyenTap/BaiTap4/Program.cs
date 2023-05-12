using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyMayTinh qlmt = new QuanLyMayTinh();
            qlmt.NhapMayTinh();
            qlmt.XuatMayTinh();
            qlmt.XoaDoiTuongTheoID();
            qlmt.XuatMayTinh();
            qlmt.TimTheoTenGanDung();
            List<MyDELL> mt = qlmt.XoaTenTrung();
            for (int i = 0; i < mt.Count; ++i)
            {
                Console.WriteLine();
                mt[i].XuatThongTin();
            }
            //MyDELL md = new MyDELL();
            //md.NhapThongTin();
            //md.XuatThongTin();
        }
    }
}
