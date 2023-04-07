using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hoangtvph31092
{
    internal class QuanLytra
    {
        List<Tra> _lstTra;
        Tra _tra;
        public QuanLytra()
        {
            _lstTra = new List<Tra>();
        }

        public bool KiemTraChuoi(string s)
        {
            return ((Regex.IsMatch(s, @"^[a-zA-Z]+$")) ? true : false);

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

        public void NhapTra()
        {
            int check;
            string tiepTuc;
            do
            {

                _tra = new Tra();
                _tra.NhapThongTin();
                _lstTra.Add(_tra);

                do
                {
                    Console.Write("Ban co muon nhap tiep hay khong? (co/khong): ");
                    tiepTuc = Console.ReadLine();
                    check = KiemTraTiepTuc(tiepTuc);
                    if (check == 0 || check == 1) break;
                    else Console.WriteLine("Lua chon nhap khong hop le, xin hay kiem tra lai!!!");
                } while (check < 0 || check > 1);

            } while (check != 0);


        }

        public void XuatTra()
        {
            int soLuong = _lstTra.Count();
            if (soLuong < 1)
            {
                Console.WriteLine("Chua nhap thong tin !!!");
                return;
            }
            else
            {

                for (int i = 0; i < soLuong; i++)
                {
                    Console.WriteLine();
                    _lstTra[i].XuatThongTin();
                }
            }
        }

        public void SapXepTangDan()
        {
            int soLuong = _lstTra.Count();
            if (soLuong < 1)
            {
                Console.WriteLine("Chua nhap thong tin !!!");
                return;
            }
            else
            {
                _lstTra.Sort(delegate (Tra s1, Tra s2) { return s1.SoLuong.CompareTo(s2.SoLuong); });
                for (int i = 0; i < soLuong; i++)
                {
                    Console.WriteLine();
                    _lstTra[i].XuatThongTin();

                }
            }
        }

        public List<Tra> TimGiaTraMax()
        {
            List<Tra> temp = new List<Tra>();
            int soLuong = _lstTra.Count;
            if (soLuong < 1) return null;
            else
            {
                _lstTra.Sort(delegate (Tra s1, Tra s2) { return s1.Gia.CompareTo(s2.Gia); });
                
                for (int i = soLuong - 1; i >= 0; --i)
                {
                    temp.Add(_lstTra[i]);
                    break;
                }
                return temp;
            }
        }

        public void KeThua()
        {
            TraSua ts = new TraSua();
            ts.NhapThongTin();
            ts.XuatThongTin();
        }
    }
}
