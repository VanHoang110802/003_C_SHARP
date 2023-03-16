using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ASS_GD_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

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
                                Console.WriteLine("Đang chọn vào nút: Nhập danh sách học viên.");

                                break;
                            }
                        case 2:
                            {

                                Console.WriteLine("Đang chọn vào nút: Xuất danh sách học viên.");

                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Đang chọn vào nút: Tìm kiếm học viên theo khoảng điểm nhập từ bàn phím.");

                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Đang chọn vào nút: Tìm kiếm học viên theo học lực nhập từ bàn phím");

                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Đang chọn vào nút: Tìm học viên theo mã số và cập nhật thông tin học viên.");

                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("Đang chọn vào nút: Sắp xếp học viên theo điểm");

                                break;
                            }
                        case 7:
                            {

                                Console.WriteLine("Đang chọn vào nút: Xuất 5 học viên có điểm cao nhất");

                                break;
                            }
                        case 8:
                            {

                                Console.WriteLine("Đang chọn vào nút: Tính điểm trung bình của lớp");

                                break;
                            }
                        case 9:
                            {

                                Console.WriteLine("Đang chọn vào nút: Xuất danh sách học viên có điểm trên điểm trung bình của lớp");

                                break;
                            }
                        case 10:
                            {
                                Console.WriteLine("Đang chọn vào nút: Tổng hợp số học viên theo học lực");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Lựa chọn nhập không hợp lệ, xin hãy kiểm tra lại!");

                                break;
                            }
                    }
                    Console.ReadKey();
                    Console.Clear();
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
            Console.SetCursorPosition(80, 0);
            Console.Write("Họ tên:     Trương Văn Hoàng");
            Console.SetCursorPosition(80, 1);
            Console.Write("Mssv:       PH31092");
            Console.SetCursorPosition(80, 2);
            Console.Write("Giảng viên: Nguyễn Khánh Huyền (huyennk6)");
        }
        static void NoiDungMenu()
        {
            Console.WriteLine("+-------------------------------MENU--------------------------------+\n");
            Console.WriteLine("  [1]: Nhập danh sách học viên.");
            Console.WriteLine("  [2]: Xuất danh sách học viên.");
            Console.WriteLine("  [3]: Tìm kiếm học viên theo khoảng điểm nhập từ bàn phím.");
            Console.WriteLine("  [4]: Tìm kiếm học viên theo học lực nhập từ bàn phím");
            Console.WriteLine("  [5]: Tìm học viên theo mã số và cập nhật thông tin học viên.");
            Console.WriteLine("  [6]: Sắp xếp học viên theo điểm");
            Console.WriteLine("  [7]: Xuất 5 học viên có điểm cao nhất");
            Console.WriteLine("  [8]: Tính điểm trung bình của lớp");
            Console.WriteLine("  [9]: Xuất danh sách học viên có điểm trên điểm trung bình của lớp");
            Console.WriteLine("  [10]: Tổng hợp số học viên theo học lực");
            Console.WriteLine("  [00]: Thoát");
            Console.WriteLine("\n+-------------------------------------------------------------------+");
            Console.Write("Vui lòng nhập lựa chọn: ");
        }
    }
}
