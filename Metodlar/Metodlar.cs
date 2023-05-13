using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class Metodlar
    {
        static void Main(string[] args)
        {
            #region Metodlar

            // [erişim belirleyicisi] [geri dönüş tipi] [metodun adı] (varsa parametreler burada tanımlanacak [int sayı], string isim, bool aktifMi)

            //{
            //    Burası metodun gövdesi: Bu metod için çalışmasını istediğimiz kodları buraya yazıyoruz.

            //}


            // 4 farklı metod çeşidimiz var
            // 


            #endregion

            #region 1- Parametresiz ve Geriye değer döndürmeyen metodlar

            //Topla();

            // kodlar varsa çalışmaya buradan devam eder

            #endregion

            #region 2- Parametreli ve Geriye değer döndürmeyen metodlar

            //Topla1(5,6, "Ali");

            //Topla1(89, 10, "Ahmet");

            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //string isim = Convert.ToString(Console.ReadLine());

            //Topla1(sayi1, sayi2, isim);

            #endregion

            #region 3- Parametresiz ve Geriye değer döndüren metodlar

            //int sonuc = Topla2();

            //Console.WriteLine(sonuc);
            //Console.WriteLine(Topla2());


            #endregion

            #region 4- Parametreli ve Geriye değer döndüren metodlar


            //int sonuc = Topla3(3,5);

            //Console.WriteLine(sonuc);

            #endregion

            #region Default Değerli Parametreli Metodlar

            // parametreleri tanımlarken sırasına dikkat etmek gerekir. default olarak tanımlananlar en sonda yer almak zorundadırlar.

            //Carpma(5);


            #endregion

            #region Params parametreli metodlar

            // params keywordü = params ile metodlara aynı türde istediğimiz kadar veri gönderebiliriz.

            //Console.WriteLine("Toplama işleminin sonucu : " + ToplamaYap(1, 6, 5, 5, 85, 84));
            
            #endregion



            Console.ReadLine();
        }

        // metodu tanımlayacağımız yer burası

        static int ToplamaYap(params int[] numbers ) // int a, int b, int c, int d kullanmak yerine kısayol
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }           
            return numbers.Sum();
        }

        static void Carpma(int sayi1, int sayi2 = 1, int sayi3 = 1)
        {

            Console.WriteLine($"{sayi1} , {sayi2} ve {sayi3} için Çarpma işleminin sonucu : " + (sayi1*sayi2*sayi3));
            
        }

        static void Topla()
        {
            // erişim belirleyicisi varsayılan olarak private
            // geriye bir değer döndürmüyorsak o metodun geri dönüş tipi void olmalıdır



            int sayi1 = 10;
            int sayi2 = 15;
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("sonuc.." + sonuc);


        }

        static void Topla1(int sayi1, int sayi2, string isim)
        {
            Console.WriteLine(isim);

            Console.WriteLine("sonuc...." + (sayi1 + sayi2));

            for (int i = 0; i < 5; i++)
            {

            }


        }

        static int Topla2()
        {
            // bu metodun yapacağı işleri burada kodluyoruz.
            // geriye bir değer döndüren metod tanımladıysak mutlaka geriye return keywordüyle ilgili tipte değer döndürmek zorundayız.

            Console.Write("1. sayıyı girin:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı girin:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 + sayi2;

            return sonuc;
        }

        static int Topla3(int x, int y)
        {


            return x + y;


        }

    }
}
