using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        for (int i = 1, num = 1; i <= rows; Console.WriteLine(), i++)
            for (int j = 0; j < i; Console.Write($"{num++,3} "), j++) ;

        Console.ReadKey();
    }
}
