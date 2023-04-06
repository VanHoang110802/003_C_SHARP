using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKiemTra1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyPhim qlPhim = new QuanLyPhim();

            int luaChon = -1;
            do
            {
                Console.WriteLine("--------------- MENU -----------------");
                Console.WriteLine("\t[1]. Nhap thong tin");
                Console.WriteLine("\t[2]. Xuat thong tin");
                Console.WriteLine("\t[3]. Tim phim theo ma");
                Console.WriteLine("\t[4]. Tim phim duoc san xuat sau 2010");
                Console.WriteLine("\t[5]. Ke thua");
                Console.WriteLine("\t[0]. Thoat");
                Console.WriteLine("--------------------------------------");
                Console.Write("Vui long nhap lua chon: ");
                try
                {
                    luaChon = Convert.ToInt32(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 1:
                            qlPhim.NhapPhim();
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 2:
                            qlPhim.XuatPhim();
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 3:
                            qlPhim.TimKiemTheoMa();
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 4:
                            List<Phim1> phim = qlPhim.TimPhimTheoNam();
                            if (phim == null)
                            {
                                Console.WriteLine("Chua nhap thong tin!!");
                            }
                            else
                            {
                                int dem = phim.Count;
                                if(dem < 1)
                                {
                                    Console.WriteLine("Khong tim thay!!!");
                                }
                                else
                                {
                                    for (int i = 0; i < dem; i++)
                                    {
                                        Console.WriteLine();
                                        phim[i].XuatThongTin();
                                    }
                                }
                                
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 5:
                            qlPhim.KeThua();
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 0:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Lua chon nhap khong hop le!, xin hay kiem tra lai!!!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Du lieu nhap khong duoc cho phep!!!");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (luaChon != 0);
        }
    }
}
