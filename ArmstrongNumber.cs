using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Armstrong Numbers (1-1000):");
        for (int n = 1; n <= 1000; n++)
            if (IsArmstrong(n))
                Console.WriteLine(n);

        Console.ReadKey(); 
    }

    static bool IsArmstrong(int num)
    {
        int sum = 0;
        for (int temp = num; temp > 0; temp /= 10)
        {
            int digit = temp % 10;
            sum += digit * digit * digit;
        }
        return sum == num;
    }
}
