using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Ngay
    {
        private int day, month, year;

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public void nhapInfor()
        {
            Console.WriteLine("Nhap ngay :");
            this.Day = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang :");
            this.Month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam :");
            this.Year = int.Parse(Console.ReadLine());
        }
        public void xuatInfor()
        {
            Console.WriteLine(this.day+"/"+this.month+"/"+this.year);

        }
    }
}
