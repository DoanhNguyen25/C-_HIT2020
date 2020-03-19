using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void inputX(out double x)
        {
            do
            {
                Console.WriteLine("Nhap vao so thuc x:");
                x = double.Parse(Console.ReadLine());
            }while( x <= 0);
        }

        static void inputN(out int n)
        {
            do
            {
                Console.WriteLine("Nhap vao so nguyen n(5<=n<=20:");
                n = int.Parse(Console.ReadLine());
            } while (n < 5 || n > 20);
        }

        static void inputA(out float A)
        {
            Console.WriteLine("Nhap vao so thuc A:");
            A = float.Parse(Console.ReadLine());
        }

        static double xAndK(double x, int k)
        {
            return Math.Sqrt(Math.Pow(x, k));
        }
        static double process_S(float A, int n, double x)
        {
            double s =A;
            int k = 1;
            for(int i=n;i>0;i--)
            {
                s +=Math.Pow(-1, n)*xAndK(x,k++)/i;
            }
            return s;
        }
        
        static void Main(string[] args)
        {
            int n; 
            float A; double x;
            inputA(out A);
            inputN(out n);
            inputX(out x);
            Console.WriteLine("S= "+process_S(A,n,x));
            Console.ReadKey();
        }
    }
}
