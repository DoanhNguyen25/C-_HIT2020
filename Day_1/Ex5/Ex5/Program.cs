using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dem = 0;
            Console.WriteLine("nhap vao so nguyen n:");
            int n = int.Parse(Console.ReadLine());
            if(n<2)
            {
                Console.WriteLine("khong phai so nguyen to!!");
            }
            else if(n==2)
            {
                Console.WriteLine(" la so nguyen to");
            }
            else
            {
                for(int i=2;i<=Math.Sqrt(n);i++)
                {
                    if(n%i==0)
                    {
                        dem++;
                    }

                }
                if(dem!=0)
                {
                    Console.WriteLine("khong phai so nguyen to!!");
                }
                else
                {
                    Console.WriteLine("la so nguyen to");
                }
            }
            Console.ReadKey();
        }
    }
}
