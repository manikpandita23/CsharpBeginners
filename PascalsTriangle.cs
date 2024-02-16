using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        int numRows = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numRows; i++)
        {
            long value = 1;
            for (int j = 0; j <= i; j++)
            {
                Console.Write(value + " ");
                value = value * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
