using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Sinifi
{
    internal class DateTime_Sinifi
    {
        static void Main(string[] args)
        {
            #region DateTime Sınıfı

            // Tarih ve zaman ile ilgili verileri tutmak için kullandığımız değişken türüdür.

            //DateTime tarih = new DateTime();           // bu satırı şu aşamada düşünmeyin

            // tarih ve zaman üzerinde bir takım işlemler yapmak için kullanıyoruz.
            #endregion

            #region Now Özelliği

            DateTime simdi = DateTime.Now;

            //Console.WriteLine(simdi);

            //Console.WriteLine(simdi.Year);
            //Console.WriteLine(simdi.Month);
            //Console.WriteLine(simdi.Day);
            //Console.WriteLine(simdi.DayOfWeek);
            //Console.WriteLine(simdi.DayOfYear);
            //Console.WriteLine(simdi.Hour);
            //Console.WriteLine(simdi.Minute);
            //Console.WriteLine(simdi.Second);
            //Console.WriteLine(simdi.Millisecond);

            #endregion

            #region Kendi tarihimizi oluşturma

            //DateTime dt = new DateTime(2023,06, 05, 22, 55, 30); // sırasıyla yıl, ay, gün, saat, dakika, saniye bilgilerini parametre olarak verebiliriz ve 

            //Console.WriteLine(dt);
            //Console.WriteLine(dt.AddDays(2));
            //Console.WriteLine(dt.AddHours(-1));
            //Console.WriteLine(dt.AddYears(3));
            //Console.WriteLine(dt.AddMonths(4));

            #endregion

            #region 2 tarih arasındaki fark

            //Console.WriteLine("*************************");
            //Console.WriteLine("simdi: \t" + simdi);
            //Console.WriteLine("dt: \t" + dt);

            //TimeSpan fark = dt - simdi;

            //Console.WriteLine(fark);
            //Console.WriteLine(fark.Days);

            #endregion

            #region Tarih Formatlandırma

            Console.WriteLine("***** Tarih Formatlandırma *****");

            Console.WriteLine(simdi.ToString());
            Console.WriteLine(simdi.ToString("d"));
            Console.WriteLine(simdi.ToString("D"));
            Console.WriteLine(simdi.ToString("F"));
            Console.WriteLine(simdi.ToString("M"));
            Console.WriteLine(simdi.ToString("t"));
            Console.WriteLine(simdi.ToString("T"));
            Console.WriteLine(simdi.ToString("Y"));

            #endregion

            #region Ornek

            // Klavyeden doğum gününüzü girip kaç günlük olduğunuzu hesaplayan programı yazın

            //DateTime dg = new DateTime();

            //Console.Write("Doğum tarihinizi girin:");
            //dg = Convert.ToDateTime(Console.ReadLine());

            //TimeSpan gun = DateTime.Now - dg;

            //Console.WriteLine(gun.Days + " günlüksünüz.");


            #endregion

            Console.ReadLine();
        }
    }
}
