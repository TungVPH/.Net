//Có một mảng hai chiều lưu trữ các giá trị trong các hàng và các cột
class Program
{
    static void Main(string[] args)
    {
        printSeries();
        Console.ReadLine();
    }

    public static void printSeries()
    {
        int[,] arr = new int[6, 6];
        int i, j;

        for (i = 0; i < 6; i++)
            for(j = 0; j < 6;j++)
             {
                if(i==0)
                    arr[i,j] = j+1;
                else if (i>0 && j==0)
                {
                    arr[i,j] = arr[i-1,5]+1;
                }
                else
                    arr[i,j] = arr[i,j- 1] + 1;
            }
        for (i = 0; i < 6; i++)
        {
            for(j=0;j<6;j++)
            {
                Console.Write("{0}\t",arr[i,j]);                   
            }
            Console.WriteLine();
        }
    }
}
