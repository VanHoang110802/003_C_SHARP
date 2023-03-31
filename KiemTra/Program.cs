using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangtvph31092
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int luaChon;

            QuanLyPhim qlPhim = new QuanLyPhim();

            do
            {
                Console.WriteLine("------------------ MENU ------------------ ");
                Console.WriteLine("\t[1] Nhap");
                Console.WriteLine("\t[2] Xuat");
                Console.WriteLine("\t[3] Tim phim theo ma");
                Console.WriteLine("\t[4] Tim phim theo nam san xuat");
                Console.WriteLine("\t[0] Thoat");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Vui long nhap lua chon cua ban: ");
                luaChon = Convert.ToInt32(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        {
                            qlPhim.NhapThongTin();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            qlPhim.XuatThongTin();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            qlPhim.TimPhimTheoMa();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            qlPhim.TimPhimTheoSX();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        Console.WriteLine("Lua chon nhap khong hop le, xin hay kiem tra lai!!");
                        break;
                }
            } while (luaChon != 0);
        }
    }
}
