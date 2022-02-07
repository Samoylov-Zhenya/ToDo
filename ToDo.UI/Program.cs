using System;

namespace ToDo.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение запущено ToDo");
            var menu = new Menu();
            menu.Start();
        }
    }
}
