using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
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
            QuanLySach qlSach = new QuanLySach();
            do
            {
                try
                {
                    Console.WriteLine("------------------ MENU --------------------");
                    Console.WriteLine("\t[1] Nhap thong tin");
                    Console.WriteLine("\t[2] Xuat thong tin");
                    Console.WriteLine("\t[3] Tim kiem ten sach");
                    Console.WriteLine("\t[4] Tim kiem ten tac gia");
                    Console.WriteLine("\t[5] Tim kiem so luong sach");
                    Console.WriteLine("\t[6] Sap xep thong tin theo ID");
                    Console.WriteLine("\t[0] Thoat");
                    Console.WriteLine("--------------------------------------------");
                    Console.Write("Vui long nhap lua chon cua ban: ");
                    luaChon = Convert.ToInt32(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 1:
                            {
                                qlSach.NhapThongTin();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                qlSach.XuatThongTin();
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
                        case 6:
                            {
                                qlSach.SapXepSach();
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
