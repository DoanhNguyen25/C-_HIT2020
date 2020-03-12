using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("nhap do dai canh a:");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("\nnhap do dai canh b:");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("\nnhap do dai canh c:");
                float c = float.Parse(Console.ReadLine());
            
            if(a>0 && b>0 && c>0 && a+b>c && a+c>b && c+b>a)
            {
                if(a==b && b==c && c==a )
                {
                    Console.WriteLine("tam giac deu");
                }
                else if((a == b || b == c || c == a) && (a*a+b*b==c*c ||b*b+c*c==a*a||a*a+c*c==b*b))
                {
                    Console.WriteLine("tam giac vuong can");
                }
                else if(a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b)
                {
                    Console.WriteLine("tam giac vuong");
                }
                else if(a==b || b==c || c==a)
                {
                    Console.WriteLine("tam giac can");
                }
                else
                {
                    Console.WriteLine("tam giac");
                }

            }
            else
            {
                Console.WriteLine("khong phai la tam giac!!!!!!");
            }
            Console.ReadKey();
        }
    }
}
