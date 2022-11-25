using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongDaySo
{
    //Nhập vào giá trị x, cần phải tính biểu thức:
    //tong = 1 – x2 / 2! + x4 / 4! – x6 / 6! + x8 / 8! – x10 / 10!
    internal class Program
    {
        static void Main(string[] args)
        {
            double  x, y, v, tong;
            int i, j;
            long gt;

            Console.WriteLine("Nhap vao gia tri x: ");
            x =double.Parse(Console.ReadLine());
            tong = 1;
            for(i=1;i<=5;i++)
            {
                y = Math.Pow(-1,i) * Math.Pow(x,2*i);
                gt = 1;
                for (j = 1; j <= 2; j++)
                {
                    gt = gt * j;
                }
                v = y / gt;
                tong = tong + v;                   
            }
            Console.WriteLine("Tong day so: {0}" , tong);
            Console.ReadLine();
        }
    }
}
