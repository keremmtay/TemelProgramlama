using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_Ornek
{
    internal class Metod_Ornek
    {
        static void Main(string[] args)
        {
            // Klavyeden tutar girilecek
            // KDV hesaplanacak %18
            // A ve B bankaları olacak
            // A bankası %10 komisyon
            // B bankası %8 komisyon alsın
            // Ödenmesi gereken tutar ekrana yazılsın

            
            Console.Write("Ürünün fiyatını giriniz:\t");

            KdvHesap(kdv);

            Console.WriteLine("Hangi banka üzerinden ödemenizi yapmak istersiniz?");
            char banka = Convert.ToChar(Console.ReadLine());

            if (banka == 'A' || banka == 'a')
            {
                bankaA(komisyonA);

            }
            else if (banka == 'B' || banka == 'b')
            {

                bankaB();
            }

            Console.ReadLine();
        }

        static double KdvHesap(double kdv)
        {
            
            double fiyat;            
            fiyat = Convert.ToDouble(Console.ReadLine());
            kdv = fiyat + (fiyat * 0.18);
            Console.Write("\nÜrünün KDV'li tutarı:\t" + kdv);

            return fiyat + (fiyat * 0.18);

        }

        static double bankaA(double komisyonA)
        {
            double tutar;
            double kdv;
            char banka = Convert.ToChar(Console.ReadLine());
            if (banka == 'A' || banka == 'a')
            {
                komisyonA = kdv + (kdv * 0.10);


            }
           

            



        }
        static void bankaB()
        {
            double tutar;
            double komisyonB;
            double kdv;
            char banka = Convert.ToChar(Console.ReadLine());
            if (banka == 'A' || banka == 'a')
            {
                komisyonB = kdv + (kdv * 0.08);


            }



        }
        
    }
}
