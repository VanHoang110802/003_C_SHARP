using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class BanhKeo
    {
        private int idBanhKeo, trongLuongBanhKeo, conHan;
        private string tenBanhKeo;
        private double giaCaBanhKeo;

        public BanhKeo()
        {

        }

        public BanhKeo(int idBanhKeo, int trongLuongBanhKeo, int conHan, string tenBanhKeo, double giaCaBanhKeo)
        {
            this.idBanhKeo = idBanhKeo;
            this.trongLuongBanhKeo = trongLuongBanhKeo;
            this.conHan = conHan;
            this.tenBanhKeo = tenBanhKeo;
            this.giaCaBanhKeo = giaCaBanhKeo;
        }

        public int IdBanhKeo { get => idBanhKeo; set => idBanhKeo = value; }
        public int TrongLuongBanhKeo { get => trongLuongBanhKeo; set => trongLuongBanhKeo = value; }
        public int ConHan { get => conHan; set => conHan = value; }
        public string TenBanhKeo { get => tenBanhKeo; set => tenBanhKeo = value; }
        public double GiaCaBanhKeo { get => giaCaBanhKeo; set => giaCaBanhKeo = value; }

        public void NhapBanhKeo()
        {
            Console.WriteLine("Vui long nhap thong tin chi tiet: ");
            Console.Write("Ma ID cua banh keo: ");
            idBanhKeo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ten cua banh keo: ");
            tenBanhKeo = Console.ReadLine();
            Console.Write("Trong luong cua banh keo: ");
            trongLuongBanhKeo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gia cua banh keo: ");
            giaCaBanhKeo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Banh keo con han hay khong? (1 - Con, 2 - Het): ");
            conHan = Convert.ToInt32(Console.ReadLine());
        }

        public string CheckConHan()
        {
            return (conHan == 1 ? "con" : "het");
        }

        public void XuatBanhKeo()
        {
            Console.WriteLine($"Ma ID cua banh keo: {idBanhKeo}");
            Console.WriteLine($"Ten banh keo: {tenBanhKeo}");
            Console.WriteLine($"Trong luong cua banh keo: {trongLuongBanhKeo}");
            Console.WriteLine($"Gia cua banh keo: {giaCaBanhKeo}");
            Console.WriteLine($"Banh da {CheckConHan()} han dung!!!");
            
        }

    }
}
