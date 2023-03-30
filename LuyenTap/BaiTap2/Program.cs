using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int luaChon = -1;
            QuanLyBanhKeo qlBanhKeo = new QuanLyBanhKeo();
            do
            {
                try
                {
                    Console.WriteLine("------------------ MENU ------------------");
                    Console.WriteLine("\t[1] Nhap thong tin");
                    Console.WriteLine("\t[2] Xuat thong tin");
                    Console.WriteLine("\t[3] Tim kiem gia cua banh keo");
                    Console.WriteLine("\t[4] Tim kiem ten banh keo");
                    Console.WriteLine("\t[5] Tim kiem han su dung");
                    Console.WriteLine("\t[0] Thoat");
                    Console.WriteLine("------------------------------------------");
                    Console.Write("Vui long nhap lua chon cua ban: ");
                    luaChon = Convert.ToInt32(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 1:
                            {
                                qlBanhKeo.NhapThongTin();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                qlBanhKeo.XuatThongTin();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 3:
                            {
                                qlBanhKeo.TimKiemGia();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 4:
                            {
                                qlBanhKeo.TimKiemTheoTen();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 5:
                            {
                                qlBanhKeo.TimKiemTheoHSD();
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
                            Console.WriteLine("Lua chon nhap khong hop le, xin hat kiem tra lai!!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch
                {

                    Console.WriteLine("\nDu lieu nhap khong duoc phep chap nhan!!!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (luaChon != 0);
        }
    }
}
