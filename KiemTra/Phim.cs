using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangtvph31092
{
    internal class Phim
    {
        private string maPhim, tenPhim, theLoaiPhim;
        private int namSXPhim;
        private int trangTrai;

        public Phim()
        {

        }

        public Phim(string maPhim, string tenPhim, string theLoaiPhim, int namSXPhim, int trangTrai)
        {
            this.maPhim = maPhim;
            this.tenPhim = tenPhim;
            this.theLoaiPhim = theLoaiPhim;
            this.namSXPhim = namSXPhim;
            this.trangTrai = trangTrai;
        }

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string TheLoaiPhim { get => theLoaiPhim; set => theLoaiPhim = value; }
        public int NamSXPhim { get => namSXPhim; set => namSXPhim = value; }
        public int TrangTrai { get => trangTrai; set => trangTrai = value; }

        public void NhapThongTinPhim()
        {
            Console.WriteLine("Vui long nhap thong tin chi tiet cho phim: ");
            Console.Write("Ma phim: ");
            maPhim = Console.ReadLine();
            Console.Write("Ten phim: ");
            tenPhim = Console.ReadLine();
            Console.Write("The loai phim: ");
            theLoaiPhim = Console.ReadLine();
            Console.Write("Nam san xuat phim: ");
            namSXPhim = Convert.ToInt32(Console.ReadLine());
            Console.Write("Trang thai cua phim(1-dang chieu, 2-ngung chieu): ");
            trangTrai = Convert.ToInt32(Console.ReadLine());

        }

        public string CheckTrangThai(int check)
        {
            return (check == 1 ? "Dang chieu" : "Ngung chieu");
        }
        public void XuatThongTinPhim()
        {
            Console.WriteLine($"Ma phim: {maPhim}");
            Console.WriteLine($"Ten phim: {tenPhim}");
            Console.WriteLine($"The loai phim: {theLoaiPhim}");
            Console.WriteLine($"Nam san xuat phim: {namSXPhim}");
            Console.WriteLine($"Trang thai cua phim: {CheckTrangThai(trangTrai)}");
        }
    }
}
