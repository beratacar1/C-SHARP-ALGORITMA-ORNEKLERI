using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baklava_Dilimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Baklava Dilimi");
            Console.WriteLine("Boyut değerini giriniz");
            int boyut = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= boyut; i++)
            {
                for (int k = boyut; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = (boyut - 1); i >= 1; i--)
            {
                for (int k = boyut; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
