using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bilgilerim=new string[3];
            Console.WriteLine("lütfen bir şeyler yazın:");

            for (int i = 0; i < 3; i++)
            {
                bilgilerim[i] = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(bilgilerim[i]);
            }
            Console.Read();
        }
    }
}
