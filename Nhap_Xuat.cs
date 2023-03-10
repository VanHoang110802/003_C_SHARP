/*
         * BTVN:
         * Nhập và xuất thông tin món quà 8/3 bạn tặng cho NY
         * ten: string
         * giaTien: double
         * soLuong: int
         * isNew: bool //true- mới, false- cũ
         * noiMua: string        
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// trương 
namespace Lam_BT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string mssv, fullName, noiMua, tenMonQua;
            double giaTien;
            int soLuong;
            bool isNew;

            Console.WriteLine($"*********************************************************");
            Console.Write($"* Họ & tên sinh viên: ");
            fullName = Console.ReadLine();
            Console.SetCursorPosition(56, 1); Console.WriteLine($"*");
            Console.Write($"* Mã số sinh viên: ");
            mssv = Console.ReadLine();
            Console.SetCursorPosition(56, 2); Console.WriteLine($"*");
            Console.WriteLine($"*********************************************************");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"*********************************************************");
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 1); Console.WriteLine($"*");
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 2); Console.WriteLine($"*");
            Console.WriteLine($"*\t\t\tBTVN:\t\t\t\t*");
            Console.WriteLine($"* Nhập và xuất thông tin món quà 08/03 bạn tặng cho NY  *");
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 4); Console.WriteLine($"*");
            Console.WriteLine($"*********************************************************");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"*********************************************************");
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 1); Console.WriteLine($"*");
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 2); Console.WriteLine($"*");
            Console.WriteLine($"* Vui lòng nhập thông tin:");
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 3); Console.WriteLine($"*");
            Console.Write($"* Tên món quà: ");
            tenMonQua = Console.ReadLine();
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 4); Console.WriteLine($"*");
            Console.Write($"* Giá tiền: ");
            giaTien = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 5); Console.WriteLine($"*");
            Console.Write($"* Số lượng: ");
            soLuong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 6); Console.WriteLine($"*");
            Console.Write($"* Tình trạng của món quà (True - mới, False - cũ): ");
            isNew = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 7); Console.WriteLine($"*");
            Console.Write($"* Nó được mua ở: ");
            noiMua = Console.ReadLine();
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 8); Console.WriteLine($"*");
            Console.WriteLine($"*********************************************************");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"*********************************************************");
            Console.Write($"* Họ & tên sinh viên: {fullName}");
            Console.SetCursorPosition(56, 1); Console.WriteLine($"*");
            Console.Write($"* Mã số sinh viên: {mssv}");
            Console.SetCursorPosition(56, 2); Console.WriteLine($"*");
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 3); Console.WriteLine($"*");
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 4); Console.WriteLine($"*");
            Console.WriteLine($"*");
            Console.SetCursorPosition(20, 5); Console.WriteLine($"Thông tin");
            Console.SetCursorPosition(56, 5); Console.WriteLine($"*");

            Console.Write($"* Tên món quà: {tenMonQua}");
            Console.SetCursorPosition(56, 6); Console.WriteLine($"*");
            Console.Write($"* Giá tiền: {String.Format("{0:0,0.000}", giaTien)} VND");
            Console.SetCursorPosition(56, 7); Console.WriteLine($"*");
            Console.Write($"* Số lượng: {soLuong}");
            Console.SetCursorPosition(56, 8); Console.WriteLine($"*");
            Console.Write($"* Tình trạng (true - mới, false - cũ): {isNew}");
            Console.SetCursorPosition(56, 9); Console.WriteLine($"*");
            Console.Write($"* Được mua ở: {noiMua}");
            Console.SetCursorPosition(56, 10); Console.WriteLine($"*");
            Console.WriteLine($"*********************************************************");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
