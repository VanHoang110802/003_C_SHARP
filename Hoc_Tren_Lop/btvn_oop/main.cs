/*
Tạo class may tinh bao gom cac thuoc tinh:
- id: int
- hang: string
- namSX: int
- inch: double
- isNew: bool
-->> private cac thuoc tinh
- tao constructor co tham  so & khong co tham so
- co day du properties, tao phuong thuc InThongTin();
- 2 doi tuong ctor khong tham so
- sau do in thong tin ra man hinh bang phuong thuc InThongTin();
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding= Encoding.UTF8;
            Console.OutputEncoding= Encoding.UTF8;

            MayTinh dell = new MayTinh();
            dell.NhapThongTin();
            dell.InThongTin();
        }
    }
}
