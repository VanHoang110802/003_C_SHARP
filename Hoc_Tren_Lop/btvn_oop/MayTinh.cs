using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_OOP
{
    internal class MayTinh
    {
        private int idMayTinh;
        private string hangMayTinh;
        private int namSX;
        private double inch;
        private bool isNew;
        
        public MayTinh()
        {

        }
        public MayTinh(int idMayTinh, string hangMayTinh, int namSX, double inch, bool isNew)
        {
            this.idMayTinh = idMayTinh;
            this.hangMayTinh = hangMayTinh;
            this.namSX = namSX;
            this.inch = inch;
            this.isNew = isNew;
        }

        public int IdMayTinh { get => idMayTinh; set => idMayTinh = value; }
        public string HangMayTinh { get => hangMayTinh; set => hangMayTinh = value; }
        public int NamSX { get => namSX; set => namSX = value; }
        public double Inch { get => inch; set => inch = value; }
        public bool IsNew { get => isNew; set => isNew = value; }

        public void NhapThongTin()
        {
            // tạm thời cứ coi như các inp là đúng
            Console.WriteLine("Vui lòng nhập thông tin máy tính: ");
            Console.Write("Mã ID: ");
            idMayTinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hãng máy: ");
            hangMayTinh = Console.ReadLine();
            Console.Write("Năm sản xuất: ");
            namSX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Số inch màn hình: ");
            inch = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tình trạng của máy (true - mới, false - cũ): ");
            isNew = Convert.ToBoolean(Console.ReadLine());
        }
        public void InThongTin()
        {
            Console.WriteLine("Thông tin máy tính vừa nhập:");
            Console.WriteLine($"Mã ID: {idMayTinh}");
            Console.WriteLine($"Hãng máy: {hangMayTinh}");
            Console.WriteLine($"Năm sản xuất: {NamSX}");
            Console.WriteLine($"Số inch màn hình: {inch}");
            Console.WriteLine($"Tình trạng của máy: {(isNew == true ? "Máy mới" : "Máy cũ")}");
        }
    }
}
