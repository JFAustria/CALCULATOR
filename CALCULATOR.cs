using System;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            ConsoleKeyInfo status;
            float answer;

            while (true)
            {
                Console.Write("Enter your 1st number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your 2nd number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the operation you wish to perform (+, -, /, *): ");
                operand = Console.ReadLine();

                switch (operand)
                {
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "/":
                        answer = num1 / num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    default:
                        answer = 0;
                        break;
                }

                Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
                Console.WriteLine("\n\n Press any key to exit");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();
            }
        }

    }
}
