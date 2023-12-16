using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucgen_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uzunluk1, uzunluk2, uzunluk3;

          



                Console.Write("1.uzunluğu giriniz :");
                uzunluk1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.uzunluğu giriniz :");
                uzunluk2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("3.uzunluğu giriniz :");
                uzunluk3 = Convert.ToInt32(Console.ReadLine());

            if (0 < uzunluk1 && uzunluk1 < 100 && 0 < uzunluk2 &&  uzunluk2 < 100 && 0 < uzunluk3 && uzunluk3 < 100)
            {

                if (uzunluk1 == uzunluk2 && uzunluk1 == uzunluk3 && uzunluk2 == uzunluk3)
                {
                    Console.WriteLine("Eşkenar üçgendir.");
                }

                else if (uzunluk1 == uzunluk2 || uzunluk1 == uzunluk3 || uzunluk2 == uzunluk3)
                {
                    Console.WriteLine("İkizkenar üçgendir");
                }
                else if (uzunluk1 != uzunluk2 && uzunluk1 != uzunluk3 && uzunluk2 != uzunluk3)
                {
                    Console.WriteLine("Çeşitkenar üçgendir");

                }
            }






        }
    }
}
