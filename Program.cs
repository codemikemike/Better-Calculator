using System;

namespace BetterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            string op;

            Console.Write("Enter a number: ");
            string? input1 = Console.ReadLine();
            if (!double.TryParse(input1, out num1))
            {
                Console.WriteLine("Invalid number input.");
                return;
            }

            Console.Write("Enter operator (+, -, *, /): ");
            op = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(op))
            {
                Console.WriteLine("Invalid operator input.");
                return;
            }

            Console.Write("Enter another number: ");
            string? input2 = Console.ReadLine();
            if (!double.TryParse(input2, out num2))
            {
                Console.WriteLine("Invalid number input.");
                return;
            }

            if (op == "+")
            {
                Console.WriteLine("Result: " + (num1 + num2));
            }
            else if (op == "-")
            {
                Console.WriteLine("Result: " + (num1 - num2));
            }
            else if (op == "*")
            {
                Console.WriteLine("Result: " + (num1 * num2));
            }
            else if (op == "/")
            {
                if (num2 != 0)
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                }
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }
    }
}