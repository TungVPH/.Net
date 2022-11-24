using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toanTu
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Nhap gia tri 1:");
            x= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri 2: ");
            y= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri 3: ");
            z= int.Parse(Console.ReadLine());
            if (x > y)
                if (x > z) Console.WriteLine("Gia tri lon nhat la: {0}.", x);
                else Console.WriteLine("Gia tri lon nha la: {0}.", z);
            else if (y > z) Console.WriteLine("Gia tri lon nhat la: {0}.", y);
            else Console.WriteLine("Gia troj lon nhat la: {0}.", z);
            Console.ReadLine();

        }
    }
}
