using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangtvph31092
{
    internal class Tra
    {
        private string ma, ten;
        private int gia, soLuong;
        public Tra()
        {

        }
        public Tra(string ma, string ten, int gia, int soLuong)
        {
            this.ma = ma;
            this.ten = ten;
            this.gia = gia;
            this.soLuong = soLuong;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Gia { get => gia; set => gia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhap ma: ");
            ma = Console.ReadLine();
            Console.Write("Nhap ten: ");
            ten = Console.ReadLine();
            Console.Write("Nhap gia: ");
            gia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so luong: ");
            soLuong = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Ma: {ma}");
            Console.WriteLine($"Ten: {ten}");
            Console.WriteLine($"Gia: {gia}");
            Console.WriteLine($"So luong: {soLuong}");
        }

       
    }
}
