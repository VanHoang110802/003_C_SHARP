using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangtvph31092
{
    internal class NhanVienTiepThi : NhanVien
    {
        private double doanhSo, hoaHong;
        public NhanVienTiepThi()
        {

        }

        public NhanVienTiepThi(string maNhanVien, string hoTenNhanVien, double luongNhanVien, double doanhSo, double hoaHong) : base(maNhanVien, hoTenNhanVien, luongNhanVien)
        {
            this.doanhSo = doanhSo;
            this.hoaHong = hoaHong;
        }

        public override double GetThuNhap()
        {
            return LuongNhanVien + (doanhSo * hoaHong);
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Vui long nhap doanh so: ");
            doanhSo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vui long nhap hoa hong: ");
            hoaHong = Convert.ToDouble(Console.ReadLine());
            
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"Doanh so vua nhap: {doanhSo}");
            Console.WriteLine($"Hoa hong vua nhap la: {hoaHong}");
            Console.WriteLine($"Thu nhap: {GetThuNhap()}");
        }
    }
}
