using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.BL.Controller
{
    public static class Hellper
    {
        public static void PrintRedLine(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            Console.WriteLine(str);
            Console.ResetColor(); // сбрасываем в стандартный
        }
        public static void PrintGreenLine(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.WriteLine(str);
            Console.ResetColor(); // сбрасываем в стандартный
        }

        public static void PrintRed(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            Console.Write(str);
            Console.ResetColor(); // сбрасываем в стандартный
        }
        public static void PrintGreen(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.Write(str);
            Console.ResetColor(); // сбрасываем в стандартный
        }
    }
}
