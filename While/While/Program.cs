using System;
//chọn câu trả lời đúng từ danh sách các lựa chọn của câu hỏi.
class Program
{
    static void Main(string[] args)
    {
        string choice;
        string con = "y";
       
        Console.WriteLine("Từ khoá nào để kết thúc vòng lặp trong C#?");
        Console.WriteLine("a. Quit");
        Console.WriteLine("b. Continue");
        Console.WriteLine("c. Break");
        Console.WriteLine("d. exit");

        //while(con=="y")
        //{
        //    Console.WriteLine("Nhập vào câu trả lời: ");
        //    choice = Console.ReadLine();
        //    if (choice == "c")
        //    {
        //        Console.WriteLine("Chúc mừng bạn trả lời đúng");
        //    }
        //    else if (choice == "q" || choice == "r")
        //    {
        //        Console.WriteLine("Kết thúc ...!");
        //        break;
        //    }
        //    else
        //        Console.WriteLine("Không đúng!!");
        //    Console.Write("Thêm lượt nữa? Ấn y để tiếp tục.");
        //    con= Console.ReadLine().ToString();
        //}

        do
        {
            Console.WriteLine("Nhập vào câu trả lời: ");
            choice = Console.ReadLine();
            if (choice == "c")
            {
                Console.WriteLine("Chúc mừng bạn trả lời đúng");
            }
            else if (choice == "q" || choice == "r")
            {
                Console.WriteLine("Kết thúc ...!");
                break;
            }
            else
                Console.WriteLine("Không đúng!!");
            Console.Write("Thêm lượt nữa? Ấn y để tiếp tục.");
            con = Console.ReadLine().ToString();
        }
        while(con== "y");
    }
}