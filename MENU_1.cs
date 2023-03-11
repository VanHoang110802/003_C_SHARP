/*
*****************************************                   Ho ten:     Truong Van Hoang
*                  MENU                 *                   Mssv:       PH31092
*    [0]: Thoat                         *                   Giang vien: Nguyen Khanh Huyen (huyennk6)
*    [1]: Nhap/xuat thong tin xe may    *
*    [2]: Tim min/max                   *
*****************************************
Vui long nhap lua chon cua ban:

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_All
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int lc;
            bool checkVongLap = true;
            do
            {
                Console.SetCursorPosition(60, 0);
                Console.Write("Ho ten:     Truong Van Hoang");
                Console.SetCursorPosition(60, 1);
                Console.Write("Mssv:       PH31092");
                Console.SetCursorPosition(60, 2);
                Console.Write("Giang vien: Nguyen Khanh Huyen (huyennk6)");
                for (int i = 0; i < 41; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write($"*");
                }
                Console.SetCursorPosition(19, 1); Console.Write("MENU");
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("[0]: Thoat");
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("[1]: Nhap/xuat thong tin xe may");
                Console.SetCursorPosition(5, 4);
                Console.WriteLine("[2]: Tim min/max");
                for (int i = 1; i < 5; i++)
                {
                    Console.SetCursorPosition(0, i); Console.Write("*");
                }
                for (int i = 1; i < 5; i++)
                {
                    Console.SetCursorPosition(40, i); Console.Write("*");
                }
                Console.WriteLine();
                for (int i = 0; i < 41; i++)
                {
                    Console.SetCursorPosition(i, 5);
                    Console.Write("*");
                }
                Console.Write("\nVui long nhap lua chon cua ban: ");

                try
                {
                    lc = Convert.ToInt32(Console.ReadLine());
                    switch (lc)
                    {
                        case 0:
                            {
                                checkVongLap = false;
                                break;
                            }

                        case 1:
                            {
                                int id;
                                string hang;
                                double gia;
                                int phanKhoi;
                                bool isVietNam;

                                Console.Clear();

                                Console.SetCursorPosition(60, 0);
                                Console.Write("Ho ten:     Truong Van Hoang");
                                Console.SetCursorPosition(60, 1);
                                Console.Write("Mssv:       PH31092");
                                Console.SetCursorPosition(60, 2);
                                Console.Write("Giang vien: Nguyen Khanh Huyen (huyennk6)");

                                for (int i = 0; i < 56; i++)
                                {
                                    Console.SetCursorPosition(i, 0);
                                    Console.Write($"*");
                                }

                                Console.SetCursorPosition(24, 2);
                                Console.Write("BTVN");
                                Console.SetCursorPosition(14, 3);
                                Console.WriteLine("Nhập và xuất thông tin Xe Máy");

                                for (int i = 1; i < 5; i++)
                                {
                                    Console.SetCursorPosition(0, i); Console.Write("*");
                                }

                                for (int i = 1; i < 5; i++)
                                {
                                    Console.SetCursorPosition(55, i); Console.Write("*");
                                }
                                for (int i = 0; i < 56; i++)
                                {
                                    Console.SetCursorPosition(i, 5);
                                    Console.Write($"*");
                                }
                                Console.ReadKey();
                                Console.Clear();

                                Console.SetCursorPosition(60, 0);
                                Console.Write("Ho ten:     Truong Van Hoang");
                                Console.SetCursorPosition(60, 1);
                                Console.Write("Mssv:       PH31092");
                                Console.SetCursorPosition(60, 2);
                                Console.Write("Giang vien: Nguyen Khanh Huyen (huyennk6)");

                                for (int i = 0; i < 57; i++)
                                {
                                    Console.SetCursorPosition(i, 0);
                                    Console.Write("*");
                                }

                                for (int i = 1; i < 10; i++)
                                {
                                    Console.SetCursorPosition(0, i); Console.Write("*");
                                }

                                for (int i = 0; i < 57; i++)
                                {
                                    Console.SetCursorPosition(i, 9);
                                    Console.Write($"*");
                                }

                                Console.SetCursorPosition(56, 1); Console.WriteLine($"*");
                                Console.WriteLine($"*"); Console.SetCursorPosition(56, 2); Console.WriteLine($"*");
                                Console.WriteLine($"* Vui lòng nhập thông tin:");
                                Console.WriteLine($"*"); Console.SetCursorPosition(56, 3); Console.WriteLine($"*");
                                Console.Write($"* ID: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"*"); Console.SetCursorPosition(56, 4); Console.WriteLine($"*");
                                Console.Write($"* Hàng: ");
                                hang = Console.ReadLine();
                                Console.WriteLine($"*"); Console.SetCursorPosition(56, 5); Console.WriteLine($"*");
                                Console.Write($"* Giá: ");
                                gia = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"*"); Console.SetCursorPosition(56, 6); Console.WriteLine($"*");
                                Console.Write($"* Phân khối: ");
                                phanKhoi = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"*"); Console.SetCursorPosition(56, 7); Console.WriteLine($"*");
                                Console.Write($"* Xe là hãng của nước(true - VN, false - NN): ");
                                isVietNam = Convert.ToBoolean(Console.ReadLine());
                                Console.WriteLine($"*"); Console.SetCursorPosition(56, 8); Console.WriteLine($"*");

                                Console.ReadKey();
                                Console.Clear();

                                Console.SetCursorPosition(60, 0);
                                Console.Write("Ho ten:     Truong Van Hoang");
                                Console.SetCursorPosition(60, 1);
                                Console.Write("Mssv:       PH31092");
                                Console.SetCursorPosition(60, 2);
                                Console.Write("Giang vien: Nguyen Khanh Huyen (huyennk6)");

                                for (int i = 0; i < 56; i++)
                                {
                                    Console.SetCursorPosition(i, 0);
                                    Console.Write("*");
                                }

                                for (int i = 1; i < 10; i++)
                                {
                                    Console.SetCursorPosition(0, i); Console.Write("*");
                                }

                                for (int i = 1; i < 10; i++)
                                {
                                    Console.SetCursorPosition(55, i); Console.Write("*");
                                }

                                for (int i = 0; i < 56; i++)
                                {
                                    Console.SetCursorPosition(i, 9);
                                    Console.Write("*");
                                }

                                Console.SetCursorPosition(20, 2); Console.WriteLine("Thông tin");

                                Console.SetCursorPosition(2, 3); Console.Write($"Tên id: {id}");
                                Console.SetCursorPosition(2, 4); Console.Write($"Hàng: {hang}");
                                Console.SetCursorPosition(2, 5); Console.Write($"Giá: {gia}");
                                Console.SetCursorPosition(2, 6); Console.Write($"Phân khối: {phanKhoi}");
                                Console.SetCursorPosition(2, 7);
                                Console.Write($"Xe là hãng của nước: {(isVietNam ? "VN" : "NN")}");

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                int Min = 0, Max = 0, dem = 0;
                                bool CHECK = true;



                                do
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(60, 0);
                                    Console.Write("Ho ten:     Truong Van Hoang");
                                    Console.SetCursorPosition(60, 1);
                                    Console.Write("Mssv:       PH31092");
                                    Console.SetCursorPosition(60, 2);
                                    Console.Write("Giang vien: Nguyen Khanh Huyen (huyennk6)");

                                    for (int i = 0; i < 41; i++)
                                    {
                                        Console.SetCursorPosition(i, 0);
                                        Console.Write("*");
                                    }

                                    for (int i = 1; i < 5; i++)
                                    {
                                        Console.SetCursorPosition(0, i); Console.Write("*");
                                    }
                                    for (int i = 1; i < 5; i++)
                                    {
                                        Console.SetCursorPosition(40, i); Console.Write("*");
                                    }
                                    Console.WriteLine();
                                    for (int i = 0; i < 41; i++)
                                    {
                                        Console.SetCursorPosition(i, 5);
                                        Console.Write("*");
                                    }

                                    try
                                    {
                                        Console.SetCursorPosition(2, 1);
                                        Console.Write("Nhap vao Min = ");
                                        Min = Convert.ToInt32(Console.ReadLine());

                                        if (Min < 0)
                                        {
                                            Console.SetCursorPosition(2, 10);
                                            Console.WriteLine("Min nhap khong hop le!");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else CHECK = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Du lieu nhap khong hop le!");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                } while (CHECK);
                                CHECK = true;

                                do
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(60, 0);
                                    Console.Write("Ho ten:     Truong Van Hoang");
                                    Console.SetCursorPosition(60, 1);
                                    Console.Write("Mssv:       PH31092");
                                    Console.SetCursorPosition(60, 2);
                                    Console.Write("Giang vien: Nguyen Khanh Huyen (huyennk6)");

                                    for (int i = 0; i < 41; i++)
                                    {
                                        Console.SetCursorPosition(i, 0);
                                        Console.Write("*");
                                    }

                                    for (int i = 1; i < 5; i++)
                                    {
                                        Console.SetCursorPosition(0, i); Console.Write("*");
                                    }
                                    for (int i = 1; i < 5; i++)
                                    {
                                        Console.SetCursorPosition(40, i); Console.Write("*");
                                    }
                                    Console.WriteLine();
                                    for (int i = 0; i < 41; i++)
                                    {
                                        Console.SetCursorPosition(i, 5);
                                        Console.Write("*");
                                    }

                                    Console.SetCursorPosition(2, 1);
                                    Console.Write($"Nhap vao Min = {Min}");
                                    try
                                    {
                                        Console.SetCursorPosition(2, 3);
                                        Console.Write("Nhap vao Max = ");
                                        Max = Convert.ToInt32(Console.ReadLine());

                                        if (Max < 0 || Max < Min)
                                        {
                                            Console.SetCursorPosition(2, 10);
                                            Console.WriteLine("MAX nhap khong hop le!");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else CHECK = false;
                                    }
                                    catch
                                    {
                                        Console.SetCursorPosition(2, 10);
                                        Console.WriteLine("Du lieu nhap khong hop le!");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                } while (CHECK);

                                Console.Clear();
                                Console.SetCursorPosition(60, 0);
                                Console.Write("Ho ten:     Truong Van Hoang");
                                Console.SetCursorPosition(60, 1);
                                Console.Write("Mssv:       PH31092");
                                Console.SetCursorPosition(60, 2);
                                Console.Write("Giang vien: Nguyen Khanh Huyen (huyennk6)");

                                for (int i = 0; i < 55; i++)
                                {
                                    Console.SetCursorPosition(i, 0);
                                    Console.Write("*");
                                }


                                Console.WriteLine();

                                int idx = 2, idy = 3, checkDong = 13;
                                for (int i = Min; i <= Max; ++i)
                                {
                                    if (i % 2 == 1)
                                    {
                                        Console.SetCursorPosition(idx, idy);
                                        Console.Write($"{i} ");
                                        ++dem;
                                        idx += 4;
                                    }
                                    if (dem == checkDong)
                                    {
                                        idx = 2;
                                        idy++;
                                        checkDong += 13;
                                    }
                                }
                                Console.SetCursorPosition(2, 1);
                                Console.WriteLine($"Co {dem} so le trong doan tu [{Min}, {Max}]:");

                                for (int i = 1; i <= idy; i++)
                                {
                                    Console.SetCursorPosition(0, i); Console.Write("*");
                                }
                                for (int i = 1; i <= idy; i++)
                                {
                                    Console.SetCursorPosition(54, i); Console.Write("*");
                                }

                                for (int i = 0; i < 55; i++)
                                {
                                    Console.SetCursorPosition(i, idy + 1);
                                    Console.Write("*");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                        default:
                            {
                                Console.SetCursorPosition(0, 10);
                                Console.Write("Lua chon nhap khong hop le!");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                    }
                }
                catch
                {
                    Console.SetCursorPosition(0, 10);
                    Console.Write("Lua chon nhap khong hop le!");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (checkVongLap);
        }
    }
}
