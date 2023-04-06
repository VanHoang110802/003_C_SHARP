using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestKiemTra1
{
    internal class QuanLyPhim
    {
        List<Phim1> _lstPhim;
        Phim1 _phim;
        public QuanLyPhim()
        {
            _lstPhim = new List<Phim1>();
        }

        static bool KiemTraChu(string s)
        {
            return ((Regex.IsMatch(s, @"^[a-zA-Z]+$")) ? true : false);
        }

        static string ChuanHoaChuoi(string s)
        {
            string temp = s.ToLower();
            return temp.Substring(0, 1).ToUpper() + temp.Substring(1);
        }

        static int KiemTraTiepTuc(string s)
        {
            if (KiemTraChu(s))
            {
                s = ChuanHoaChuoi(s);
                if (s.Equals("Co")) return 1;
                else if (s.Equals("Khong")) return 0;
                else return -1;
            }
            else return -1;
        }

        public void NhapPhim()
        {
            int check;
            string tiepTuc;
            do
            {
                _phim = new Phim1();
                _phim.NhapThongTin();
                _lstPhim.Add(_phim);

                do
                {
                    Console.Write("Ban co muon nhap tiep khong ?(co/khong): ");
                    tiepTuc = Console.ReadLine();
                    check = KiemTraTiepTuc(tiepTuc);
                    if (check == 0 || check == 1) break;
                    else Console.WriteLine("Du lieu nhap khong hop le, xin hay kiem tra lai!!");
                } while (check < 0 || check > 1);
            } while (check != 0);

        }

        public void XuatPhim()
        {
            int soLuong = _lstPhim.Count;
            if (soLuong > 0)
            {
                for (int i = 0; i < soLuong; ++i)
                {
                    Console.WriteLine();
                    _lstPhim[i].XuatThongTin();
                }
            }
            else
            {
                Console.WriteLine("Chua nhap thong tin!!!");
            }
        }

        public void TimKiemTheoMa()
        {

            int soLuong = _lstPhim.Count;
            if (soLuong < 1)
            {
                Console.WriteLine("Chua nhap thong tin!!!");
            }
            else
            {
                Console.Write("Vui long nhap ma phim can tim kiem: ");
                string input = Console.ReadLine();

                for (int i = 0; i < soLuong; ++i)
                {
                    if (_lstPhim[i].MaPhim.Equals(input))
                    {
                        _lstPhim[i].XuatThongTin();
                        return;
                    }
                }
                Console.WriteLine("Khong tim thay ma phim!!!");
            }
        }

        public List<Phim1> TimPhimTheoNam()
        {
            List<Phim1> temp = new List<Phim1>();
            int dem = _lstPhim.Count;
            if (dem < 1) return null;
            else
            {
                for (int i = 0; i < dem; ++i)
                {
                    if (_lstPhim[i].NamSX > 2010)
                    {
                        temp.Add(_lstPhim[i]);
                    }
                }
                return temp;
            }
        }

        public void KeThua()
        {
            PhimSeGay psg = new PhimSeGay();
            psg.NhapThongTin();
            psg.XuatThongTin();
        }



    }
}
