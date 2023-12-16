using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 öğrencinin, 2 vize ve 1 Final notunu alarak ortalama bulan ve ekrana yazdıran program.

            int[] ogrenciler = new int[5];
            int v1, v2, final, ortalama;
            

            Console.WriteLine("Girdiğiniz notlar 0 ve 100 arasında olmalıdır");
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.Write("\n1. Vize notunu giriniz : ");
                v1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Vize notunu giriniz : ");
                v2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Final notunu giriniz : ");
                final = Convert.ToInt32(Console.ReadLine());

                ortalama = (v1 + v2 + final) / 3;

                Console.WriteLine("Ortalamanız : " + ortalama);
                ;
                if (ortalama > 50 || ortalama == 50)
                {
                    Console.WriteLine("Geçtiniz...");
                }
                else if (ortalama < 50)
                {
                    Console.WriteLine("Kaldınız...");
                }
             
            }

        }

    }
}
