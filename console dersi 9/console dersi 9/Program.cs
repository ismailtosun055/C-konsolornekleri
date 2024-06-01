using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele=new Random();
            int a;
            a= rastgele.Next(0,101);
            Console.BackgroundColor= ConsoleColor.DarkMagenta;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
