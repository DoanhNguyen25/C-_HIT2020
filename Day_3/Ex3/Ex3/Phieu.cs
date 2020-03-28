using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Phieu
    {
        private string maPhieu;
        private Phong Phong;
        private Ngay ngayLap;
        private NhanVien NV;
        private TaiSan[] x;
        private int n;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        internal Phong Phong1 { get => Phong; set => Phong = value; }
        internal Ngay NgayLap { get => ngayLap; set => ngayLap = value; }
        internal NhanVien NV1 { get => NV; set => NV = value; }
        internal TaiSan[] X { get => x; set => x = value; }

        public  void nhapInfor()
        {
            Console.WriteLine("Nhap ma phieu :");
            this.maPhieu = Console.ReadLine();
            Console.WriteLine("Nhap ngay kiem ke :");
            ngayLap = new Ngay();
            ngayLap.nhapInfor();
            Console.WriteLine("Nhap thong tin nhan vien");
            NV = new NhanVien();
            NV.nhapInfor();
            Console.WriteLine("Nhap thong tin phong :");
            Phong = new Phong();
            Phong.nhapInfor();
            Console.WriteLine("nhap so luong tai san :");
            this.n = int.Parse(Console.ReadLine());
            x = new TaiSan[n];
            for(int i=0; i<n; i++)
            {
                x[i] = new TaiSan();
                Console.WriteLine("Tai san thu "+(i+1));
                x[i].NhapInfor();
            }    

        }
        public int tongSoLuong()
        {
            int sum = 0;
            for(int i=0;i<n;i++)
            {
                sum += x[i].SoLuong;
            }
            return sum;
        }

        public void xuatInfor()
        {
            Console.WriteLine("========================================");
            int dem = 0;
            Console.WriteLine("tai san thu "+(dem+1));
            Console.WriteLine("ma phieu :"+this.MaPhieu);
            ngayLap.xuatInfor();
            NV.xuatInfor();
            Phong.xuatInfor();
            foreach(TaiSan i in x)
            {
                i.XuatInfor();
                dem++;
            }
            Console.WriteLine("So tai san da ke la: "+n);
            Console.WriteLine("tong so luong tai san la: "+tongSoLuong());

        }
    }
}
