using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaiTap12
{
    internal class QuanLyMayTinh
    {
        List<MyDELL> _lstMayTinh;
        public QuanLyMayTinh()
        {
            _lstMayTinh = new List<MyDELL>();
        }

        public bool KiemTraChuoi(string s)
        {
            return ((!Regex.IsMatch(s, @"^[a-z][A-Z]+$")) ? true : false);
        }

        public string ChuanHoaChuoi(string s)
        {
            string temp = s.ToLower();
            return temp.Substring(0, 1).ToUpper() + temp.Substring(1);
        }

        public int KiemTraHopLe(string s)
        {
            if (KiemTraChuoi(s))
            {
                s = ChuanHoaChuoi(s);
                if (s.Equals("Co")) return 1;
                else if (s.Equals("Khong")) return 0;
                else return -1;
            }
            else
            {
                return -1;
            }
        }
        public void NhapMayTinh()
        {
            string tiepTuc;
            int check = -1;
            do
            {
                MyDELL mayTinh = new MyDELL();
                mayTinh.NhapThongTin();
                _lstMayTinh.Add(mayTinh);

                do
                {
                    Console.Write("Ban co muon nhap tiep hay khong(Co/Khong): ");
                    tiepTuc = Console.ReadLine();
                    check = KiemTraHopLe(tiepTuc);
                    if (check == 0 || check == 1) break;
                    else Console.WriteLine("Lua chon nhap khong hop le, xin hay kiem tra lai!!!");
                } while (check < 0 || check > 1);
            } while (check != 0);
        }

        public void XuatMayTinh()
        {
            int dem = _lstMayTinh.Count;
            if (dem < 1)
            {
                Console.WriteLine("Chua nhap thong tin");
                return;
            }
            for (int i = 0; i < dem; i++)
            {
                Console.WriteLine();
                _lstMayTinh[i].XuatThongTin();
            }
        }

        public void XoaDoiTuongTheoID()
        {
            Console.Write("\n\n------------------------------------------\n");
            int dem = _lstMayTinh.Count;
            Console.Write("Vui long nhap ma ID can xoa: ");
            string input = Console.ReadLine();

            for (int i = 0; i < dem; ++i)
            {
                if (_lstMayTinh[i].IdMayTinh.Equals(input))
                {
                    _lstMayTinh.Remove(_lstMayTinh[i]);
                    return;
                }
            }
            Console.WriteLine("Khong tim thay ma ID can tim!!!");
        }

       

        public void TimTheoTenGanDung()
        {
            Console.Write("\n\n------------------------------------------\n");
            int dem = _lstMayTinh.Count;

            Console.Write("Vui long nhap ten can tim: ");
            string input = Console.ReadLine();
            input = ChuanHoaChuoi(input);
            bool checkTrung = false;
            for (int i = 0; i < dem; ++i)
            {
                string temp = ChuanHoaChuoi(_lstMayTinh[i].TenMayTinh);
                if (temp.Equals(input))
                {
                    checkTrung = true;
                    break;
                }
            }
            if (!checkTrung)
            {
                Console.WriteLine("Khong tim thay ma phu hop!!!!");
                return;
            }
            for (int i = 0; i < dem; ++i)
            {
                string temp = ChuanHoaChuoi(_lstMayTinh[i].TenMayTinh);
                if (temp.Equals(input))
                {
                    Console.WriteLine();
                    _lstMayTinh[i].XuatThongTin();
                }
            }
        }

        public List<MyDELL> XoaTenTrung()
        {
            List<MyDELL> temp = new List<MyDELL>();
            int dem = _lstMayTinh.Count;
            Console.WriteLine("Vui long nhap ten: ");
            string input = Console.ReadLine();
            for (int i = 0; i < dem; ++i)
            {
                if (!_lstMayTinh[i].TenMayTinh.Equals(input))
                {
                    temp.Add(_lstMayTinh[i]);
                }
            }
            return temp;
        }

    }
}
