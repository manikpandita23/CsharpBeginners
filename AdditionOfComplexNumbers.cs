using System;
public struct Complex
{
    public int real;
    public int imaginary;

    public Complex(int real, int imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
    }

    public override string ToString()
    {
        return $"{real} + {imaginary}i";
    }
}

class Program
{
    static void Main()
    {
        Complex num1 = new Complex(2, 3);
        Complex num2 = new Complex(3, 4);

        Complex sum = num1 + num2;

        Console.WriteLine($"First Complex Number: {num1}");
        Console.WriteLine($"Second Complex Number: {num2}");
        Console.WriteLine($"Sum of the Two Numbers: {sum}");

        Console.ReadKey();
    }
}
