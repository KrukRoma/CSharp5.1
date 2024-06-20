using System;

namespace CSharp5._1
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            try
            {
                Console.Write("Enter the first number: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Select an operation: Add, Sub, Mul, Div");
                string operation = Console.ReadLine();

                double result;

                switch (operation.ToLower())
                {
                    case "add":
                        result = calculator.Add(a, b);
                        Console.WriteLine($"Result: {result}");
                        break;

                    case "sub":
                        result = calculator.Sub(a, b);
                        Console.WriteLine($"Result: {result}");
                        break;

                    case "mul":
                        result = calculator.Mul(a, b);
                        Console.WriteLine($"Result: {result}");
                        break;

                    case "div":
                        result = calculator.Div(a, b);
                        Console.WriteLine($"Result: {result}");
                        break;

                    default:
                        Console.WriteLine("Unknown operation.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter valid numbers.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

