using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10; int y = 20;

        Console.WriteLine("Ket qua: ");
        Console.WriteLine("Gia tri x\t\tGia tr y\t\tBieu thuc\tKet qua");
        Console.WriteLine("{0,-20} \t {1,-20} \t x=y+3 \t\t x={2,-20}", x, y, y + 3);
        Console.WriteLine("{0,-20} \t {1,-20} \t x=y-2 \t\t x={2,-20}", x, y, y - 2);
        Console.WriteLine("{0,-20} \t {1,-20} \t x=y*5 \t\t x={2,-20}", x, y, y * 5);
        Console.WriteLine("{0,-20} \t {1,-20} \t x=x/y \t\t x={2,-20}", x, y, (float)x / y);
        Console.WriteLine("{0,-20} \t {1,-20} \t x=x%y \t\t x={2,-20}", x, y, x % y);
        Console.ReadLine();
    }
}