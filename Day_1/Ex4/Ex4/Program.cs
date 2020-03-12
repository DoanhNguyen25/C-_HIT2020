using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so nguyen n:");
            int n = int.Parse(Console.ReadLine());
            int s1 = 0, s2 = 1, s3 = 0;
            for(int i=1;i<=n;i++)
            {
                s1 += i;
                s2 *= i;
                s3 += i * (i - 1);
            }
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
