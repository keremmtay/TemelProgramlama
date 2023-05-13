using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_Ornek_2
{
    internal class Metod_Ornek2
    {
        static void Main(string[] args)
        {

            // uzun kenar ve kısa kenarı girilen dikdörtgenin alanı ve çevresini hesaplayan program
            // alan için bir metod
            // çevre hesaplaması başka bir metod

            Console.WriteLine("Dikdörtgenin uzun kenarını giriniz:");
            int uKenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin kısa kenarını giriniz:");
            int kKenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin çevresi:\t" + Cevre(uKenar, kKenar));
            Console.WriteLine("Dikdörtgenin alanı:\t" + Alan(uKenar, kKenar));

            Console.ReadLine();
        }

        static int Cevre(int uKenar, int kKenar)
        {
            int cevre;
            return cevre = (uKenar * 2) + (kKenar * 2);

        }
        static int Alan(int uKenar, int kKenar)
        {
            int alan;
            return alan = uKenar * kKenar;

        }
    }
}
