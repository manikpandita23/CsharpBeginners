using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        Console.WriteLine("All substrings:");
        for (int i = 1; i <= inputString.Length; i++)
        {
            for (int j = 0; j <= inputString.Length - i; j++)
            {
                Console.WriteLine(inputString.Substring(j, i));
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
