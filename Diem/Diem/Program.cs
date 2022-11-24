using System;
class Program
{

    static void Main(string[] args)
    {
        float diem_cc, diem_gk, diem_ck, diem_tb;

        Console.WriteLine("Nhap diem chuyen can: ");
        diem_cc = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap diem giua ky:");
        diem_gk = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap diem cuoi ky:");
        diem_ck = float.Parse(Console.ReadLine());

        diem_tb = (float)(diem_cc * 0.1 + diem_gk * 0.3 + diem_ck * 0.6);
        if (diem_tb >= 9)
            Console.WriteLine("Tong diem: {0}. \nXep loai A.",diem_tb);
        else if ((diem_tb >= 7) && (diem_tb <= 9))
            Console.WriteLine("Tong diem: {0}. \nXep loai B.", diem_tb);
        else if ((diem_tb >= 5) && (diem_tb <= 7))
            Console.WriteLine("Tong diem: {0}. \nXep loai C.", diem_tb);
        else 
            Console.WriteLine("Tong diem: {0}. \nXep loai D.", diem_tb);
        
        Console.ReadLine();

    }
}
