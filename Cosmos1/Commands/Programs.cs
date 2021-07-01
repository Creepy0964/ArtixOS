using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Commands
{
    public class Programs
    {
        public static int sum;
        public static void Calc(string symb, int a, int b)
        {
            switch(symb)
            {
                case "+":
                    sum = a + b;
                    Console.WriteLine("Result: " + sum);
                    Console.WriteLine("");
                    break;
                case "-":
                    sum = a - b;
                    Console.WriteLine("Result: " + sum);
                    Console.WriteLine("");
                    break;
                case "*":
                    sum = a * b;
                    Console.WriteLine("Result: " + sum);
                    Console.WriteLine("");
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error! DivideByZeroException(-1073741510).");
                        Console.ResetColor();
                        Console.WriteLine("");
                    }
                    else
                    {
                        sum = a / b;
                        Console.WriteLine("Result: " + sum);
                        Console.WriteLine("");
                    }
                    break;
                case "^":
                    Console.WriteLine("Result: " + Math.Pow(a, b));
                    Console.WriteLine("");
                    break;
                case "%":
                    sum = a / 100;
                    Console.WriteLine("Result: " + sum);
                    Console.WriteLine("");
                    break;
                case "sqrt":
                    Console.WriteLine("Result: " + Math.Sqrt(a));
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Error!");
                    Console.WriteLine("");
                    break;
            }            
        }
    }
}