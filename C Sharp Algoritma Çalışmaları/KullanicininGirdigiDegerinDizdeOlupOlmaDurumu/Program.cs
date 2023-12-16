using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicininGirdigiDegerinDizdeOlupOlmaDurumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9 elemanlı bir dizide kullanıcının 

            //int[] sayilar = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.Write("Bir sayı girin:");
            //int girilenSayi = Convert.ToInt32(Console.ReadLine());

            //bool found = false;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] == girilenSayi)
            //    {
            //        found = true;
            //        break;
            //    }
            //}

            //Console.WriteLine("==================================");

            //if (found)
            //{
            //    Console.WriteLine("Girdiğiniz değer dizide bulunmaktadır.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz değer dizide bulunmamaktadır.");
            //}

            #region



            int[] dizi = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("Bir sayı girin: ");
            int girilenSayi = Convert.ToInt32(Console.ReadLine());


            bool bulunduMu = false;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == girilenSayi)
                {
                    bulunduMu = true;
                    break;
                }
            }

            if (bulunduMu)
                Console.WriteLine("Girilen sayı dizide bulundu.");
            else
                Console.WriteLine("Girilen sayı dizide bulunamadı.");
        }
    }
}






#endregion



