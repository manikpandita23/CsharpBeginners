using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Armstrong Numbers (1-1000):");
        for (int n = 1; n <= 1000; n++)
            if (IsArmstrong(n)) Console.WriteLine(n);
        Console.ReadKey();
    }

    static bool IsArmstrong(int num)
    {
        int sum = 0, temp = num;
        while (num > 0)
        {
            int digit = num % 10;
            sum += digit * digit * digit;
            num /= 10;
        }
        return sum == temp;
    }
}
