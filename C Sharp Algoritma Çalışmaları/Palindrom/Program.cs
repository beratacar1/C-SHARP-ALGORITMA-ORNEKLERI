using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Yöntem
            //int a, b, toplam = 0, sayi;

            //Console.Write("Sayı giriniz : ");
            //a = Convert.ToInt32(Console.ReadLine());
            //sayi = a;

            //while (a > 0)
            //{
            //    b = a % 10;
            //    toplam = (toplam * 10) + b;
            //    a = a / 10; 
            //}

            //if (sayi == toplam)
            //{
            //    Console.WriteLine("Girdiğiniz sayı palindromiktir");
            //}
            //else
            //{
            //    Console.WriteLine("Palindromik değildir");
            //}

            #endregion

            #region 2.yöntem


            Console.Write("Bir sayı girin: ");
            string girilenSayi = Console.ReadLine();
            string tersSayi = "";

            for (int i = girilenSayi.Length - 1; i >= 0; i--) // Son karakterden başlayıp ilk karaktere kadar yazdırır
            {
                tersSayi += girilenSayi[i].ToString(); //Bu satır, girilenSayi stringinin i’nci karakterini tersSayi stringinin sonuna ekler.
            }

            if (girilenSayi == tersSayi)
            {
                Console.WriteLine("Girdiğiniz palindromiktir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz  palindromik değildir.");
            }

            #endregion

        }
    }
}
