using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1 – Add (+)");
            Console.WriteLine("2 – Subtract (-)");
            Console.WriteLine("3 – Multiply (*)");
            Console.WriteLine("4 – Divide (/)");
            Console.WriteLine("5 – Power (^)");

            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            Console.WriteLine("Enter the first number:");
            input = Console.ReadLine();
            if (!double.TryParse(input, out double num1))
            {
                Console.WriteLine("Invalid number");
                return;
            }

            Console.WriteLine("Enter the second number:");
            input = Console.ReadLine();
            if (!double.TryParse(input, out double num2))
            {
                Console.WriteLine("Invalid number");
                return;
            }

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;
                case 4:
                    result = Divide(num1, num2);
                    Console.WriteLine($"{num1} / {num2} = {result}");
                    break;
                case 5:
                    result = Power(num1, num2);
                    Console.WriteLine($"{num1} ^ {num2} = {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return double.NaN;
            }
            return a / b;
        }

        static double Power(double a, double b)
        {
            double result = 1;
            for (int i = 0; i < b; i++)
            {
                result = Multiply(result, a);
            }
            return result;
        }
    }
}
