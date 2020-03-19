using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static  bool checkPrime (int n)
        {
            if(n<2)
            {
                return false;
            }
            else if(n==2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n);i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
        }
        static void Nhap( int [] a,  int n)
        {
            
            for(int i=0;i<n;i++)
            {
                Console.Write("a["+i+"]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat(int [] a, int n)
        {
            for(int i=0;i<n;i++)
            {
                int vt = i + 1;
                if(checkPrime(vt)==true)

                {
                    Console.WriteLine(a[vt-1]+" ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so luong phan tu");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Nhap(a, n);
            Console.WriteLine("Phan tu tai vi tri x (x la so nguyen to la):");
            Xuat(a, n);
            Console.ReadKey();
        }
    }
}
