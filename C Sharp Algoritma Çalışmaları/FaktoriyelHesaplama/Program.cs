using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Çözüm 1
            //Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 1; i <= sayi; i++) // VEYA for(int i = sayi; i > 0; i--) şeklindede olabilir
            //{
            //    sonuc *= i;
               
            //}
            //Console.WriteLine("Sonuç :" + sonuc);

            #endregion

            #region Çözüm 2
            // WHİLE DÖNGÜÜ İLE

            //Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;

            //while (true)
            //{
            //    sonuc *= sayi;
            //    sayi--;
            //    if (sayi == 0)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Sonuç : " + sonuc);
            #endregion

            #region Çözüm 3
            // DO WHİLE İLE
            Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc = 1;

            do
            {
                sonuc *= sayi;
                sayi--;


                
            } while (sayi > 0);
            Console.WriteLine("Sonuç : " + sonuc);

            #endregion
        }
    }
}
