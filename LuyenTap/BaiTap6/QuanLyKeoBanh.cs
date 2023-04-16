using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaiTap6
{
    internal class QuanLyKeoBanh
    {
        List<KeoBanh> _lstKeoBanh;
        KeoBanh _keoBanh;
        public QuanLyKeoBanh()
        {
            _lstKeoBanh = new List<KeoBanh>();
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
            else
            {
                return -1;
            }
        }

        public void NhapBanhKeo()
        {
           

            int check = -1;
            string tiepTuc;
            do
            {
                _keoBanh = new KeoBanh();
                _keoBanh.NhapThongTin();
                _lstKeoBanh.Add(_keoBanh);

                do
                {
                    Console.Write("Ban co muon nhap tiep nua khong? (Co/Khong): ");
                    tiepTuc = Console.ReadLine();

                    check = KiemTraTiepTuc(tiepTuc);
                    if (check == 0 || check == 1) break;
                    else
                    {
                        Console.WriteLine("Lua chon nhap khong hop le, xin hay kiem tra lai!!!");
                    }
                } while (check < 0 || check > 1);
            } while (check != 0);
        }

        public void XuatBanhKeo()
        {
            Console.WriteLine("\n--------------------------------");
            int soLuong = _lstKeoBanh.Count;
            
            
            if (soLuong < 1)
            {
                Console.WriteLine("Chua nhap thong tin !!!");
                return;
            }
            for (int i = 0; i < soLuong; ++i)
            {
                Console.WriteLine();
                _lstKeoBanh[i].XuatThongTin();
            }
        }

        public void XuatKeoBanhConHan()
        {
            Console.WriteLine("\n--------------------------------");
            int soLuong = _lstKeoBanh.Count;
            bool checkHan = false;

            if (soLuong < 1)
            {
                Console.WriteLine("Chua nhap thong tin !!!");
                return;
            }
            for (int i = 0; i < soLuong; ++i)
            {
                if (_lstKeoBanh[i].TrangThai)
                {
                    Console.WriteLine();
                    _lstKeoBanh[i].XuatThongTin();
                    checkHan = true;
                }
                
            }
            if(!checkHan)
            {
                Console.WriteLine("Khong tim thay thong tin can tim!!!");
            }
        }

        public void SapXepTheoSoLuong()
        {
            int soLuong = _lstKeoBanh.Count;
            
            if (soLuong < 1)
            {
                Console.WriteLine("Chua nhap thong tin !!!");
                return;
            }
            _lstKeoBanh.Sort(delegate (KeoBanh s1, KeoBanh s2) { return s2.SoLuong.CompareTo(s1.SoLuong); });
            Console.WriteLine();
            XuatBanhKeo();        
        }

        public void SapXepTheoTenKeoBanh()
        {
            int soLuong = _lstKeoBanh.Count;

            if (soLuong < 1)
            {
                Console.WriteLine("Chua nhap thong tin !!!");
                return;
            }
            _lstKeoBanh.Sort(delegate (KeoBanh s1, KeoBanh s2) { return s1.TenKB.CompareTo(s2.TenKB); });
            Console.WriteLine();
            XuatBanhKeo();
        }

        public void XoaBanhKeoTheoCode()
        {
            int soLuong = _lstKeoBanh.Count;

            if (soLuong < 1)
            {
                Console.WriteLine("Chua nhap thong tin !!!");
                return;
            }
            Console.Write("Vui long nhap ma code can tim: ");
            int maCanTim = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            for(int i=0;i<soLuong;++i) // day la xoa 1, con xoa nhieu thi sao em:vv
            {
                if (_lstKeoBanh[i].CodeKB == maCanTim)
                {
                    _lstKeoBanh.Remove(_lstKeoBanh[i]);
                    check = true;
                    break;
                }
            }
            Console.ReadKey();
            Console.Clear();
            if(check) XuatBanhKeo();
            else Console.WriteLine("Khong tim thay noi dung can xoa!!!");
        }

    }
}
