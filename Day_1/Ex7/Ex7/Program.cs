using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thuc c:");
            float c = float.Parse(Console.ReadLine());
            float mu = 1, gt = 1, Ex = 0,i=0;
            while(Math.Abs(mu/gt)<c)
            {
                Ex += mu / gt;
                mu *= x;
                gt*=i;
                i++;
            }
            Console.WriteLine("e^x= " + Ex);
            Console.ReadKey();

        }
    }
}
