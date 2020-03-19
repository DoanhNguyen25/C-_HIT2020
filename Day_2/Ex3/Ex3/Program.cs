using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static string [] a;
        static void split(string s)
        {
           
            a = s.Split(' ');
            Console.Write("(arr={");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i < (a.Length - 1))
                {
                    Console.Write(',');
                }
            }
            Console.Write("})");
        }
        static void showInfor()
        {

           
            Console.WriteLine("\n\nHo:"+a[0]);
            Console.WriteLine("Ten :"+a[a.Length-2]);
            Console.Write("Ten Dem:");
            for(int i=1;i<a.Length-2;i++)
            {
                Console.Write(a[i]+" ");
            }
            //Console.WriteLine("Dem :"+a[a.Length-1]);
            Console.WriteLine("\nTuoi: "+age());
        }
        static int age()
        {
            return 2020 - int.Parse(a[a.Length - 1]);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi");
            string  s = Console.ReadLine();
            split(s);
            showInfor();
           
     
            Console.ReadKey();
           
        }
    }
}
