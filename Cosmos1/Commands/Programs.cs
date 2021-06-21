using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Commands
{
    public class Programs
    {
        public static void Calc()
        {
            Console.Write("Enter the math symbol(*, /, +, -, ^, %) or type 'sqrt': ");
            var c = Console.ReadLine();
            if (c == "+")
            {
                Console.Write("OK. Enter the first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("OK. Enter the second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int sum = a + b;
                Console.WriteLine("Result: " + sum);
                Console.WriteLine("");
            }
            else if (c == "-")
            {
                Console.Write("OK. Enter the first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("OK. Enter the second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int sum = a - b;
                Console.WriteLine("Result: " + sum);
                Console.WriteLine("");
            }
            else if (c == "*")
            {
                Console.Write("OK. Enter the first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("OK. Enter the second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int sum = a * b;
                Console.WriteLine("Result: " + sum);
                Console.WriteLine("");
            }
            else if (c == "/")
            {
                Console.Write("OK. Enter the first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("OK. Enter the second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! DivideByZeroException(-1073741510).");
                    Console.ResetColor();
                    Console.WriteLine("");
                }
                else
                {                    
                    int sum = a / b;
                    Console.WriteLine("Result: " + sum);
                    Console.WriteLine("");
                }
            }
            else if (c == "^")
            {
                Console.Write("OK. Enter the first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("OK. Enter the second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result: " + Math.Pow(a, b));
                Console.WriteLine("");
            }
            else if (c == "%")
            {
                Console.Write("OK. Enter the number number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int sum = a / 100;
                Console.WriteLine("Result: " + sum);
                Console.WriteLine("");
            }
            else if (c == "sqrt")
            {
                Console.Write("OK. Enter the number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result: " + Math.Sqrt(a));
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Error!");
                Console.WriteLine("");
            }
        }
    }
}
