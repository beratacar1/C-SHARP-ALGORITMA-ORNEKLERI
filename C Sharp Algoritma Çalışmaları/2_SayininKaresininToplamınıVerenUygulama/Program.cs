using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SayininKaresininToplamınıVerenUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KULLANICININ GİRDİĞİ 2 SAYININ KARELERİ TOPLAMINI VEREN UYGULAMA

            #region ÇÖzüm 1

            //try
            //{
            //    int sayi1, sayi2, toplam;
            //    Console.Write("1.Sayıyı giriniz : ");
            //    sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("2.Sayıyı giriniz : ");
            //    sayi2 = Convert.ToInt32(Console.ReadLine());
            //    toplam = (sayi1 * sayi1) + (sayi2 * sayi2);

            //    Console.WriteLine("\nGirdiğini sayıların kareleri toplamı : " + toplam);




            //}
            //catch
            //{
            //    Console.WriteLine("\nHatalı bir değer girdiniz !");
            //}

            #endregion

            #region Çözüm 2

            // int sayi1, sayi2;
            // Console.Write("1.Sayıyı giriniz : ");
            // sayi1 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("2.Sayıyı giriniz : ");
            // sayi2 = Convert.ToInt32(Console.ReadLine());

            //double toplam = Math.Pow(sayi1, 2) + Math.Pow(sayi2, 2);

            // Console.WriteLine("\nGirdiğini sayıların kareleri toplamı : " + toplam);


            #endregion

            #region Çözüm 3

            Console.WriteLine("İki sayı giriniz : ");
            double toplam = Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2);

            Console.WriteLine("\nGirdiğini sayıların kareleri toplamı : " + toplam);
            #endregion
        }
    }
}
