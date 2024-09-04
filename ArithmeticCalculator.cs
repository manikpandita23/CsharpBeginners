using System;
namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Arithmetic Calculator");
            Console.WriteLine("Available operations: +, -, *, /, %");

            Console.Write("Enter the operation (e.g., +, -, *, /, %): ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the first operand: ");
            double operand1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second operand: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    break;
                case '%':
                    if (operand2 != 0)
                    {
                        result = operand1 % operand2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Modulus with zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation.");
                    return;
            }

            Console.WriteLine($"Result: {operand1} {operation} {operand2} = {result}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
