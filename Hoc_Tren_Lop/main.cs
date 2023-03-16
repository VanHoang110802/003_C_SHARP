using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTrenLop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             int x;
             Console.Write("Nhap x = ");
             x = int.Parse(Console.ReadLine());
             Console.WriteLine("x vua nhap = {0}{1}", x, 1);
            */

            /*
             for(int i=0;i<10;++i) 
             {
                 Console.Write("{0}\n", i);
             }
            
            int i = 1;
            while (i <= 10)
            {
                Console.Write("{0}\n", i);
                ++i;
            }
            
            int cc; // kiem tra xem x co hop le hay khong
            do
            {
                Console.Write("Vui long nhap x = ");
                cc = int.Parse(Console.ReadLine());
                if(cc < 10)
                {
                    Console.WriteLine("X nhap khong hop le!");
                }
            } while (cc < 10);
            Console.Write("X vua nhap la: {0}", cc);
            */

            /*
            int[] a = { 11, 08, 2002 };
             //mang:
           
            int n = 3;
            for(int i=0;i<n;++i)
            {
                Console.Write("{0}\n", a[i]);
            }
            // cau xuat mang se dung foreach.
            // cach khac duyet ma khong can n:
            foreach (int Ten_Dinh_Nghia_Cho_Cac_Phan_Tu in a)
            {
                Console.Write("{0}\n", Ten_Dinh_Nghia_Cho_Cac_Phan_Tu);
            }

            */

            /*
            int cc;
            do
            {
                Console.Write("Vui long nhap so luong phan tu: ");
                cc = int.Parse(Console.ReadLine());
                if (cc < 1)
                {
                    Console.WriteLine("So luong phan tu nhap khong hop le!");
                }
            } while (cc < 1);
            
            int[] a = new int[cc];
            for(int i=0;i<cc;++i)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nMang vua nhap la:");
            for (int i=0;i<cc;++i)
            {
                Console.Write(" {0} ", a[i]);
            }
            
            int t = 0;
            for(int i=0;i<cc;++i)
            {
                if (a[i] % 2 == 0)
                {
                    t += a[i];
                }
            }
            Console.WriteLine("\n\nTong cac so chan co trong mang: {0}", t);
            */
            string name, mssv;
            double diemtoan, diemly, diemhoa;
            Console.Write("Nhap vao ma so sinh vien: ");
            // vi no la 1 chuoi nen khong can parse
            mssv = Console.ReadLine();
            Console.Write("Nhap vao ho ten: ");
            name = Console.ReadLine();

            bool CHECK = true;
            while (CHECK)
            {
                try
                {
                    Console.Write("Nhap vao diem toan: ");
                    diemtoan = double.Parse(Console.ReadLine());

                    // du lieu hop le nhung phai xet them: nam trong doan [0, 10]
                    if (diemtoan < 0 || diemtoan > 10) Console.WriteLine("Diem toan nhap khong hop le!");
                    else CHECK = false;
                }
                catch
                {
                    Console.WriteLine("Du lieu nhap khong hop le!");
                }
            }
            CHECK = true;
            while (CHECK)
            {
                try
                {
                    Console.Write("Nhap vao diem ly: ");
                    diemly = double.Parse(Console.ReadLine());

                    // du lieu hop le nhung phai xet them: nam trong doan [0, 10]
                    if (diemly < 0 || diemly > 10) Console.WriteLine("Diem ly nhap khong hop le!");
                    else CHECK = false;
                }
                catch
                {
                    Console.WriteLine("Du lieu nhap khong hop le!");
                }
            }
            CHECK = true;
            while (CHECK)
            {
                try
                {
                    Console.Write("Nhap vao diem hoa: ");
                    diemhoa = double.Parse(Console.ReadLine());

                    // du lieu hop le nhung phai xet them: nam trong doan [0, 10]
                    if (diemhoa < 0 || diemhoa > 10) Console.WriteLine("Diem hoa nhap khong hop le!");
                    else CHECK = false;
                }
                catch
                {
                    Console.WriteLine("Du lieu nhap khong hop le!");
                }
            }
        }
    }
}
