using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beden_Kitle_İndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beden kitle indeksi = Kilo / boy*boy
            // Beden kitle indeksi 18'e eşit veya düşüke ZAYIF
            // 18 ile 25 arasında ise NORMAL
            // 25'ten büyükse OBEZ yazdıran program parçasını kodlayınız

            Console.WriteLine("Kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bki = kilo / (boy * boy);

            if (bki <= 18)
            {
                Console.WriteLine("Beden kitle indeksi değeriniz : ZAYIF");
            }
            else if (bki > 18 && bki < 25)
            {
                Console.WriteLine("Beden kitle indeksi değeriniz : NORMAL");
            }
            else if (bki > 25)
            {
                Console.WriteLine("Beden kitle indeksi değeriniz : OBEZ");
            }
            else
            {
                Console.WriteLine("Eksik veya hatalı bir değer girdiniz");
            }


        }
    }
}
