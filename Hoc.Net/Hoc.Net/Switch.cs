class SwitchDemo
{
    public static void Main()
    {
        int i = 1, j = 1;

        switch (j)
        {
            case 0: Console.WriteLine("m is 0"); break;
            case 1: Console.WriteLine("m is 1"); break;
            case 2: Console.WriteLine("m is 2"); break;
            default: Console.WriteLine("m is not 0, 1 or 2"); break;
        }
        switch (j)
        {
            case 0: case 1: Console.WriteLine("n is 0 or 1"); break;
            case 2: case 3: Console.WriteLine("n is 2 or 3"); break;
            case 4: case 5: Console.WriteLine("n is 4 or 5"); break;
            default: Console.WriteLine("n is not 1,2,3,4, or 5"); break;
        }
    }
}