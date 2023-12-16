using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MİNİATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;

            // Kullanıcıya nasıl bir işlem yapacak
            // 1- Bakiye görüntüleme
            // 2- Para çekme
            // 3- Para yatırma
            // q'ya basarsa çıkış yapmış olacak.


            Console.WriteLine("ATM'ye Hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("1- Bakiye görüntüle");
            Console.WriteLine("2- Para çek");
            Console.WriteLine("3- Para yatır");
            Console.WriteLine("4- ATM'den çıkış yap");
            string secim = Console.ReadLine();

            if(secim == "1")
            {
                Console.WriteLine("Şuanki Bakiyeniz : " + bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                
                if(cekilecek_tutar<= bakiye)
                {
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                }
                Console.WriteLine("Kalan Tutar : " + (bakiye - cekilecek_tutar));
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istdeiğiniz tutarı giriniz");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni Bakiyeniz : " + (bakiye + yatirilacak_tutar));
            }
            else if(secim == "4")
            {

                Console.WriteLine("Çıkış yapıldı İyi Günler");
            }
            else
            {
                Console.WriteLine("Eksik veya hatalı bir değer girdiniz. Lütfen tekrar deneyiniz");
            }
        }
    }
}
