using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, fact = 1;
            Console.WriteLine("Nhap vao so tinh giai thua: ");
            n = Int32.Parse(Console.ReadLine());
            //fact = 1*2*3... (n-1)*n
            for (int i=1; i <= n; i++)
            {
                fact *=i;
            }
            Console.WriteLine("Ket qua giai thua la: "+ fact);
            Console.ReadLine();// hien thi cua so
            
        }
    }
}
