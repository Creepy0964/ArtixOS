using System;
using System.Globalization;

namespace LyandOS.Utils
{
    class OutputFormatter
    {
        /// <summary>
        /// Format colored output using hex console color codes (minecraft?) and write it.
        /// </summary>
        /// <param name="message">Message to format and output.</param>
        /// <param name="fmt">Formatting symbol.</param>
        public static void WriteLine(string message, char fmt = '&')
        {
            bool isNextSymbolColorCode = false;
            foreach (char symbol in message)
            {
                if (isNextSymbolColorCode)
                {
                    Console.ForegroundColor = (ConsoleColor)int.Parse(symbol.ToString(), NumberStyles.HexNumber);
                    isNextSymbolColorCode = false;
                    continue;
                }
                isNextSymbolColorCode = symbol == '&';
                if (!isNextSymbolColorCode)
                    Console.Write(symbol);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
