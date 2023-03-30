using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class QuanLyNYC
    {
        List<NguoiYeuCu> _lstNYC;
        NguoiYeuCu _nguoiYeuCu;

        public QuanLyNYC()
        {
            _lstNYC = new List<NguoiYeuCu>();
        }

        public string ChuanHoaChuoi(string input)
        {
            input = input.Trim(); // loai bo khoang trang dau va cuoi
            input = input.ToLower(); //dua tat ca cac ki tu ve dang viet thuong
            while (input.IndexOf("  ") != -1) // kiem tra xem co 2 dau cach nao co lien nhau hay khong
            {
                input = input.Remove(input.IndexOf("  "), 1); // loai bo di 1 dau cach thoi
            }
            // tach cac tu boi dau cach de xu ly viet hoa de hon
            string[] s = input.Split(' ');
            string result = ""; // bien ket qua cuoi cung sau khi da chuan hoa xong
            for (int i = 0; i < s.Length; i++)
            {
                string first = s[i].Substring(0, 1); // lay ra ki tu dau tien cua tu do
                string another = s[i].Substring(1, s[i].Length - 1); // lay not cac ki tu con lai cua tu

                // tao thanh chuoi ky tu sau khi viet hoa chu cai dau tien và them 1 dau cach cho viec chuan hoa cac tu sau
                result += first.ToUpper() + another + " ";
            }

            // xoa di dau cach thua o cuoi chuoi khi da duoc chuan hoa xong
            result = result.Remove(result.LastIndexOf(' '), 1);

            return result;
        }

        public int CheckTiepTuc(string input)
        {
            if (input.Equals("Co"))
                return 1;

            else if (input.Equals("Khong"))
                return 0;

            else
                return -1;
        }

        public void NhapThongTin()
        {
            int checkTiepTuc = 0;
            string tiepTuc, chuanHoa;
            bool checkIDTrung = false;
            do
            {
                _nguoiYeuCu = new NguoiYeuCu();
                _nguoiYeuCu.NhapThongTin();
                _lstNYC.Add(_nguoiYeuCu);

                int soLuongPhanTu = _lstNYC.Count;
                if (soLuongPhanTu > 1)
                {
                    for (int i = 0; i < soLuongPhanTu - 1; ++i)
                    {
                        for (int j = i + 1; j < soLuongPhanTu; ++j)
                        {
                            if (_lstNYC[i].IdNYC == _lstNYC[j].IdNYC)
                            {
                                checkIDTrung = true;
                                break;
                            }
                        }
                        if (checkIDTrung == true)
                        {
                            break;
                        }
                    }
                }
                if (checkIDTrung == false)
                {
                    do
                    {
                        Console.Write("\nBan co muon nhap tiep khong? (co/khong) ");
                        tiepTuc = Console.ReadLine();
                        chuanHoa = ChuanHoaChuoi(tiepTuc);
                        checkTiepTuc = CheckTiepTuc(chuanHoa);

                        if (checkTiepTuc == -1)
                        {
                            Console.WriteLine("\nLua chon nhap khong hop le, xin hay kiem tra lai!!\n");
                        }
                        else
                            break;

                    } while (true);

                    if (checkTiepTuc == 0)
                    {
                        Console.WriteLine("\nDa luu thong tin!!!");
                    }

                }
                else
                {
                    Console.WriteLine("Ma ID nay da bi trung truoc do, xin hay kiem tra lai!!\n");

                    checkIDTrung = false;
                    int demLai = _lstNYC.Count;
                    _lstNYC.RemoveAt(demLai - 1);

                }
                Console.WriteLine();
            } while (checkTiepTuc != 0);
        }
        public void XuatThongTin()
        {
            int demSoLuong = _lstNYC.Count;
            if (demSoLuong > 0)
            {
                for (int i = 0; i < demSoLuong; i++)
                {
                    Console.WriteLine($"\nThong tin nguoi yeu cu thu {i + 1}");
                    _lstNYC[i].XuatThongTin();
                }
            }
            else
            {
                Console.WriteLine("Xin hay nhap thong tin !!!");
            }
        }
    }
}
