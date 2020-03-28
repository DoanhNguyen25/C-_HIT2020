using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class TaiSan
    {
        private string nameTs;
        private int soLuong;
        private string tinhTrang;

        public string Name { get => nameTs; set => nameTs = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public void NhapInfor()
        {
            Console.WriteLine("Nhap ten tai san :");
            this.nameTs = Console.ReadLine();
            Console.WriteLine("Nhap so luong tai san :");
            this.soLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tinh trang cua tai san :");
            this.tinhTrang = Console.ReadLine();
        }
        public void XuatInfor()
        {
            Console.WriteLine(this.nameTs + " - " + this.soLuong + " - " + this.tinhTrang);
        }
    }
}
