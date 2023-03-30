using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaiTap3
{
    internal class Sach
    {
        private int idSach, soLuong;
        private string tenSach, tenTacGia, isNew;
        private NgayThangNam _ntn = new NgayThangNam();

       

        public Sach()
        {
            
        }

        public Sach(int idSach, int soLuong, string tenSach, string tenTacGia, string isNew)
        {
            this.idSach = idSach;
            this.soLuong = soLuong;
            this.tenSach = tenSach;
            this.tenTacGia = tenTacGia;
            this.isNew = isNew;
        }

        public int IdSach { get => idSach; set => idSach = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public string IsNew { get => isNew; set => isNew = value; }
       
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

                // tạo thành chuỗi ký tự sau khi viết hoa chữ cái đầu tiên và dấu cách cho việc chuẩn hóa các từ sau
                afterFormat += first.ToUpper() + another + " ";
            }
            afterFormat = afterFormat.Remove(afterFormat.LastIndexOf(' '), 1); // xóa đi dấu cách thừa ở cuối khi thực hiện vòng lặp trên

            return afterFormat;
        }

        public int CheckInput(string input, string s1, string s2)
        {
            if (input.Equals(s1))
                return 1;

            else if (input.Equals(s2))
                return 0;

            else
                return -1;
        }

        public void NhapThongTin()
        {
            Console.WriteLine("Vui long nhap thong tin chi tiet:");
            Console.Write("Ma ID cua sach: ");
            idSach = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ten sach: ");
            tenSach = Console.ReadLine();
            Console.WriteLine("Ngay thang nam xuat ban:");
            _ntn.NhapTime();
            Console.Write("Ten tac gia: ");
            tenTacGia = Console.ReadLine();
            Console.Write("So luong sach: ");
            soLuong = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write("La sach cu hay sach moi?(Cu/Moi): ");
                isNew = Console.ReadLine();
                string chuanHoa = ChuanHoaChuoi(isNew);
                int checkInput = CheckInput(chuanHoa, "Moi", "Cu");
                if (checkInput == 1 || checkInput == 0)
                {
                    isNew = chuanHoa;
                    break;
                }
                else
                {
                    Console.WriteLine("Lua chon nhap khong hop le, xin hay kiem tra lai!!");
                }
            } while (true);
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Ma ID cua sach: {idSach}");
            Console.WriteLine($"Ten cua sach: {tenSach}");
            Console.WriteLine("Ngay thang nam xuat ban cua sach: ");
            _ntn.XuatTime();
            Console.WriteLine($"Ten tac gia cua sach: {tenTacGia}");
            Console.WriteLine($"So luong sach: {soLuong}");
            Console.WriteLine($"Toan la sach {(isNew)}");
        }
    }
}
