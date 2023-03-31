using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangtvph31092
{
    internal class QuanLyPhim
    {
        List<Phim> _lstQlPhim;
        
        
        public QuanLyPhim()
        {
            _lstQlPhim = new List<Phim>();
        }

        public void NhapThongTin()
        {
            bool check = true;
            do
            {
                Phim phim = new Phim();

                phim.NhapThongTinPhim();

                _lstQlPhim.Add(phim);

                int tipTuc;
                do
                {
                    Console.Write("Ban co muon nhap them khong? (1- co, 2- khong): ");
                    tipTuc = Convert.ToInt32(Console.ReadLine());
                    if (tipTuc < 1 || tipTuc > 2)
                    {
                        Console.WriteLine("Lua chon nhap khong hop le!");
                    }
                } while (tipTuc < 1 || tipTuc > 2);
                if (tipTuc == 2) break;
            } while (check);
        }

        public void TimPhimTheoMa()
        {
            int dem = _lstQlPhim.Count;
            if (dem < 0)
            {
                Console.WriteLine("Chua nhap thong tin!!");
            }
            else
            {
                Console.Write("Vui long nhap ma phim: ");
                string maPhim = Console.ReadLine();
                for (int i = 0; i < dem; i++)
                {
                    if (_lstQlPhim[i].MaPhim == maPhim)
                    {
                        Console.WriteLine("Da tim thay: ");
                        _lstQlPhim[i].XuatThongTinPhim();
                        return;
                    }
                    Console.WriteLine("Khong tim thay!!");
                }
            }
        }

        public void TimPhimTheoSX()
        {
            int dem = _lstQlPhim.Count;
            if (dem < 0)
            {
                Console.WriteLine("Chua nhap thong tin!!");
            }
            else
            {
                bool cPhim = false;
                for (int i = 0; i < dem; i++)
                {
                    if (_lstQlPhim[i].NamSXPhim > 2010)
                    {
                        Console.WriteLine("Da tim thay: ");
                        _lstQlPhim[i].XuatThongTinPhim();
                        cPhim = true;
                    }
                    if(!cPhim) Console.WriteLine("Khong tim thay!!");
                }
            }
        }

        public void XuatThongTin()
        {
            int dem = _lstQlPhim.Count;
            if(dem < 0)
            {
                Console.WriteLine("Chua nhap thong tin!!");
            }
            else
            {
                for (int i = 0; i < dem; i++)
                {
                    Console.WriteLine();
                    _lstQlPhim[i].XuatThongTinPhim();
                }
            }
            
        }
    }
}
