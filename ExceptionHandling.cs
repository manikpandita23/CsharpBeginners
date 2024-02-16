using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        // Print array elements
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        try
        {
            // Access an out-of-bounds index (7th element)
            Console.WriteLine(arr[7]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"An Exception has occurred: {e.Message}");
        }

        // Wait for user input before exiting
        Console.ReadKey();
    }
}
