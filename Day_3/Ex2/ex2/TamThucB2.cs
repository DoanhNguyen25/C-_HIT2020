using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class TamThucB2
    {
        private float a;
        private float b;
        private float c;

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }
        public float C { get => c; set => c = value; }

        public void nhapInfor()
        {
            Console.WriteLine("nhap so thuc a :");
            this.A = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thuc b :");
            this.B = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thuc c :");
            this.C = float.Parse(Console.ReadLine());
        }


        public void xuatInfor()
        {
            Console.WriteLine(this.A + "x^2 " + this.B + "x " + this.C);
        }


        public void chuyenDoi()
        {
            this.A *= -1;
            this.B *= -1;
            this.C *= -1;




        }
        public void xuatInfor( TamThucB2 a)
        {
            Console.WriteLine(a.A + "x^2 " + a.B + "x " + a.C);
        }

        static public TamThucB2 operator + ( TamThucB2 x1, TamThucB2 x2)
        {
            TamThucB2 tong = new TamThucB2();
            tong.A = x1.A + x2.A;
            tong.B = x1.B + x2.B;
            tong.C = x1.C + x2.C;
            return tong;
        }

        static public tamthucb2 operator -(tamthucb2 x1, tamthucb2 x2)
        {
            tamthucb2 hieu = new tamthucb2();
            hieu.a = x1.a - x2.a;
            hieu.b = x1.b - x2.b;
            hieu.c = x1.c - x2.c;
            return hieu;
        }
    }
}
