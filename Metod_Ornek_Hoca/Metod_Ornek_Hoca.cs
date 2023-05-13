using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_Ornek_Hoca
{
    internal class Metod_Ornek_Hoca
    {
        static void Main(string[] args)
        {
            // Klavyeden tutar girilecek
            // KDV hesaplanacak %18
            // A ve B bankaları olacak
            // A bankası %10 komisyon
            // B bankası %8 komisyon alsın
            // Ödenmesi gereken tutar ekrana yazılsın

            Console.WriteLine("Lütfen tutarı giriniz: ");
            double tutar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ödemek için hangi bankayı seçiyorsunuz? A/B Bankası");
            char banka = Convert.ToChar(Console.ReadLine());

            

            switch (banka)
            {
                case 'A':
                    double komisyonluTutarA = KomisyonHesapla(KDVHesapla(tutar), 1.1);
                    Console.WriteLine(komisyonluTutarA);
                    break;
                case 'B':
                    double komisyonluTutarB = KomisyonHesapla(KDVHesapla(tutar), 1.08);
                    Console.WriteLine(komisyonluTutarB);
                    break;
                
            }

            Console.ReadLine();
        }

        static double KDVHesapla(double tutar)
        {

            return tutar * 1.18;


        }

        static double KomisyonHesapla(double kdvliTutar, double komisyonMiktari)
        {

            return kdvliTutar * komisyonMiktari;

        }
    }
}
