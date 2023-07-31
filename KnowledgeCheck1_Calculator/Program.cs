using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; int num2;

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    Utility.GetTwoIntFromConsole(out num1, out num2);

                    Console.Write($"{num1} + {num2} = ");
                    Console.Write(calculator.Add(num1, num2));

                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    Utility.GetTwoIntFromConsole(out num1, out num2);

                    Console.Write($"{num1} - {num2} = ");
                    Console.Write(calculator.Subtract(num1, num2));
                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    Utility.GetTwoIntFromConsole(out num1, out num2);

                    Console.Write($"{num1} * {num2} = ");
                    Console.Write(calculator.Multiply(num1, num2));
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    Utility.GetTwoIntFromConsole(out num1, out num2);

                    Console.Write($"{num1} / {num2} = ");
                    Console.Write(calculator.Divide(num1, num2));
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}