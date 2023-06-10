using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SERVICE sv = new SERVICE();
            List<NhanVien> lstNhanVien = new List<NhanVien>();
            string path = @"E:\BAITAPCS\BaiTap1\BaiKiemTra\NhanVien.txt";
            int luaChon = -1;


            do
            {
                Console.WriteLine("------------------ MENU ------------------ ");
                Console.WriteLine("\t[1] Nhap");
                Console.WriteLine("\t[2] Xuat");
                Console.WriteLine("\t[3] Ghi file");
                Console.WriteLine("\t[4] Doc file");
                Console.WriteLine("\t[5] LINQ");
                Console.WriteLine("\t[0] Thoat");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Vui long nhap lua chon cua ban: ");
                try
                {
                    luaChon = Convert.ToInt32(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 1:
                            {
                                sv.NhapDanhSach(lstNhanVien);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                sv.XuatDanhSach(lstNhanVien);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 3:
                            {
                                if (File.Exists(path))
                                {
                                    if (lstNhanVien.Count() == 0)
                                    {
                                        Console.WriteLine("Ban da nhap thong tin chua ?");
                                    }
                                    else
                                    {
                                        File.WriteAllText(path, "");
                                        sv.GhiFile(path, lstNhanVien);
                                    }
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Ban hay tao file truoc roi han ghi nha!!!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }


                                break;
                            }
                        case 4:
                            {

                                if (File.Exists(path))
                                {
                                    sv.DocFile(path);
                                    List<NhanVien> lst = sv.DocFile(path);
                                    if (lst == null)
                                    {
                                        Console.Write("Hay chac chan rang ban da ghi data vao file!!!");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Danh sach la: ");
                                        foreach (var item in lst)
                                        {
                                            item.XuatThongTin();
                                        }
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ban hay tao file truoc roi han doc nha!!!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                                break;
                            }
                        case 5:
                            {
                                if (File.Exists(path))
                                {
                                    sv.LINQ(path, lstNhanVien);
                                }
                                else
                                {
                                    Console.WriteLine("Ban hay tao file truoc roi han sap xep nha!!!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            }
                        case 0:
                            {
                                Environment.Exit(0);
                                break;
                            }
                        default:
                            Console.WriteLine("Lua chon nhap khong hop le, xin hay kiem tra lai!!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Lua chon nhap khong hop le, xin hay kiem tra lai!!");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (luaChon != 0);
        }
    }
}
