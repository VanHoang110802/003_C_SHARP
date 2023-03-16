/*
      * Bài 1: Nhập và xuất thông tin Xe Máy
      * - id: int
      * - hang: string
      * - gia: double
      * - phanKhoi: int
      * - isVietNam: bool 
      * => yêu cầu in ra true là Xe Máy Việt Nam/ false là Xe Máy Nước Ngoài
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lam_BT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string fullName, mssv;
            int id;
            string hang;
            double gia;
            int phanKhoi;
            bool isVietNam;

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
            Console.WriteLine($"*\t      Nhập và xuất thông tin Xe Máy ");
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 4); Console.WriteLine($"*");
            Console.WriteLine($"*********************************************************");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"*********************************************************");
            Console.WriteLine($"*"); Console.SetCursorPosition(56, 1); Console.WriteLine($"*");
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
            Console.Write($"* Tên id: {id}");
            Console.SetCursorPosition(56, 6); Console.WriteLine($"*");
            Console.Write($"* Hàng: {hang}");
            Console.SetCursorPosition(56, 7); Console.WriteLine($"*");
            Console.Write($"* Giá: {gia}");
            Console.SetCursorPosition(56, 8); Console.WriteLine($"*");
            Console.Write($"* Phân khối: {phanKhoi}");
            Console.SetCursorPosition(56, 9); Console.WriteLine($"*");
            Console.Write($"* Xe là hãng của nước: {(isVietNam ? "VN" : "NN")}");
            Console.SetCursorPosition(56, 10); Console.WriteLine($"*");
            Console.WriteLine($"*********************************************************");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
