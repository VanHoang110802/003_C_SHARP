using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap6
{
    internal class KeoBanh
    {
        private int codeKB;
        private string tenKB, tenHangSanXuat;
        private int soLuong;
        private bool trangThai;

        public KeoBanh()
        {

        }

        public KeoBanh(int codeKB, string tenKB, string tenHangSanXuat, int soLuong, bool trangThai)
        {
            this.codeKB = codeKB;
            this.tenKB = tenKB;
            this.tenHangSanXuat = tenHangSanXuat;
            this.soLuong = soLuong;
            this.trangThai = trangThai;
        }

        public int CodeKB { get => codeKB; set => codeKB = value; }
        public string TenKB { get => tenKB; set => tenKB = value; }
        public string TenHangSanXuat { get => tenHangSanXuat; set => tenHangSanXuat = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public void NhapThongTin()
        {
            Console.Write("Nhap code cua keo banh: ");
            codeKB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten keo banh: ");
            tenKB = Console.ReadLine();
            Console.Write("Nhap ten hang san xuat: ");
            tenHangSanXuat = Console.ReadLine();
            Console.Write("Nhap so luong keo banh: ");
            soLuong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap trang thai cua mat hang(true - con han/false - het han): ");
            trangThai = Convert.ToBoolean(Console.ReadLine());
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Ma code cua keo banh: {codeKB}");
            Console.WriteLine($"Ten cua keo banh: {tenKB}");
            Console.WriteLine($"Ten hang san xuat: {tenHangSanXuat}");
            Console.WriteLine($"So luong keo banh: {soLuong}");
            Console.WriteLine($"Tinh trang cua keo banh: {(trangThai ? "con han" : "het han")}");
        }

       
    }
}
