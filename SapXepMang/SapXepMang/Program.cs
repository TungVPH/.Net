using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10] { 1, 3, 34, 6, 88, 46, 12, 9, 48, 21 };
        int i;
        bubblesort(arr, 10);// goi thu tuc sap xep
        for (i = 0; i < 10; i++)
            Console.Write(arr[i] + "\t");
            Console.ReadLine();
    }
    //thuat toan bong bong
    public static void bubblesort(int[] data, int n)
    {
        int i, j;
        for(i=0;i<n;i++)
            for(j=n-1;j>i;j--)
                if (data[j] < data[j - 1]) // tang dan, giam dan (data[j] > data[j - 1])
                //su dung ham tam de sep xep
                {
                    int temp = data[j];
                    data[j] = data[j - 1];
                    data[j - 1] = temp;
                }
    }
}
