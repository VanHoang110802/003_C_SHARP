using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangtvph31092
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SERVICE ser = new SERVICE();
            int luaChon;
            do
            {
                Console.WriteLine("------------------ MENU --------------------");
                Console.WriteLine("1/ Nhap thong tin");
                Console.WriteLine("2/ Xuat thong tin");
                Console.WriteLine("3/ Tim nhan vien theo luong");
                Console.WriteLine("4/ Xuat 5 nhan vien thu nhap cao nhat");
                Console.WriteLine("0/ Thoat");
                Console.WriteLine("--------------------------------------------");
                Console.Write("Vui long nhap lua chon: ");
                luaChon = Convert.ToInt32(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        ser.NhapNhanVien();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        ser.XuatNhanVien();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        ser.TimCacNhanVienTheoLuong();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        ser.XuatNhanVienThuNhap();
                        break;

                    case 0:
                        Environment.ExitCode = 0;
                        break;
                    default:
                        Console.WriteLine("Lua chon nhap khong hop, xin hay kiem tra lai!!");
                        break;
                }
            } while (luaChon != 0);
        }
    }
}
