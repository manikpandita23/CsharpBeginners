using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        int num = 1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write($"{num++,3} ");
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
