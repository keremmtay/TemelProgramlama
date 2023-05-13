using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar_Overloading
{
    internal class Overloading
    {
        static void Main(string[] args)
        {
            #region Overload / Aşırı Yüklenme

            // Aynı isimde farklı parametre türlerine sahip metodlar tanımlanabilir..
            // aynı isimli farklı parametre sayısına sahip metodlar da tanımlanabilir..

            //Topla();
            //Topla1();
            //Topla(5);
            //Topla(7, 8);
            //Topla("Ali");
            //Topla("Ali", "Ahmet");

            #endregion

            
            Console.ReadLine();
        }

        static void Topla()
        {
            Console.WriteLine("parametre almayan geriye değer döndürmeyen metod: Topla()");

        }
        static void Topla(string isim)
        {
            Console.WriteLine("string türde parametre alan geriye değer döndürmeyen metod: Topla(string isim) = " + isim);

        }
        static void Topla(string isim, string soyisim)
        {
            Console.WriteLine("string türde parametre alan geriye değer döndürmeyen metod: Topla(string isim, string soyisim) = " + isim + " " + soyisim);

        }
        static void Topla(int sayi1)
        {
            Console.WriteLine("int türde parametre alan geriye değer döndürmeyen metod: Topla(int sayi1) = " + sayi1);

        }
        static void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine("int türde parametre alan geriye değer döndürmeyen metod: Topla(int sayi1, int sayi2) = " + (sayi1+sayi2));

        }
        static void Topla1()
        {
            Console.WriteLine("parametre almayan geriye değer döndürmeyen metod: Topla1()");

        }

    }
}
