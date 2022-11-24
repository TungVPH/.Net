using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBacHai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a,b,c,root1, root2, delta;
            string con = "y";
            Console.WriteLine("Nhap vao he so a, b, c cua phuong trinh ax2 + bx + c");
            Console.Write("Nhap a: ");
            a= Double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b= Double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c= Double.Parse(Console.ReadLine());

            //tinh delta cua phuong trinh
            delta = b * b - 4 * a * c;
            if (delta > 0)
            { 
                    //Nghiem dac biet
                    root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co 2 nghiem dac biet: ");
                    Console.WriteLine("X1 = " + root1, "X2 = " + root2);
                }
                else if (delta == 0)
                {
                    //Nghiem kep
                    root1 = root2 = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep:");
                    Console.WriteLine("X1 = X2" + root2);
                }
                else
                    Console.WriteLine("Phuong trinh vo nghiem!!!");
                Console.ReadLine();
        }
        
    }
}
