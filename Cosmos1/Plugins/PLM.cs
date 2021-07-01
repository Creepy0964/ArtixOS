using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Plugins
{
    class PLM
    {
        public static void PluginManager()
        {
            Console.WriteLine("Which plugin do you want to activate?");
            string PluginInput = Console.ReadLine();
            switch(PluginInput)
            {
                case "": // здесь вводим имя плагина
                    Kernel.WD = ""; // здесь вводим то, что мы хотим видеть вместо папок(условно - название плагина и префикс для команд)
                    Console.WriteLine(""); // здесь должно остаться пустое место
                    break; // чтобы написать активатор плагина, возьмите за основу RunEngine(), создайте отдельный метод и вместо основных команд введите свои
                    // пример внутренностей метода:
                    // switch(Kernel.input)
                    // {
                    //      case "[префикс]Help":
                    //          Console.WriteLine("Help");
                    //          break;
                    // }
                    // чтобы вызвать метод, добавьте в Kernel case "": и туда введите название папки из Kernel.WD для плагина, ниже вызовите метод и закончите это break;
            }
        }
        public static void PluginExit()
        {
            Kernel.WD = @"0:\";
            Console.WriteLine("");
        }
    }
}
