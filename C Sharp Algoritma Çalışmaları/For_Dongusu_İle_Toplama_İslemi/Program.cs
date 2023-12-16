using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Dongusu_İle_Toplama_İslemi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int toplam = 0;
            int sonuc = 0;
            for (int i = 1; i <= 5; i++)
            {

                Console.Write("Sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi; 
             
            }
            Console.WriteLine("Toplam : " + toplam);
        }
    }
}
