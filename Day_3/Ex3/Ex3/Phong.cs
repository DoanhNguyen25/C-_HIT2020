using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Phong
    {
        private string namePhong;
        private string maPhong;
        private string truongPhong;

        public string NamePhong { get => namePhong; set => namePhong = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TruongPhong { get => truongPhong; set => truongPhong = value; }

        public void nhapInfor()
        {
            Console.WriteLine("Nhap ten phong :");
            this.NamePhong = Console.ReadLine();
            Console.WriteLine("Nhap ma phong :");
            this.MaPhong = Console.ReadLine();
            Console.WriteLine("Nhap ten truong phong :");
            this.TruongPhong = Console.ReadLine();
        }
        public void xuatInfor()
        {
            Console.WriteLine(this.namePhong+" - "+this.maPhong+" - "+this.truongPhong);
        }
    }
}
