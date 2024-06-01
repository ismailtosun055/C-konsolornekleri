using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] dizi = { 1, 2, 3,4,5,6,7,8,9,0 };
            foreach(int i in dizi)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
