using System;
using System.IO;
class Program
{
    static void Main()
    {
        string sourceFilePath = "file1.txt";
        string destinationFilePath = "file2.txt";

        try
        {
            File.Copy(sourceFilePath, destinationFilePath);
            Console.WriteLine("File contents copied successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }

        // Wait for user input before exiting
        Console.ReadKey();
    }
}
