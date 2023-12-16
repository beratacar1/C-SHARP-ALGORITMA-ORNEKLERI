using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirisUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "berat";
            string email = "asdf";
            string parola = "1234";

            Console.Write("Kullanıcı adınızı giriniz :");
            kullaniciAdi = Console.ReadLine();
            Console.Write("\nE-mail giriniz : ");
            email = Console.ReadLine();
            Console.Write("\nParolanızı giriniz : ");
            parola = Console.ReadLine();

            Console.WriteLine("\n**************************************");

            if (kullaniciAdi == "berat" && email == "asdf" && parola == "1234")
            {
                Console.WriteLine("\nGiriş yapıldı ");
            }

            // DOĞRU OLANI BELİRTİP ,DİĞER İKİSİNDEN BİRİNİN HATALI OLDUĞUNU YAZDIRAN KOD BLOĞU

            //else if (kullaniciAdi == "berat" && email != "asdf" && parola != "1234" )
            //{
            //    Console.WriteLine("\nKullanıcı adınız doğru fakat email veya parolanız hatalıdır");
            //}
            //else if (email == "asdf" && kullaniciAdi != "berat" && parola == "1234")
            //{
            //    Console.WriteLine("\nEmail doğru fakat kullanıcı adı veya parolanız hatalıdır");
            //}
            //else if (parola == "1234" && kullaniciAdi != "berat" && parola != "1234")
            //{
            //    Console.WriteLine("\nParola doğru fakat kullanıcı adı veya email hatalıdır");
            //}


           // DOĞRU VE YANLIŞ OLANI KESİN BİR ŞEKİLDE BELİRTEN KOD BLOĞU

            else if (kullaniciAdi == "berat" && email == "asdf" && parola != "1234")
            {
                Console.WriteLine("\nKullanıcı adı ve email doğru fakat parolanız hatalıdır!");
            }
            else if (kullaniciAdi != "berat" && email == "asdf" && parola == "1234")
            {
                Console.WriteLine("\nEmail ve parolanız doğru fakat kullanıcı adı hatalıdır");
            }
            else if (kullaniciAdi != "berat" && email != "asdf" && parola == "1234")
            {
                Console.WriteLine("\nParolanız doğru fakat kullanıcı adı ve email hatalıdır");
            }
            else if (kullaniciAdi == "berat" && email != "asdf" && parola == "1234")
            {
                Console.WriteLine("\nKullanıcı adı ve parola doğru fakat email hatalıdır");

            }
            else if (email == "asdf" && kullaniciAdi != "berat" && parola != "1234")
            {
                Console.WriteLine("\nEmail doğru fakat kullanıcı adı ve parola hatalıdır");
            }
            else if (kullaniciAdi != "\tab" && email != "\tab" && parola != "\tab")
            {
                Console.WriteLine("\nGiriş bilgileri boş bırakılamaz ! ");
            }

            else if (kullaniciAdi != "berat" && email != "asdf" && parola != "1234")
            {
                Console.WriteLine("\nGiriş bilgilerinizin tümü hatalıdır ! ");
            }






        }
    }
}
