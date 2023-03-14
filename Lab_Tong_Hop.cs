using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TONG_HOP
{
    internal class Program
    {
        const int MAX = 100;
        const int namGoc = 2023;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

             Menu();

        }
        static void Menu()
        {
            
            int luaChon;
            bool checkMenu = true;
            do 
            {
                Info();
                Console.SetCursorPosition(0, 0);
                NoiDungMenu();
                
                try
                {
                    luaChon = Convert.ToInt32(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 0:
                            {
                                Environment.Exit(0);
                                break;
                            }
                        case 1:
                            {

                                Bai1();
                                break;
                            }
                        case 2:
                            {
                                Bai2();
                                break;
                            }
                        case 3:
                            {
                                Bai3();
                                break;
                            }
                        case 4:
                            {
                                Bai4();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Lựa chọn nhập không hợp lệ, xin hãy kiểm tra lại!");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                    }
                }
                catch
                {
                    Console.WriteLine("Dữ liệu nhập không được phép chấp nhận!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (checkMenu);
        }

        static void Info()
        {
            Console.SetCursorPosition(60, 0);
            Console.Write("Họ tên:     Trương Văn Hoàng");
            Console.SetCursorPosition(60, 1);
            Console.Write("Mssv:       PH31092");
            Console.SetCursorPosition(60, 2);
            Console.Write("Giảng viên: Nguyễn Khánh Huyền (huyennk6)");
        }
        static void NoiDungMenu()
        {
            Console.WriteLine("+-------------------MENU----------------------+");
            Console.WriteLine("\t[1]: Kiểm tra số chẵn lẻ");
            Console.WriteLine("\t[2]: Kiểm tra ngày tháng");
            Console.WriteLine("\t[3]: Mảng điểm");
            Console.WriteLine("\t[4]: Mảng thông tin sinh viên Poly");
            Console.WriteLine("\t[0]: Thoát");
            Console.WriteLine("+---------------------------------------------+");
            Console.Write("Vui lòng nhập lựa chọn: ");
        }

// **************************************************************************************************
        static void NhapMangSo(int[] a, int n)
        {
            for (int i=0;i<n;++i)
            {
                bool checkPhanTu = true;
                do
                {
                    Console.Write($"Nhập số thứ {i + 1} = ");
                    try
                    {
                        a[i] = Convert.ToInt32(Console.ReadLine());
                        checkPhanTu = false;
                    }
                    catch
                    {
                        Console.WriteLine("Dữ liệu nhập không được phép chấp nhận!");
                    }
                } while (checkPhanTu);
            }    
        }
        static void KiemTraChanLe(int[] a, int n)
        {
            Console.Write("\nCác số chẵn là: ");
            for(int i=0;i<n;++i)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write($"{a[i]} ");
                }
            }
            Console.Write("\nCác số lẻ là: ");
            for (int i = 0; i < n; ++i)
            {
                if (a[i] % 2 != 0)
                {
                    Console.Write($"{a[i]} ");
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Bai1()
        {
            Console.Clear();
            int n = -1;
            do
            {
                Console.Write("Nhập số lượng phần tử: ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 0 || n > MAX)
                    {
                        Console.Write("Số lượng phần tử nhập không hợp lệ!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.Write("Dữ liệu nhập không được phép chấp nhận!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (n < 0 || n > MAX);

            int[] a = new int[n];
            NhapMangSo(a, n);
            KiemTraChanLe(a, n);
        }
// **************************************************************************************************
        static int checkThang2(int nam)
        {
            if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0)) return 1;
            else return 0;
        }
        static int checkNgay(int thang, int nam)
        {
            if(thang == 1 || thang == 3 || thang == 5 || thang == 7|| thang == 8 || thang == 10 || thang == 12)
            {
                return 31;
            }    
            else if(thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                return 30;
            }
            else
            {
                if (checkThang2(nam) == 1)
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            } 
        }

        static void NgayKeTiep(int nam, int thang, int ngay)
        {
            int cNgay = checkNgay(thang, nam);
            int namTiepTheo = nam; 
            int thangTiepTheo = thang; 
            int ngayTiepTheo = ngay;

            if (nam > 0 && (thang > 0 && thang < 13) && (ngay > 0 && ngay <= cNgay))
            {
                ngayTiepTheo = ngay + 1;
                
                if (thang != 12 && ngay == cNgay)
                {
                    ngayTiepTheo = 1;
                    thangTiepTheo = thang + 1;
                }
                else if (thang  == 12 && ngay == cNgay)
                {
                    ngayTiepTheo = 1;
                    namTiepTheo = nam + 1;
                    thangTiepTheo = 1;
                }
                else if (thang == 2)
                {
                    if (checkThang2(nam) == 1)
                    {
                        if (ngay == 29)
                        {
                            ngayTiepTheo = 1;
                            thangTiepTheo = thang + 1;
                        }
                    }
                    else
                    {
                        if (ngay == 28)
                        {
                            ngayTiepTheo = 1;
                            thangTiepTheo = thang + 1;
                        }
                    }
                }
            }
            Console.WriteLine($"\nNgày tiếp theo: {ngayTiepTheo}/{thangTiepTheo}/{namTiepTheo}");
        }

        static void NgayKeTruoc(int nam, int thang, int ngay)
        {
            int cNgay = checkNgay(thang, nam);
            int namTruocDo = nam;
            int thangTruocDo = thang;
            int ngayTruocDo = ngay;

            if (nam > 0 && (thang > 0 && thang < 13) && (ngay > 0 && ngay <= cNgay))
            {
                
                ngayTruocDo = ngay - 1;
                
                if (thang != 1 && ngay == 1)
                {
                    
                    if (thang == 2 || thang == 4 || thang == 6 || thang == 8 || thang == 9 || thang == 11)
                    {
                        ngayTruocDo = 31;
                        thangTruocDo = thang - 1;
                    }
                    
                    if (thang == 3)
                    {
                        if (checkThang2(nam) == 1)
                        {
                            ngayTruocDo = 29;
                            thangTruocDo = thang - 1;
                        }
                        else
                        {
                            ngayTruocDo = 28;
                            thangTruocDo = thang - 1;
                        }
                    }
                    
                    if (thang == 5 || thang == 7 || thang == 10 || thang == 12)
                    {
                        ngayTruocDo = 30;
                        thangTruocDo = thang - 1;
                    }
                }
                //nếu tháng nhập vào là tháng 1 và ngày 1 thì ngày tháng năm trước đó sẽ là ngày 31 tháng 12 năm trước đó
                else if (thang == 1 && thang == 1)
                {
                    ngayTruocDo = 31;
                    namTruocDo = nam - 1;
                    thangTruocDo = 12;
                }
            }
            Console.WriteLine($"\nNgày trước đó: {ngayTruocDo}/{thangTruocDo}/{namTruocDo}");
        }

        static void Bai2()
        {
            quaylai1:
            Console.Clear();
            int ngayHienTai, thangHienTai, namHienTai;
            do
            {
                Console.Write("Vui lòng nhập ngày hiện tại: ");
                try
                {
                    ngayHienTai = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Dữ liệu nhập không được phép chấp nhận!");
                }
            } while (true);

            do
            {
                Console.Write("Vui lòng nhập tháng hiện tại: ");
                try
                {
                    thangHienTai = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Dữ liệu nhập không được phép chấp nhận!");
                }
            } while (true);

            do
            {
                Console.Write("Vui lòng nhập năm hiện tại: ");
                try
                {
                    namHienTai = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Dữ liệu nhập không được phép chấp nhận!");
                }
            } while (true);

            if (ngayHienTai < 1 || ngayHienTai > checkNgay(thangHienTai, namHienTai))
            {
                Console.WriteLine("Ngày nhập không hợp lệ, xin hãy kiểm tra lại!");
                Console.ReadKey();
                goto quaylai1;
            }
            else if(thangHienTai < 1 || thangHienTai > 12)
            {
                Console.WriteLine("Tháng nhập không hợp lệ, xin hãy kiểm tra lại!");
                Console.ReadKey();
                goto quaylai1;
            }
            else if(namHienTai < 1800 || namHienTai > namGoc)
            {
                Console.WriteLine("Năm nhập không hợp lệ, xin hãy kiểm tra lại!");
                Console.ReadKey();
                goto quaylai1;
            }    

            Console.WriteLine($"\nNgày vừa nhập: {ngayHienTai}/{thangHienTai}/{namHienTai}");
            NgayKeTiep(namHienTai, thangHienTai, ngayHienTai);
            NgayKeTruoc(namHienTai, thangHienTai, ngayHienTai);
            Console.ReadKey();
            Console.Clear();
        }

// **************************************************************************************************
        static void NhapMangDiem(double[] a, int n)
        {
           
            for (int i = 0; i < n; ++i)
            {
                bool checkDiem = true;
                do
                {
                    Console.Write($"Nhập điểm thứ {i + 1} = ");
                    try
                    {
                        a[i] = Convert.ToDouble(Console.ReadLine());
                        if (a[i] < 0 || a[i] > 10)
                        {
                            Console.WriteLine("Điểm nhập không hợp lệ, xin hãy kiểm tra lại!");
                        }
                        else checkDiem = false;
                    }
                    catch
                    {
                        Console.WriteLine("Dữ liệu nhập không được phép chấp nhận!");
                    }
                } while (checkDiem);
            }
        }

        static void XuatMangDiem(double[]a, int n )
        {
            for (int i=0;i<n;++i)
            {
                Console.Write($"{a[i]}");
                Console.Write(a[i] < 5?" - Trượt\n":" - Đỗ\n");
            }
        }
        static void Bai3()
        {
            Console.Clear();
            int n = -1;
            do
            {
                Console.Write("Nhập số lượng điểm: ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 0 || n > MAX)
                    {
                        Console.Write("Số lượng điểm nhập không hợp lệ!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.Write("Dữ liệu nhập không được phép chấp nhận!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (n < 0 || n > MAX);

            double[] a = new double[n];
            NhapMangDiem(a, n);
            Console.WriteLine("\nBảng điểm vừa mới nhập là: ");
            XuatMangDiem(a, n);

            Array.Sort(a);
            Console.WriteLine("\nBảng điểm sau khi sắp tăng là: ");
            XuatMangDiem(a, n);

            Array.Sort(a);
            Array.Reverse(a);
            Console.WriteLine("\nBảng điểm sau khi sắp giảm là: ");
            XuatMangDiem(a, n);

            Console.ReadKey();
            Console.Clear();
        }

// **************************************************************************************************
        
        static void Bai4()
        {
            int n = -1;
            do
            {
                Console.Write("Nhập số lượng sinh viên: ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 1 || n > MAX)
                    {
                        Console.WriteLine("Số lượng sinh viên nhập không hợp lệ");
                    }
                    else break;
                }
                catch
                {
                    Console.WriteLine("Dữ liệu nhập không được cho phép!");
                }
                
            } while (n < 1 || n > MAX);

            string[] ten = new string[n];
            string[] Msv = new string[n];
            int[] namSinh = new int [n];
            int[] tuoiSv = new int[n];

            for(int i=0;i<n;++i)
            {
                Console.WriteLine($"Nhập thông tin sinh viên thứ {i+1}:");
                Console.Write("Tên: ");
                ten[i] = Console.ReadLine();
                
                bool checkMsv;
                do
                {
                    Console.Write("Mã số sinh viên: ");
                    checkMsv = true;
                    Msv[i] = Console.ReadLine();
                    int lengthString = Msv[i].Length;
                    if (i > 0)
                    {
                        if (Msv[i] == Msv[i - 1] || lengthString < 1)
                        {
                            Console.WriteLine("Mã số sinh viên này đã được tồn tại hoặc không hợp lệ, xin hãy kiểm tra lại!");
                        }
                        else checkMsv = false;
                    }
                    else if (lengthString < 1)
                    {
                        Console.WriteLine("Mã số sinh viên này đã được tồn tại hoặc không hợp lệ, xin hãy kiểm tra lại!");
                    }
                    else checkMsv = false;
                } while (checkMsv);
                Console.Write("Năm sinh: ");
                namSinh[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine($"{Msv[i]}");
            }
            int luaChon, checkNhapTuoi;
            Console.WriteLine("Bạn có muốn nhập tuổi cho từng sinh viên không?");
            do
            {
                checkNhapTuoi = 0;
                
                Console.Write("\n[1]. Yes\n[2]. No\nBạn chọn: ");
                try
                {
                    luaChon = Convert.ToInt32(Console.ReadLine());
                    if (luaChon == 1)
                    {
                        checkNhapTuoi = 1;
                        break;
                    }
                    else if (luaChon == 2)
                    {
                        checkNhapTuoi = 2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lựa chọn nhập không hợp lệ, xin hãy kiểm tra lại!");
                    }    
                }
                catch
                {
                    Console.WriteLine("Dữ liệu nhập không được cho phép!");
                }
                
            } while (checkNhapTuoi < 1 || checkNhapTuoi > 2);

            if(checkNhapTuoi == 1)
            {
                Console.WriteLine("Hãy nhập vào tuổi cho từng sinh viên: ");
                for(int i = 0; i < n;++i)
                {
                    Console.Write($"Sinh viên thứ {i + 1}: ");
                    do
                    {
                        try
                        {
                            tuoiSv[i] = Convert.ToInt32(Console.ReadLine());
                            if (tuoiSv[i] < 17)
                            {
                                Console.WriteLine("Tuổi của sinh viên không hợp lệ, xin hay kiểm tra lại!");
                            }
                            else break;
                        }
                        catch
                        {
                            Console.WriteLine("Dữ liệu nhập không được cho phép!");
                        }
                    } while (tuoiSv[i] < 17);
                }
            }    
            Console.ReadKey();
            Console.Clear();
        }
    }
}
