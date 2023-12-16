using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Den10aKadarSayilarinKupleriToplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Çözüm 1
            //double toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{

            //   toplam += i * i * i;

            //toplam += Math.Pow(i, 3);

            //Console.WriteLine(toplam);
            //Console.WriteLine(Math.Pow(i, 3));
            //Console.WriteLine(i);
            //toplam++;
            //toplam += i;

            //}
            #endregion

            #region Çözüm 2
            // WHİLE DÖNGÜSÜ İLE
            //int sayi = 0;
            //double toplam = 0;
            //while (sayi <= 10)
            //{

            //    toplam += Math.Pow(sayi , 3);

            //    //if (sayi == 10)
            //    //{
            //    //    break;
            //    //}
            //    sayi++;

            //}
            //Console.WriteLine(toplam);

            #endregion

            #region Çözüm 3 
            // DO WHİLE LE

            //int sayi = 1;
            //double toplam = 0;

            //do
            //{
            //    toplam += (Math.Pow(sayi, 3));
            //    if (sayi == 10)
            //        break;
            //    sayi++;

            //} while (true);
            //Console.WriteLine(toplam);
            #endregion

            #region Çözüm 4

            int sayi = 1;
            double toplamSonuc = 0;
            string sonuc = "";

            while (sayi <= 10)
            {
                toplamSonuc += Math.Pow(sayi, 3);

                if (sayi != 10)
                {
                    sonuc += $"{sayi}³ +";
                }
                else
                {
                    sonuc += $"{sayi}³ = {toplamSonuc}";
                }

                sayi++;
            }
            Console.WriteLine(sonuc);

            #endregion

        }
    }
}
