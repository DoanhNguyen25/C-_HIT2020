using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HANGHOA
    {
        private string maHang;
        private string tenHang;
        private long donGia;
        private int soLuong;


        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public long DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public void nhapInfor()
        {
            Console.WriteLine("nhap ma hang :");
            this.MaHang = Console.ReadLine();
            Console.WriteLine("nhap ten hang : ");
            this.TenHang = Console.ReadLine();
            Console.WriteLine("nhap don gia : ");
            this.DonGia = long.Parse(Console.ReadLine());
            Console.WriteLine("nhap so luong : ");
            this.SoLuong = int.Parse(Console.ReadLine());
        }

        public void XuatInfor()
        {
            Console.WriteLine(this.MaHang + "-" + this.TenHang + "-" + this.SoLuong + "-" + this.DonGia + " - Thanh tien:" + this.SoLuong*this.DonGia);
        }
    }
}
