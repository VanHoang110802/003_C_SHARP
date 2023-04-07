using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangtvph31092
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLytra qlTra = new QuanLytra();
            int luaChon;
            do
            {
                Console.WriteLine("------------------------------------- MENU ---------------------------------");
                Console.WriteLine("1. Nhap thong tin");
                Console.WriteLine("2. Xuat thong tin");
                Console.WriteLine("3. Sap xep danh sach tra theo so luong tang dan");
                Console.WriteLine("4. Tim tra co gia lon nhat");
                Console.WriteLine("5. Ke thua");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.Write("Vui long nhap lua chon cua ban: ");
                luaChon = Convert.ToInt32(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        qlTra.NhapTra();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        qlTra.XuatTra();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        qlTra.SapXepTangDan();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        List <Tra> ans = qlTra.TimGiaTraMax();
                        if(ans == null)
                        {
                            Console.WriteLine("Chua nhap thong tin!!!");
                        }
                        else
                        {
                            int soLuong = ans.Count;
                            if(soLuong < 1)
                            {
                                Console.WriteLine("Khong tim thay thong tin!!!");
                            }
                            else
                            {
                                for(int i=0;i<soLuong;++i)
                                {
                                    ans[i].XuatThongTin();
                                }
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        qlTra.KeThua();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lua chon nhap khong hop le, xin hay kiem tra lai!!!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (luaChon != 0);
        }
    }
}
