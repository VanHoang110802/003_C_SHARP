using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKiemTra1
{
    internal class Phim1
    {
        private string maPhim, tenPhim, theLoai;
        private int namSX, trangThai;

        public Phim1()
        {

        }

        public Phim1(string maPhim, string tenPhim, string theLoai, int namSX, int trangThai)
        {
            this.maPhim = maPhim;
            this.tenPhim = tenPhim;
            this.theLoai = theLoai;
            this.namSX = namSX;
            this.trangThai = trangThai;
        }

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public int NamSX { get => namSX; set => namSX = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhap ma phim: ");
            maPhim = Console.ReadLine();
            Console.Write("Nhap ten phim: ");
            tenPhim = Console.ReadLine();
            Console.Write("Nhap nam san xuat phim: ");
            NamSX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap the loai phim: ");
            theLoai = Console.ReadLine();
            Console.Write("Nhap trang thai cua phim(1- dang chieu, 2 - ngung chieu): ");
            trangThai = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Ma phim: {maPhim}");
            Console.WriteLine($"Ten phim: {tenPhim}");
            Console.WriteLine($"Nam san xuat phim: {namSX}");
            Console.WriteLine($"The loai phim: {theLoai}");
            Console.WriteLine($"Trang thai cua phim: {(trangThai == 1 ? "Dang chieu" : "Ngung chieu")}");
        }
    }
}
