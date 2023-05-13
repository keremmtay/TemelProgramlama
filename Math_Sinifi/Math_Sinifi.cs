using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Sinifi
{
    internal class Math_Sinifi
    {
        static void Main(string[] args)
        {
            #region Math Sınıfı

            // Matematiksel işlemler yapmak için kullanılan bir sınıftır.

            #endregion

            #region Abs

            // sayının mutlak değerini veriyor

            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Abs(255));

            #endregion

            #region Ceiling

            // Ondalıklı sayıyı yukarıya yuvarlıyor

            Console.WriteLine(Math.Ceiling(5.000001));

            #endregion

            #region Floor

            Console.WriteLine(Math.Floor(7.99));

            #endregion

            #region Round

            // Kendisine en yakın değere yuvarlıyor

            Console.WriteLine(Math.Round(5.12));
            Console.WriteLine(Math.Round(5.51));

            #endregion

            #region Pow

            // üs alma işlemini yapıyor

            Console.WriteLine(Math.Pow(3,2));
            Console.WriteLine(Math.Pow(5,3));

            #endregion

            #region Sqrt Karekök

            // Karekök alıyor

            Console.WriteLine(Math.Sqrt(9));

            #endregion

            #region Truncate

            // Parametre olarak verilen sayının virgülden sonrasını almıyor

            Console.WriteLine(Math.Truncate(8.12));
            Console.WriteLine(Math.Truncate(9.89));
            Console.WriteLine(Math.Truncate(64.4));
            Console.WriteLine(Math.PI);

            #endregion

            Console.ReadLine();
        }
    }
}
