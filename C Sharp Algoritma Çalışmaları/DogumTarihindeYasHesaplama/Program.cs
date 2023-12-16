using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogumTarihindeYasHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Doğum tarihinizi giriniz : ");
            DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());

            TimeSpan sonuc = DateTime.Now - dogumTarihi;

            Console.WriteLine("Yaşınız :" + sonuc.Days / 365);



        }
    }
}
