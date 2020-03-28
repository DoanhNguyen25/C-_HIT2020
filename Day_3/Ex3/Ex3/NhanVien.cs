using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class NhanVien
    {
        private string nameNv;
        private string chucVU;

        public string Name { get => nameNv; set => nameNv = value; }
        public string ChucVU { get => chucVU; set => chucVU = value; }


        public void nhapInfor()
        {
            Console.WriteLine("Nhap ten nhan vien :");
            this.Name = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu cua nhan vien :");
            this.ChucVU = Console.ReadLine();

        }
        public void xuatInfor()
        {
            Console.WriteLine(this.nameNv+ " - " + this.chucVU);
        }
    }
}
