using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class NgayThangNam
    {
        private int ngay, thang, nam;

        public NgayThangNam()
        {

        }

        public NgayThangNam(int ngay, int thang, int nam)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }

        public int Ngay { get => ngay; set => ngay = value; }
        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }

        bool CheckThang2(int nam)
        {
            if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0)) return true;
            else return false;
        }

        int CheckNgay(int thangHienTai, int namHienTai)
        {
            if (thangHienTai == 1 || thangHienTai == 3 || thangHienTai == 5 || thangHienTai == 7 || thangHienTai == 8 || thangHienTai == 10 || thangHienTai == 12)
            {
                return 31;
            }
            else if (thangHienTai == 4 || thangHienTai == 6 || thangHienTai == 9 || thangHienTai == 11)
            {
                return 30;
            }
            else
            {
                if (CheckThang2(namHienTai))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
        }
        public void NhapTime()
        {
        quaylai1:
            Console.Clear();

            do
            {
                Console.Write("\nVui long nhap ngay: ");
                try
                {
                    ngay = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Du lieu nhap khong duoc phep chap nhan!");
                }
            } while (true);

            do
            {
                Console.Write("Vui long nhap thang: ");
                try
                {
                    thang = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Du lieu nhap khong duoc phep chap nhan!");
                }
            } while (true);

            do
            {
                Console.Write("Vui long nhap nam: ");
                try
                {
                    nam = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Du lieu nhap khong duoc phep chap nhan!");
                }
            } while (true);
            if (ngay < 1 || ngay > CheckNgay(thang, nam))
            {
                Console.WriteLine("Ngay nhap khong hop le, xin hay kiem tra lai!");
                Console.ReadKey();
                goto quaylai1;
            }
            else if (thang < 1 || thang > 12)
            {
                Console.WriteLine("Thang nhap khong hop le, xin hay kiem tra lai!");
                Console.ReadKey();
                goto quaylai1;
            }
            else if (nam < 1800 || nam > 2023)
            {
                Console.WriteLine("Nam nhap khong hop le, xin hay kiem tra lai!");
                Console.ReadKey();
                goto quaylai1;
            }

        }

        public void XuatTime()
        {
            Console.WriteLine($"Ngay thang nam vua nhap: {ngay} / {thang} / {nam}");
        }
    }
}
