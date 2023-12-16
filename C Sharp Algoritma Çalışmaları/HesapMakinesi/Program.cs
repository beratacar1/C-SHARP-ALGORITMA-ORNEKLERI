using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
           
            string islem;

            Console.Write("1.Sayıyı giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+, - , *, /)");
            islem = Console.ReadLine();

            if (islem == "+")
            {
                Console.WriteLine("Toplama : " + (sayi1 + sayi2));
            }
            else if(islem == "-")
            {
                Console.WriteLine("Çıkarma : " + (sayi1 - sayi2));
            }
            else if (islem == "*")
            {
                Console.WriteLine("Çarpma : " + (sayi1 * sayi2));

            }
            else if(islem == "/")
            {
                Console.WriteLine("Bölme : " + (sayi1 / sayi2));
            }

        }
    }
}
