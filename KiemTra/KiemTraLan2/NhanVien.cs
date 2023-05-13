using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangtvph31092
{
    internal class NhanVien
    {
        private string maNhanVien, hoTenNhanVien;
        double luongNhanVien;
        public NhanVien()
        {

        }
        public NhanVien(string maNhanVien, string hoTenNhanVien, double luongNhanVien)
        {
            this.maNhanVien = maNhanVien;
            this.hoTenNhanVien = hoTenNhanVien;
            this.luongNhanVien = luongNhanVien;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTenNhanVien { get => hoTenNhanVien; set => hoTenNhanVien = value; }
        public double LuongNhanVien { get => luongNhanVien; set => luongNhanVien = value; }

        public virtual void NhapThongTin()
        {
            Console.Write("Vui long nhap ma nhan vien: ");
            maNhanVien = Console.ReadLine();
            Console.Write("Vui long nhap ho ten nhan vien: ");
            HoTenNhanVien = Console.ReadLine();
            Console.Write("Vui long nhap luong cua nhan vien: ");
            luongNhanVien = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Ma nhan vien: {maNhanVien}");
            Console.WriteLine($"Ho ten nhan vien: {HoTenNhanVien}");
            Console.WriteLine($"Luong cua nhan vien: {luongNhanVien}");
        }

        public virtual double GetThuNhap()
        {
            return luongNhanVien;
        }
    }
}
