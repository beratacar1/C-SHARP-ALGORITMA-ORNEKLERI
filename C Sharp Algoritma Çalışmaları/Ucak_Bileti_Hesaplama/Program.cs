using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucak_Bileti_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km, yas, tip;
            Console.Write("Mesafeyi giriniz : ");
            km = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nYaşınızı giriniz : ");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYolculuk tipini seçiniz (1=Tek gidiş , 2= Gidiş/Dönüş) :");
            tip = Convert.ToInt32(Console.ReadLine());

            double normalFiyat, yasIndirimi, tipIndirimi;
     
            if (km > 0 && yas > 0 && (tip == 1 || tip == 2))
            {
                normalFiyat = km * 0.10;
                if (yas < 12)
                {
                    yasIndirimi = normalFiyat * 0.5; //İndirim oranını hesaplıyor.
                }
                else if (yas >= 12 && yas <= 24)
                {
                    yasIndirimi = normalFiyat * 0.10;
                }
                else if (yas >= 65)
                {
                    yasIndirimi = normalFiyat * 0.30;
                }
                else
                {
                    yasIndirimi = 0;
                }
                normalFiyat -= yasIndirimi; //Fiyattan indirim payını çıkarıyor.
                if (tip == 2)
                {
                    tipIndirimi = normalFiyat * 0.20;
                    normalFiyat = (normalFiyat - tipIndirimi) * 2;
                }
                Console.WriteLine("Bilet tutarı : " + normalFiyat + "$");
            }
            else
            {
                Console.WriteLine("Girdiğiniz değerler eksik veya hatalı lütfen tekrar deneyiniz !");
            }
        }
    }
}
