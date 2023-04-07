using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hoangtvph31092
{
    internal class TraSua : Tra
    {
        private int size;
        public TraSua()
        {

        }

        public TraSua(string ma, string ten, int gia, int soLuong, int size) : base(ma, ten, gia, soLuong)
        {
            this.size = size;
        }

        public int Size { get => size; set => size = value; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            do
            {
                Console.Write("Vui long nhap size (1-size M, 2- size L): ");
                size = Convert.ToInt32(Console.ReadLine());
                if(size < 1 || size > 2)
                {
                    Console.WriteLine("Lua chon nhap khong hop le:vv");
                }
            } while (size < 1 || size > 2);
            

        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"Size vua chon la: {(size == 1 ? "size M" : "size L")}");
        }
    }
}
