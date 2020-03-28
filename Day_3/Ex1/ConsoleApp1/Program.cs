using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so luong hang : ");
            int n = int.Parse(Console.ReadLine());
            HANGHOA[] hangs = new HANGHOA[n];
            for(int i=0; i < n; i++)
            {
                hangs[i] = new HANGHOA();
                hangs[i].nhapInfor();
            }
            for (int i = 0; i < hangs.Length; i++)
            {
                hangs[i].XuatInfor();
            }
            Console.WriteLine("\nsau khi sap xep:\n");
            for (int i=0; i < hangs.Length-1; i++)
            {
                for(int j=i+1; j < hangs.Length; j++)
                {
                    if( (hangs[i].SoLuong*hangs[i].DonGia) > (hangs[j].SoLuong * hangs[j].DonGia))
                    {
                        HANGHOA temp = hangs[i];
                        hangs[i] = hangs[j];
                        hangs[j] = temp;
                    }    
                }    
            }   
            for(int i=0;i<hangs.Length;i++)
            {
                hangs[i].XuatInfor();
            }    
            Console.ReadKey();
        }
    }
}
