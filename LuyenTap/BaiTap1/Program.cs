using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            QuanLyNYC qlNYC = new QuanLyNYC();

            int luaChon = -1;
            do
            {
                Console.WriteLine("--------------------- MENU ----------------------");
                Console.WriteLine("\t[1]. Nhap thong tin nguoi yeu cu");
                Console.WriteLine("\t[2]. Xuat thong tin nguoi yeu cu");
                Console.WriteLine("\t[3]. Tim kiem id nguoi yeu cu");
                Console.WriteLine("\t[4]. Tim kiem chieu cao nguoi yeu cu");
                Console.WriteLine("\t[5]. Tim kiem cang nang nguoi yeu cu");
                Console.WriteLine("\t[0]. Thoat");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Vui long nhap lua chon cua ban: ");

                try
                {
                    luaChon = Convert.ToInt32(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 1:
                            {
                                qlNYC.NhapThongTin();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                qlNYC.XuatThongTin();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                        case 3:
                            {
                                
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                        case 4:
                            {
                                
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                        case 5:
                            {
                                
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
                            Console.WriteLine("Lua chon nhap khong hop le, xin hay kiem tra lai!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Lua chon nhap khong duoc phep ho tro!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (luaChon != 0);
        }
    }
}
