using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        struct Date
        {
            public int day, month, year;
        };
        struct Student
        {
            public string Id;
            public string name;
            public Date DoB;
        };
        static void input1SV( out Student sv)
        {
            Console.WriteLine("Nhap ma sinh vien:");
            sv.Id = Console.ReadLine();
            Console.WriteLine("Nhap ho va ten: ");
            sv.name = Console.ReadLine();
            Console.WriteLine("Nhap ngay thang nam sinh: ");
            sv.DoB.day = int.Parse(Console.ReadLine());
            sv.DoB.month = int.Parse(Console.ReadLine());
            sv.DoB.year = int.Parse(Console.ReadLine());
        }
        static void output1SV(Student sv)
        {
            Console.WriteLine("Ma sinh vien : "+sv.Id);
            Console.WriteLine("Ho va ten la: "+sv.name);
            Console.WriteLine("Ngay thang nam sinh : "+sv.DoB.day+"/"+sv.DoB.month+"/"+sv.DoB.year);
        }
       
        static void Main(string[] args)
        {
            //Student sv1 = new Student();
            Console.WriteLine("nhap so luong sinh vien :");
            int n = int.Parse(Console.ReadLine());
            Student[] a = new Student[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Nhap thong tin sv thu "+ (i+1) +" la:");
                input1SV(out a[i]);
            }
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("Sinh vien thu " + (i + 1) + " la:");
                output1SV(a[i]);
                Console.WriteLine("==============================\n");
            }


            Console.WriteLine("\n\nDanh sach sau khi sap xep la:");
            for(int i=0;i<n-1;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if(a[i].DoB.year > a[j].DoB.year)
                    {
                        Student temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }


            for(int i=0;i<n;i++)
            {
                output1SV(a[i]);
            }




            Console.ReadKey();
        }
    }
}
