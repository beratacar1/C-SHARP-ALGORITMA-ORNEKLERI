using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kdv_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tutar, kdv, kdvliFiyat = 0.20;
            Console.Write("Lütfen ürünün tutarını giriniz : ");
            tutar = Convert.ToDouble(Console.ReadLine());

            kdvliFiyat = tutar + (tutar * kdvliFiyat);
            Console.Write("Ürünün Kdvli Fiyatı : ");
            Console.WriteLine(kdvliFiyat);
        }
    }
}
