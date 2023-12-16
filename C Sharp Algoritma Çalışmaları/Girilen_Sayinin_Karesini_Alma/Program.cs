using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayinin_Karesini_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan aldığımız sayının karesini alalım eğer karesi 25'ten büyükse;
            // karesi 25'ten büyüktür değilse karesi 25'ten küçüktür yazdırsın.
            #region 1.Yöntem

            //Console.Write("Lütfen bir sayı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //if (sayi * sayi > 25)
            //{
            //    Console.WriteLine("Girdiğiniz değerin karesi 25'ten büyüktür");
            //}
            //else if (sayi * sayi == 25)
            //{
            //    Console.WriteLine("25'e eşittir");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz değerin karesi 25'ten küçüktür");
            //}

            #region 2.Yöntem

            Console.Write("Bir sayı giriniz : ");

            int sayi = int.Parse(Console.ReadLine());

            int kareDeger = kareAl(sayi);

            if (kareDeger > 25)
            {
                Console.WriteLine("Karesi 25'ten büyüktür");
            }
            else
            {
                Console.WriteLine("Karesi 25'ten küçüktür");
            }

            #endregion


        }
        #endregion
        static int kareAl(int a)
        {
            return a * a;
        }
 
    }
}
