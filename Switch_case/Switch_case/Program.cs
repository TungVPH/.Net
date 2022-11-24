using System;

class Program
{
    static void Main(string[] args)
    {
        //int key;
        //Console.Write("Nhap thang: ");
        //key = (int) Console.Read();

        //switch (key)
        //{
        //    case 1:
        //        Console.WriteLine("Thang Mot"); break;
        //    case 2:
        //        Console.WriteLine("Thang Hai"); break;
        //    case 3:
        //        Console.WriteLine("Thang Ba"); break;
        //    case 4:
        //        Console.WriteLine("Thang Tu"); break;
        //    case 5:
        //        Console.WriteLine("Thang Nam"); break;
        //    case 6:
        //        Console.WriteLine("Thang Sau"); break;
        //    case 7:
        //        Console.WriteLine("Thang Bay"); break;
        //    case 8:
        //        Console.WriteLine("Thang Tam"); break;
        //    case 9:
        //        Console.WriteLine("Thang Chin"); break;
        //    case 10:
        //        Console.WriteLine("Thang Muoi"); break;
        //    case 11:
        //        Console.WriteLine("Thang Muoi Mot"); break;
        //    case 12:
        //        Console.WriteLine("Thang Muoi Hai"); break;
        //    default: 
        //        Console.WriteLine("Khong hop le!!"); break;
        //}
        Console.Write("Nhap Thang: ");
        string Sthang = Console.ReadLine();
        Console.Write("Nhap Nam: ");
        string Snam = Console.ReadLine();

        int th = int.Parse(Sthang);
        int nm = int.Parse(Snam);
        int songay = 0;

        if (th >= 1 && th <= 12)
        {
            switch (th)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    songay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    songay = 30;
                    break;
                case 2:
                    if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))
                        songay = 29;
                    else
                        songay = 28;
                    break;
            }
            Console.Write("=> Thang " +th+ "/" + nm + " co " + songay+" ngay\n");
        }
        else
            Console.Write("=> Thang Khong Hop Le !!");
        Console.ReadLine();

 
    }
}