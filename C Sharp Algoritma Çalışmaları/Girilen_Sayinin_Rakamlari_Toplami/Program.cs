using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayinin_Rakamlari_Toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, sonuc = 0;
            Console.Write("Sayı giriniz : ");
            sayi = int.Parse(Console.ReadLine());
         
            do
            {
                sonuc += sayi % 10;
                sayi = sayi / 10;
            } while (sayi > 0);
            Console.WriteLine("Girdiğiniz sayının rakamları toplamı : " + sonuc);
        }
    }
}
