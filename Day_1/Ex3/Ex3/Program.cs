using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so nguyen n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac uoc cua n la:");
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    Console.Write(i);
                    if(i!=n)
                    {
                        Console.Write(",");
                    }
                }
                    
            }
            Console.ReadKey();
        }
    }
}
