using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap12
{
    internal abstract class MayTinh
    {
        private string idMayTinh, tenMayTinh;
        private double trongLuongMayTinh;
        private int giaMayTinh;

        public MayTinh()
        {

        }
        public MayTinh(string idMayTinh, string tenMayTinh, double trongLuongMayTinh, int giaMayTinh)
        {
            this.idMayTinh = idMayTinh;
            this.tenMayTinh = tenMayTinh;
            this.trongLuongMayTinh = trongLuongMayTinh;
            this.giaMayTinh = giaMayTinh;
        }

        public string IdMayTinh { get => idMayTinh; set => idMayTinh = value; }
        public string TenMayTinh { get => tenMayTinh; set => tenMayTinh = value; }
        public double TrongLuongMayTinh { get => trongLuongMayTinh; set => trongLuongMayTinh = value; }
        public int GiaMayTinh { get => giaMayTinh; set => giaMayTinh = value; }

        public virtual void NhapThongTin()
        {
            Console.Write("\nVui long nhap ma ID cua may tinh: ");
            IdMayTinh = Console.ReadLine();
            Console.Write("Vui long nhap ten may tinh: ");
            TenMayTinh = Console.ReadLine();
            Console.Write("Vui long nhap trong luong cua may tinh: ");
            trongLuongMayTinh = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vui long nhap gia tien cua may tinh: ");
            giaMayTinh = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Ma ID cua may tinh la: {idMayTinh}");
            Console.WriteLine($"Ten cua may tinh la: {TenMayTinh}");
            Console.WriteLine($"Trong luong cua may tinh la: {trongLuongMayTinh}");
            Console.WriteLine($"Gia tien cua may tinh la: {GiamGia()}");
        }

        public abstract int GiamGia();

    }
}
