using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaiTap5
{
    #region SERIALIZABLE
    /*
     * Serializable:
     * Theo như tìm hiểu thì đây là 1 kỹ thuật chuyển đổi ojb thành về trung gian. 
     * Giúp cho lưu trữ được ojb đó vào được trong file
     * Mà một khi mà lưu trữ được vào file thì khi cần muốn đọc file lên sẽ đọc được file thôi.
     * Mỗi class nên có đánh tránh việc bị lỗi nhá @@
     */
    #endregion

    [Serializable]
    internal class QuanLySinhVien
    {
        List<SinhVien> _lstSinhVien;
        SinhVien _sinhVien;
        string _input;
        FileStream _fs;
        BinaryFormatter _bf;
        string _path = @"E:\\LuyenTap\\BaiTapAnHanh\\BaiTap5\\data.bin";
        public QuanLySinhVien()
        {
            _lstSinhVien = new List<SinhVien>();
        }

        public bool KiemTraChuoi(string s)
        {
            return ((!Regex.IsMatch(s, @"^[a-z][A-Z]+$")) ? true : false);
        }

        public bool KiemTraSo(string s)
        {
            return ((!Regex.IsMatch(s, @"^(\\-)?[0-9]+$")) ? true : false);
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

        public void NhapSinhVien()
        {
            int check = -1;
            string tiepTuc;
            do
            {
                _sinhVien = new SinhVien();
                _sinhVien.NhapThongTin();
                _lstSinhVien.Add(_sinhVien);

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

        public void XuatSinhVien()
        {
            int soLuong = _lstSinhVien.Count;
            if (soLuong < 1)
            {
                Console.WriteLine("Chua nhap thong tin!!");
                return;
            }

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine();
                _lstSinhVien[i].XuatThongTin();
            }
        }

        public void XuatSinhVien20Tuoi()
        {
            int soLuong = _lstSinhVien.Count;
            bool checkTuoi = false;
            if (soLuong < 1)
            {
                Console.WriteLine("Chua nhap thong tin !!!");
                return;
            }
            for (int i = 0; i < soLuong; i++)
            {
                int tuoi = 2023 - _lstSinhVien[i].NamSinh;
                if (tuoi >= 20)
                {
                    Console.WriteLine();
                    _lstSinhVien[i].XuatThongTin();
                    checkTuoi = true;
                }
            }
            if (!checkTuoi)
            {
                Console.WriteLine("Khong tim thay thong tin can tim!!!");
            }
        }

        public void TimSinhVienTheoMa()
        {
            int soLuong = _lstSinhVien.Count;


            if (soLuong < 1)
            {
                Console.WriteLine("Chua nhap thong tin !!!");
                return;
            }


            bool checkMa = false;

            Console.Write("Vui long nhap ma sinh vien can tim kiem: ");
            string maTimKiem = Console.ReadLine();

            for (int i = 0; i < soLuong; i++)
            {
                if (_lstSinhVien[i].Equals(maTimKiem))
                {
                    Console.WriteLine();
                    _lstSinhVien[i].XuatThongTin();
                    checkMa = true;
                }
            }
            if (!checkMa)
            {
                Console.WriteLine("Khong tim thay thong tin can tim!!!");
            }
        }

        public void KeThua()
        {
            SinhVienPOLY svPOLY = new SinhVienPOLY();
            svPOLY.NhapThongTin();
            Console.WriteLine();
            svPOLY.XuatThongTin();
        }

        public void SaveFile()
        {
            try
            {
                _fs = new FileStream(_path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, _lstSinhVien);
                _fs.Close();
                Console.WriteLine("Luu thanh cong!");
                return;
            }
            catch
            {
                Console.WriteLine("Khong luu duoc file!");
            }

        }

        public void ReadFile()
        {
            try
            {
                _fs = new FileStream(_path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs); // data là 1 ojb nha.
                // nếu như list mà không khởi tạo lại sẽ dẫn đến cộng dồn ->> sai
                _lstSinhVien = new List<SinhVien>();
                _lstSinhVien = (List<SinhVien>)data; // ép kiểu rồi gán lại
                _fs.Close();
                Console.WriteLine("Doc file thanh cong!");
                return;
            }
            catch
            {
                Console.WriteLine("Khong doc duoc file!");
            }

        }
    }
}
