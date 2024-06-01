using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar =new int[5];
            int max, min;

            Console.WriteLine("lutfen 5 sayi giriniz:");
            for (int i = 0; i < 5; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = sayilar[0];
            min = sayilar[0];
            for (int i = 1; i<5; i++)
            {
                if (max < sayilar[i])
                {
                    max = sayilar[i];
                }

                else if (min > sayilar[i])
                {
                    min = sayilar[i];
                }
            }

            Console.WriteLine("en büyük deger:{0}\nen kücük deger:{1}", max,min);
            Console.ReadLine();
        }
    }
}
