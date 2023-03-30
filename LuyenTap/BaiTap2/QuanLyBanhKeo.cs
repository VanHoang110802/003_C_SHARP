using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class QuanLyBanhKeo
    {
        List<BanhKeo> _lstBanhKeo;
        BanhKeo _banhKeo;

        public string ChuanHoaChuoi(string name)
        {
            name = name.Trim(); // loại bỏ các dấu cách thừa ở đầu và cuối
            name = name.ToLower(); // đưa tất cả các ký tự về dạng viết thường cho dễ kiểm soát
            while (name.IndexOf("  ") != -1) // kiểm tra xem có dấu 2 dấu cách nào liền nhau hay không
            {
                // thực hiện câu lệnh trong vòng lặp này chứng tỏ là có 2 dấu cách liền nhau
                name = name.Remove(name.IndexOf("  "), 1); // loại bỏ đi 1 trong 2 dấu cách
            }
            // tiếp theo đó là viết hoa lên vị trí phân tách tên
            string[] s = name.Split(' '); // tách các từ bởi dấu cách để xử lý viết hoa dễ hơn
            string afterFormat = ""; // biến lưu trữ lại chuỗi ký tự sau khi chuẩn hóa
            for (int i = 0; i < s.Length; ++i) // thực hiện lặp lên toàn bộ các phần tử sau khi phân tách
            {
                string first = s[i].Substring(0, 1); // lấy ra ký tự đầu tiên của từ đó
                string another = s[i].Substring(1, s[i].Length - 1); // lấy ra chuỗi ký tự tính từ sau chữ cái đầu tiên
                                                                     // tạo thành chuỗi ký tự sau khi viết hoa chữ cái đầu tiên và1 dấu cách cho việc chuẩn hóa các từ sau
                afterFormat += first.ToUpper() + another + " ";
            }
            afterFormat = afterFormat.Remove(afterFormat.LastIndexOf(' '), 1); // xóa đi dấu cách thừa ở cuối khi thực hiện vòng lặp trên

            return afterFormat;
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

        public QuanLyBanhKeo()
        {
            _lstBanhKeo = new List<BanhKeo>();
            
        }


        public void NhapThongTin()
        {
            
            int checkTiepTuc = 0;
            string tiepTuc, chuanHoa;
            bool checkIDTrung = false;
            do
            {
                _banhKeo = new BanhKeo();
                _banhKeo.NhapBanhKeo();
                _lstBanhKeo.Add(_banhKeo);

                int soLuongPhanTu = _lstBanhKeo.Count;
                if (soLuongPhanTu > 1)
                {
                    for (int i = 0; i < soLuongPhanTu - 1; ++i)
                    {
                        for (int j = i + 1; j < soLuongPhanTu; ++j)
                        {
                            if (_lstBanhKeo[i].IdBanhKeo == _lstBanhKeo[j].IdBanhKeo)
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
                        Console.Write("\nDa luu thong tin!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Ma ID nay da bi trung truoc do, xin hay kiem tra lai!!\n");

                    checkIDTrung = false;
                    int demLai = _lstBanhKeo.Count;
                    _lstBanhKeo.RemoveAt(demLai - 1);

                }
                Console.WriteLine();
            } while (checkTiepTuc != 0);
        }

        public void TimKiemGia()
        {
            int demSoLuong = _lstBanhKeo.Count;
            if (demSoLuong == 0)
            {
                Console.WriteLine("Chua nhap thong tin!!!");
            }
            else
            {
                Console.Write("Nhap gia min: ");
                double min = Convert.ToDouble(Console.ReadLine());

                double max;
                do
                {
                    Console.Write("Nhap gia max: ");
                    max = Convert.ToDouble(Console.ReadLine());
                    if (max < min)
                        Console.WriteLine("Max nhap khong hop le!!");
                    else break;
                } while (true);
                

                bool check = false;

                for (int i = 0; i < demSoLuong; i++)
                {
                    if (_lstBanhKeo[i].GiaCaBanhKeo < min || _lstBanhKeo[i].GiaCaBanhKeo > max)
                    {
                        Console.WriteLine();
                        _lstBanhKeo[i].XuatBanhKeo();
                        check = true;
                    }
                }
                if (!check)
                {
                    Console.WriteLine("\nKhong tim thay thong tin nao!!!");
                }
            }
        }

        public void TimKiemTheoTen()
        {
            int demSoLuong = _lstBanhKeo.Count;
            if (demSoLuong == 0)
            {
                Console.WriteLine("Chua nhap thong tin!!!");
            }
            else
            {
                Console.Write("Nhap ten can tim kiem: ");
                string name = Console.ReadLine();
                
                for (int i = 0; i < demSoLuong; i++)
                {
                    if (_lstBanhKeo[i].TenBanhKeo.Equals(name))
                    {
                        Console.WriteLine();
                        _lstBanhKeo[i].XuatBanhKeo();
                        return;
                    }
                }

                Console.WriteLine("\nKhong tim thay thong tin nao!!!");
            }
        }

        public void TimKiemTheoHSD()
        {
            int demSoLuong = _lstBanhKeo.Count;
            if (demSoLuong == 0)
            {
                Console.WriteLine("Chua nhap thong tin!!!");
            }
            else
            {
                bool checkHSD = false;
                for (int i = 0; i < demSoLuong; i++)
                {
                    if (_lstBanhKeo[i].ConHan == 1)
                    {
                        Console.WriteLine();
                        _lstBanhKeo[i].XuatBanhKeo();
                        checkHSD = true;
                    }
                }
                if(!checkHSD)
                    Console.WriteLine("\nKhong tim thay thong tin nao!!!");
            }
        }

        public void XuatThongTin()
        {
            int demSoLuong = _lstBanhKeo.Count;
            if(demSoLuong > 0)
            {
                for(int i=0;i<demSoLuong;++i)
                {
                    Console.WriteLine();
                    _lstBanhKeo[i].XuatBanhKeo();
                }
            }
            else
            {
                Console.WriteLine("\nXin hay nhap thong tin!!!");
            }
        }
    }
}
