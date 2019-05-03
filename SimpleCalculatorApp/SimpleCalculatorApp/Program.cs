using System;

namespace SimpleCalculatorApp
{
    class Program
    {
        static void Main()
        {
            string number1;
            string number2;
            string arithmetic;

            Console.WriteLine("Welcome to the Simple Calculator written in C#");

            Console.WriteLine("Please enter a number");

            number1 = Console.ReadLine();

            Console.WriteLine("Please enter another number");

            number2 = Console.ReadLine();

            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);


            Console.WriteLine("Would you like to Add, Subtract, Multiply or Divide?");
            arithmetic = Console.ReadLine();

            switch(arithmetic.ToLower())
            {
                case "add":
                    Console.WriteLine($"The sum of {num1} + {num2} is {num1 + num2}");
                    break;
                case "subtract":
                    Console.WriteLine($"The subtracted result of {num1} and {num2} is {num1 - num2}");
                    break;
                case "multiply":
                    Console.WriteLine($"The product of {num1} and {num2} is {num1 * num2}");
                    break;
                case "divide":
                    Console.WriteLine($"The divided result of {num1} and {num2} is {num1 / num2}");
                    break;
            }
        }
    }
}
