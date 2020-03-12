using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so luong phan tu:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            
            for (int i=0;i<n;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int Max1 = a[0];
            int Max2 = a[0];
            for (int i=0;i<n;i++)
            {
                if(Max1<a[i])
                {
                    Max1 = a[i];
                }
            }
            for(int i=0;i<n;i++)
            {
                if(Max1>a[i] && Max2<a[i])
                {
                    Max2 = a[i];
                }
            }
            Console.WriteLine("so lon thu hai trong day la:"+Max2);
            Console.ReadKey();
        }
    }
}
