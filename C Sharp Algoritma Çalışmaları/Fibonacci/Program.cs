using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int s1 = 0;
            int s2 = 1;
            int toplam;

            Console.Write(sayi + " Sayısı fibonacci serisi :");

            for (int i = 1; i <= sayi; i++)
            {
                Console.Write(s1 + " , ");

                toplam = s1 + s2;
                s1 = s2;
                s2 = toplam;
            }
        }
    }
}
