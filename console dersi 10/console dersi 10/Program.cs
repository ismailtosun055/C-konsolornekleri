using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("bir sayi giriniz:");
            sayi=Convert.ToInt32(Console.ReadLine());
            bool durum1 = sayi > 0;
            Console.WriteLine("sayi sıfırdan büyük mü?\n" + durum1);
            Console.ReadLine();
        }
    }
}
