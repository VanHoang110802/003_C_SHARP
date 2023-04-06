using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKiemTra1
{
    internal class PhimSeGay : Phim1
    {
        private int soLuongNhanVat, soTap;
        private string daoDien;

        public PhimSeGay()
        {
                
        }


        public PhimSeGay(string maPhim, string tenPhim, string theLoai, int namSX, int trangThai, int soLuongNhanVat, int soTap, string daoDien) : base(maPhim, tenPhim, theLoai, namSX, trangThai)
        {
            this.soLuongNhanVat = soLuongNhanVat;
            this.soTap = soTap;
            this.daoDien = daoDien;
        }

        public int SoLuongNhanVat { get => soLuongNhanVat; set => soLuongNhanVat = value; }
        public int SoTap { get => soTap; set => soTap = value; }
        public string DaoDien { get => daoDien; set => daoDien = value; }

       

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap so luong nhan vat: ");
            soLuongNhanVat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so tap: ");
            soTap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten dao dien: ");
            daoDien = Console.ReadLine();   
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"So luong nhan vat: {soLuongNhanVat}");
            Console.WriteLine($"So tap cua phim: {soTap}");
            Console.WriteLine($"Dao dien cua bo phim: {daoDien}");
        }
    }
}
