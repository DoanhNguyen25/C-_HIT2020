using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so nguyen n");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            Console.Write(n+" = ");
            while(n!=0)
            {
                if(n%i==0)
                {
                    Console.Write(i);
                    n /= i;
                    if(n!=1)
                    {
                        Console.Write(" x ");
                    }
                }
                else
                {
                    i++;
                }
            }
            Console.ReadKey();
        }
    }
}
