using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hoangtvph31092
{
    internal class SERVICE
    {
        List<NhanVienTiepThi> _lstNhanVienTiepThi;
        public SERVICE()
        {
            _lstNhanVienTiepThi = new List<NhanVienTiepThi>();
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
        public int KiemTraTiepTuc(string s)
        {
            if (KiemTraChuoi(s))
            {
                s = ChuanHoaChuoi(s);
                if (s.Equals("Co")) return 1;
                else if (s.Equals("Khong")) return 0;
                else return -1;
            }
            else return -1;
        }
        public void NhapNhanVien()
        {
            int check = -1;
            string tiepTuc;
            do
            {
                NhanVienTiepThi nhanVienTT = new NhanVienTiepThi();
                nhanVienTT.NhapThongTin();
                _lstNhanVienTiepThi.Add(nhanVienTT);

                do
                {
                    Console.Write("Ban co muon nhap tiep hay khong?(Co/Khong): ");
                    tiepTuc = Console.ReadLine();
                    check = KiemTraTiepTuc(tiepTuc);
                    if (check == 0 || check == 1) break;
                    else Console.WriteLine("Lua chon nhap khong hop le, xin hay kiem tra lai!!!");
                } while (check < 0 || check > 1);
            } while (check != 0);
            
        }

        public void XuatNhanVien()
        {
            int dem = _lstNhanVienTiepThi.Count;
            if(dem < 1)
            {
                Console.WriteLine("Chua nhap thong tin !!!");
                return;
            }
            for(int i=0;i<dem; i++)
            {
                Console.WriteLine();
                _lstNhanVienTiepThi[i].XuatThongTin();
            }
        }

        public void TimCacNhanVienTheoLuong()
        {
            int dem = _lstNhanVienTiepThi.Count;
            if(dem < 1)
            {
                Console.WriteLine("Chua nhap thong tin!!!");
                return;
            }
            bool check = false;
            Console.Write("Vui long nhap so luong can min: ");
            double luongCanTimMin = Convert.ToDouble(Console.ReadLine());

            Console.Write("Vui long nhap so luong can max: ");
            double luongCanTimMax = Convert.ToDouble(Console.ReadLine());

            for (int i=0;i< dem;++i)
            {
                if (_lstNhanVienTiepThi[i].LuongNhanVien >= luongCanTimMin && _lstNhanVienTiepThi[i].LuongNhanVien <= luongCanTimMax)
                {
                    check = true;
                    Console.WriteLine();
                    _lstNhanVienTiepThi[i].XuatThongTin();
                    
                }
            }
            if(!check)
            {
                Console.WriteLine("Khong tim thay luong !!!!");
            }
        }
        public void XuatNhanVienThuNhap()
        {
            int dem = _lstNhanVienTiepThi.Count;
            if (dem < 1)
            {
                Console.WriteLine("Chua nhap thong tin!!!");
                return;
            }
            _lstNhanVienTiepThi.Sort(delegate (NhanVienTiepThi s1, NhanVienTiepThi s2) { return s2.GetThuNhap().CompareTo(s1.GetThuNhap()); });
            
            if(dem < 5)
            {
                for (int i = 0; i < dem; ++i)
                {
                    Console.WriteLine();
                    _lstNhanVienTiepThi[i].XuatThongTin();
                }
            }
            else
            {
                for (int i = 0; i < 5; ++i)
                {
                    Console.WriteLine();
                    _lstNhanVienTiepThi[i].XuatThongTin();
                }
            }
            
        }
    }
}
