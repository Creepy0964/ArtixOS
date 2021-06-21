using System;
using System.Net;
using System.Text;
using Sys = Cosmos.System;

namespace LyandOS.Utils
{
    class SystemFailtureManager
    {
        public const string LoggingUrl = @"http://ps.fhgdps.com/supremedash1/lyandos/logs.php";

        /// <summary>
        /// Call kernel panic with parameters and information.
        /// </summary>
        public static void CallKernelPanic(string message, string tracelog, string errno)
        {
            string logInfo = string.Empty;
            logInfo += $"  Error Code: {errno}\n";
            logInfo += $"  Error: {message}\n";
            logInfo += $"  Trace Log: {tracelog}";

            bool logsSent = false;
            if (errno != "0")
                try { logsSent = true; PushLogs(LoggingUrl, logInfo); } catch { logsSent = false; }

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Oops! We've caught an exception, and your computer needs to be restarted.");
            Console.WriteLine();

            Console.WriteLine("Here's some debug information for developers. {0}",
                logsSent ? "Anonymous logs were sent to the server." :
                "Please, contact Creepy0964#9567 on Discord and provide this information.");
            Console.WriteLine();

            Console.WriteLine(logInfo);
            Console.WriteLine();

            Console.Write("Press any key to restart the computer.");
            Console.ReadKey();

            Sys.Power.Reboot();
        }

        // TODO: find a way...
        public static void PushLogs(string url, string logs) { throw new Exception("Not implemented in Cosmos OS"); }
    }
}
