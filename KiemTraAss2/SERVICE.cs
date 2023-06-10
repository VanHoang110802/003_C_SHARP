using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    internal class SERVICE
    {
        NhanVien _nhanVien;
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

        public void NhapDanhSach(List<NhanVien> lstNhanVien)
        {
            int check = -1;
            string tiepTuc;
            do
            {
                _nhanVien = new NhanVien();
                _nhanVien.NhapThongTin();
                lstNhanVien.Add(_nhanVien);

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

        public void XuatDanhSach(List<NhanVien> lstNhanVien)
        {
            if (lstNhanVien.Count == 0)
            {
                Console.WriteLine("Xin hay nhap thong tin!!");
                return;
            }
            foreach (var item in lstNhanVien)
            {
                item.XuatThongTin();
            }
        }

        public void GhiFile(string path, List<NhanVien> lstNhanVien)
        {
            if (File.Exists(path))
            {
                foreach (var item in lstNhanVien)
                {
                    //tạo ra 1 dòng để lưu thông tin của 1 item trong lstNhanVien
                    string line = item.ObjToString();
                    //thêm tiếp dòng mới này vào file
                    File.AppendAllText(path, line);
                }
                Console.WriteLine("Ghi file thành công!!!");
            }
            else
            {
                Console.WriteLine("File ko tồn tại!!!");
            }
        }
        public List<NhanVien> DocFile(string path)
        {

            var f = new FileInfo(path);
            if (f.Length == 0)
            {
                return null;
            }
            else
            {
                List<NhanVien> lstNhanVien = new List<NhanVien>();
                //đọc tất cả các dòng trong file txt
                string[] lines = File.ReadAllLines(path);
                //duyệt từng dòng line
                foreach (var line in lines)
                {
                    if (line.Trim().Length == 0)
                    {
                        continue;//bỏ qua vòng hiện tại -> vòng sau
                    }
                    else
                    {
                        //cắt dòng line thành nhiều chuỗi con
                        //ngăn cách nhau bởi dấu |
                        string[] attributes = line.Split('|');

                        //mỗi dòng line là 1 NhanVien
                        NhanVien st = new NhanVien();
                        st.IdNhanVien = attributes[0].Trim();
                        st.HoTenNhanVien = attributes[1].Trim();
                        st.SoDienThoai = attributes[2].Trim();
                        st.LuongNhanVien = Convert.ToDouble(attributes[3].Trim());

                        //thêm đối tượng vào danh sách
                        lstNhanVien.Add(st);
                    }
                }
                return lstNhanVien;
            }
        }

        public void LINQ(string path, List<NhanVien> lstNhanVien)
        {
            if (File.Exists(path))
            {
                List<NhanVien> lst = DocFile(path);

                if (lst == null)
                {
                    Console.Write("Hay chac chan rang ban da ghi data vao file!!!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("--------- Sap xep theo ten ----------");
                    var sortName = lstNhanVien.OrderBy(s => s.HoTenNhanVien);
                    
                    foreach (var item in sortName)
                    {
                        item.XuatThongTin();
                    }

                    Console.WriteLine("\n");
                    var sortType = from m in lst
                                   orderby m.LuongNhanVien ascending
                                   select m;
                    Console.WriteLine("--------- Sap xep luong tang dan ----------");
                    foreach (var item in sortType)
                    {
                        item.XuatThongTin();

                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("File ko tồn tại!!!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
