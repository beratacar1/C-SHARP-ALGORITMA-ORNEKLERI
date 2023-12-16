using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen10SayininTekCiftOlmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Lütfen " + (i + 0) + ". sayıyı giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Sayı çifttir");
                }
                else if (sayi % 2 == 1)
                {
                    Console.WriteLine("Sayı tektir");
                }
                else
                    Console.WriteLine("Hatalı bir değer girdiniz");
            }




            //    int[] sayigir = new int[10];
            //    int i;

            //    for (i = 0; i < 10; i++)
            //    {
            //        Console.Write("Sayıyı giriniz..:");
            //        sayigir[i] = Convert.ToInt16(Console.ReadLine());
            //    }

            //    Console.WriteLine("Çift Sayılar");
            //    Console.WriteLine("------------");

            //    for (i = 0; i <= 9; i++)
            //    {
            //        if (sayigir[i] % 2 == 0)
            //        {
            //            Console.WriteLine(sayigir[i]);
            //        }
            //    }
            //    Console.WriteLine("Tek Sayılar");
            //    Console.WriteLine("-----------");
            //    for (i = 0; i <= 9; i++)
            //    {
            //        if (sayigir[i] % 2 == 1)
            //        {
            //            Console.WriteLine(sayigir[i]);
            //        } //www.yazilimkodlama.com
            //    }
            //    Console.ReadKey();
            //}

        }
    }
}

