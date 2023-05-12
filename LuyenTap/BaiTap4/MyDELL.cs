using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap12
{
    internal class MyDELL : MayTinh
    {
        private string namSanXuat;

        public MyDELL()
        {

        }

        public MyDELL(string idMayTinh, string tenMayTinh, double trongLuongMayTinh, int giaMayTinh, string namSanXuat) : base(idMayTinh, tenMayTinh, trongLuongMayTinh, giaMayTinh)
        {
            this.NamSanXuat = namSanXuat;
        }

        public string NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public string ChuanHoaChuoi(string s)
        {
            string temp = s.ToLower();
            return temp.Substring(0, 1).ToUpper() + temp.Substring(1);
        }
        public override int GiamGia()
        {
            return (int)(0.85 * GiaMayTinh);
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap nam san xuat: ");
            namSanXuat = Console.ReadLine();
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"Nam san xuat may tinh: {namSanXuat}");
        }
    }
}
