using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    internal class NhanVien
    {
        private string idNhanVien, hoTenNhanVien, soDienThoai;
        private double luongNhanVien;

        public NhanVien()
        {

        }

        public NhanVien(string idNhanVien, string hoTenNhanVien, string soDienThoai, double luongNhanVien)
        {
            this.idNhanVien = idNhanVien;
            this.hoTenNhanVien = hoTenNhanVien;
            this.soDienThoai = soDienThoai;
            this.luongNhanVien = luongNhanVien;
        }

        public string IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public string HoTenNhanVien { get => hoTenNhanVien; set => hoTenNhanVien = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public double LuongNhanVien { get => luongNhanVien; set => luongNhanVien = value; }

        public bool KiemTraSoThuc(string s)
        {
            return Regex.IsMatch(s, @"^[0-9]+(.[0-9]+)?$");
        }


        public int CheckNhapLuong(string s)
        {
            if (KiemTraSoThuc(s))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public bool KiemTraSoDienThoai(string s)
        {
            return Regex.IsMatch(s, @"^[0][0-9]{9}$");
        }

        public int CheckNhapSDT(string s)
        {
            if (KiemTraSoDienThoai(s))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public void NhapThongTin()
        {
            int checkLuong = -1, checkSDT = -1;
            Console.Write("Nhap ID cua nhan vien: ");
            idNhanVien = Console.ReadLine();
            Console.Write("Nhap ho ten cua nhan vien: ");
            hoTenNhanVien = Console.ReadLine();

            do
            {
                Console.Write("Nhap so dien thoai cua nhan vien: ");
                soDienThoai = Console.ReadLine();
                checkSDT = CheckNhapSDT(soDienThoai);
                if (checkSDT < 1 || checkSDT > 1) Console.WriteLine("Du lieu nhap khong hop le, xin hay kiem tra lai!!!");
                else
                {
                    break;
                }
            } while (checkSDT != 0);

            do
            {
                Console.Write("Nhap so luong cua nhan vien: ");
                string temp = Console.ReadLine();
                checkLuong = CheckNhapLuong(temp);
                if (checkLuong < 1 || checkLuong > 1) Console.WriteLine("Du lieu nhap khong hop le, xin hay kiem tra lai!!!");
                else
                {
                    luongNhanVien = Convert.ToDouble(temp);
                    break;
                }
            } while (checkLuong != 0);
        }

        public void XuatThongTin()
        {
            Console.Write($"\n{idNhanVien}|{hoTenNhanVien}|{soDienThoai}|{luongNhanVien}");
        }

        public string ObjToString()
        {
            return $"{idNhanVien}|{hoTenNhanVien}|{soDienThoai}|{luongNhanVien}\n";
        }
    }
}
