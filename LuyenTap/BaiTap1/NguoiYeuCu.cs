using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class NguoiYeuCu
    {
        private int idNYC;
        private string hoTenNYC;
        private double chieuCao, canNang;
        private bool isTrueLove;
        public NguoiYeuCu()
        {

        }

        public NguoiYeuCu(int idNYC, string hoTenNYC, double chieuCao, double canNang, bool isTrueLove)
        {
            this.idNYC = idNYC;
            this.hoTenNYC = hoTenNYC;
            this.chieuCao = chieuCao;
            this.canNang = canNang;
            this.isTrueLove = isTrueLove;
        }

        public int IdNYC { get => idNYC; set => idNYC = value; }
        public string HoTenNYC { get => hoTenNYC; set => hoTenNYC = value; }
        public double ChieuCao { get => chieuCao; set => chieuCao = value; }
        public double CanNang { get => canNang; set => canNang = value; }
        public bool IsTrueLove { get => isTrueLove; set => isTrueLove = value; }

        public string CheckTrueLove()
        {
            return (isTrueLove ? "Co" : "Khong");
        }
        public void NhapThongTin()
        {
            Console.WriteLine("Vui long nhap thong tin cho nguoi yeu cu: ");
            Console.Write("ID nguoi yeu cu: ");
            idNYC = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ho & ten: ");
            hoTenNYC = Console.ReadLine();
            Console.Write("Chieu cao: ");
            chieuCao = Convert.ToDouble(Console.ReadLine());
            Console.Write("Can nang: ");
            canNang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Co la tinh yeu dit vit hay khong? (true - co, false - khong): ");
            isTrueLove = Convert.ToBoolean(Console.ReadLine());
        }

        
        public void XuatThongTin()
        {
            Console.WriteLine($"ID nguoi yeu cu: {idNYC}");
            Console.WriteLine($"Ho & ten: {hoTenNYC}");
            Console.WriteLine($"Chieu cao: {chieuCao}");
            Console.WriteLine($"Can nang: {canNang}");
            Console.WriteLine($"{CheckTrueLove()} la tinh yeu dit vit.");
        }

    }
}
