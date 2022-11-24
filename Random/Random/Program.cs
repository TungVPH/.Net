// ( từ 1 đến 6) được tạo ra một cách ngẫu nhiên từ máy tính.
using System;

class Program
{
    static void Main(string[] args)
    {
        ranguess();
        Console.ReadLine();
    }
    public static void ranguess()
    {
        int yn, rn;
        int con = 1;
        Random rd = new Random();
        while (con == 1)
        {
            Console.WriteLine("Nhap vao so ban doan: ");
            yn = int.Parse(Console.ReadLine());
            rn = rd.Next(1, 7);
            Console.WriteLine(rn);
            if (yn == rn)
            {
                Console.WriteLine("Ban da Win...!!");
            }
            else
            {
                Console.WriteLine("Ban da thua!!!");
                Console.WriteLine("So cua ban la {0}.", rn);
            }
            Console.WriteLine("An phim 1 de tiep tuc!");
            con = int.Parse(Console.ReadLine());
        }
    }
}
