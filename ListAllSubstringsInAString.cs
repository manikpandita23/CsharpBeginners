using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        Console.WriteLine("All substrings:");
        for (int length = 1; length <= inputString.Length; length++)
            for (int start = 0; start <= inputString.Length - length; start++)
                Console.WriteLine(inputString.Substring(start, length));

        Console.ReadKey();
    }
}
