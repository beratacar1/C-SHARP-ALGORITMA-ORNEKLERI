using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyun_Sıcaklıgına_Gore_Durumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sicaklik;
            string durum;
            Console.Write("Lütfen sıcaklığı giriniz :" );
            sicaklik = Convert.ToInt32( Console.ReadLine());

            if (sicaklik < 0)
            {
                Console.WriteLine("Katı haldedir");
            }
            else if (sicaklik > 0 && sicaklik < 100)
            {
                Console.WriteLine("Sıvı haldedir");
            }
            else
            {

                Console.WriteLine("Gaz haldedir");
            }

        }
    }
}
