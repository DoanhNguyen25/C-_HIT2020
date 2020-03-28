using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            TamThucB2 x1 = new TamThucB2();
            TamThucB2 x2 = new TamThucB2();
            TamThucB2 kq1 = new TamThucB2();
            TamThucB2 kq2 = new TamThucB2();
            x1.nhapInfor();
            x1.xuatInfor();
            Console.WriteLine("\n");
            x2.nhapInfor();
            x2.xuatInfor();
            Console.WriteLine("bieu thuc x1 khi chuyen doi la:");
            x1.chuyenDoi();
            x1.xuatInfor();
            Console.WriteLine("\n bieu thuc x2 khi chuyen doi la:");
            x2.chuyenDoi();
            x2.xuatInfor();
            Console.WriteLine(" \nbieu thuc sau khi cong la :\n");
            kq1 = x1 + x2;
            kq1.xuatInfor(kq1);
            Console.WriteLine(" \nbieu thuc sau khi tru la :\n");
            kq2 = x1 - x2;
            kq2.xuatInfor(kq2);


            Console.ReadKey();
        }
    }
}
