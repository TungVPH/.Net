using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoNguyenTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1,n, i = 2;
            Console.WriteLine("Nhap so can kiem tra n: ");
            n = int.Parse(Console.ReadLine());
            for(i=2;i<=n/2;i++)
            {
                if(n%i==0)
                {
                    k=0;break;
                }
                
            }
            if(k==1)
            {
                Console.WriteLine("So nay la so nguyen to");
            }
            else
            { 
                Console.WriteLine("So nay khong phai la so nguyen to");
            }
            Console.ReadLine();
        }
    }
}
