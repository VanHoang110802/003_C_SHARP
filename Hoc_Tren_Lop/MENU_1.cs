/* 
      * Bài 2: Nhập min - max (int) từ bàn phím
      * - Nếu người dùng nhập min/max <0 yêu cầu nhập lại
      * - In ra tất cả các số lẻ trong khoảng min-max
      * - và đếm xem có bao nhiêu số lẻ đó
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_2
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Console.InputEncoding= Encoding.UTF8;
            //Console.OutputEncoding= Encoding.UTF8;

            int Min = 0, Max = 0, dem = 0;
            bool CHECK = true;

            do
            {
                try
                {
                    Console.Write("Nhap vao Min = ");
                    Min = Convert.ToInt32(Console.ReadLine());

                    if (Min < 0) Console.WriteLine("Min nhap khong hop le!");
                    else CHECK = false;
                }
                catch
                {
                    Console.WriteLine("Du lieu nhap khong hop le!");
                }
            } while (CHECK);
            CHECK = true;
           
            do
            {
                try
                {
                    Console.Write("Nhap vao Max = ");
                    Max = Convert.ToInt32(Console.ReadLine());

                    if (Max < 0 || Max < Min) Console.WriteLine("MAX nhap khong hop le!");
                    else CHECK = false;
                }
                catch
                {
                    Console.WriteLine("Du lieu nhap khong hop le!");
                }
            } while (CHECK);

            for (int i = Min; i <= Max; ++i)
            {
                if (i % 2 == 1)
                {
                    Console.Write($"{i} ");
                    ++dem;
                }
            }
            Console.WriteLine($"\nCo {dem} so le trong doan tu [{Min}, {Max}]");
        }
    }
}
