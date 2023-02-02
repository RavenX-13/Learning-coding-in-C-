using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the title of the calculator
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            // Read the first number from the user
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Read the second number from the user
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine();

            // Read the operation number from the user
            Console.Write("Enter the operation number: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            // Perform the calculation
            double result = 0;
            if (operation == 1)
            {
                // Addition
                result = num1 + num2;
            }
            else if (operation == 2)
            {
                // Subtraction
                result = num1 - num2;
            }
            else if (operation == 3)
            {
                // Multiplication
                result = num1 * num2;
            }
            else if (operation == 4)
            {
                // Division
                result = num1 / num2;
            }
            else
            {
                // Invalid operation
                Console.WriteLine("Invalid operation");
            }

            Console.WriteLine();
            Console.WriteLine("Result: " + result);

            // Wait for the user to press Enter before ending the program
            Console.ReadLine();
        }
    }
}
