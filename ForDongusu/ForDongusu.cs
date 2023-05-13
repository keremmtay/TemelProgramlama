using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    internal class ForDongusu
    {
        static void Main(string[] args)
        {
            #region Döngüler

            // Döngüler, bir veya birden fazla işlem/komut satırını, belirli bir şarta bağlı olarak, belirli bir sayıda çalıştıran yapılardır. Koşul sağlandığı sürece istenen kodlar sürekli/tekrarlı bir şekilde çalışır.
            // 4 farklı döngümüz var.
            // for döngüsü
            // while döngüsü
            // do-while döngüsü
            // foreach..

            // Örneğin ekrana İstanbul yazan kodu 10 defa çalıştırmak istersek aşağıdaki gibi kullanabiliriz fakat 200 defa çalıştırmak isterserk bu durumda aynı kodları 200 defa yazmak zorunda kalacağız.

            //Console.WriteLine("İstanbul");
            //Console.WriteLine("İstanbul");
            //Console.WriteLine("İstanbul");
            //Console.WriteLine("İstanbul");
            //Console.WriteLine("İstanbul");
            //Console.WriteLine("İstanbul");
            //Console.WriteLine("İstanbul");
            //Console.WriteLine("İstanbul");
            //Console.WriteLine("İstanbul");
            //Console.WriteLine("İstanbul");

            #endregion

            #region For Döngüsü

            // for döngüsünün syntax'ı aşağıdaki gibidir
            // for döngüsü 3 tane parametre alır. bu parametreler döngüye başlayacağımız değer ve ne kadar süreyle bu döngünün çalışacağını belirten parametrelerdir.

            //for (1. parametre; 2. parametre; 3. parametre)
            //{
            //    // tekrarlanmasını istediğimiz kodları buraya yazıyoruz
            //}

            // 1. parametre = döngüye başlayacağımız başlangıç değerini burada veriyoruz. int = i;
            // 2. parametre = tekrarlanmasını istediğimiz kodların ne kadar ve hangi şarta bağlı olarak tekrar edeceğini belirlediğimiz koşul ifadesidir
            // 3. parametre = bu parametremiz iterasyon görevini yerine getiren parametredir. başlangıç değerini artırıp azaltmak için kullandığımız parametreyi buraya yazarız.

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("Ankara");
            //    Console.WriteLine("İstanbul");
            //}

            #endregion

            #region Ornek-1

            // 1den 50ye kadar olan sayıları ekrana yazdıran program

            //for (int i = 1; i < 51; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Ornek-2

            // 50den 1e kadar olan sayıları ekrana yazdırma

            //for (int i = 50; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Ornek-3

            // 1 ile 100 arasındaki çift sayıları ekrana yazdıran

            // 1. yol

            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // 2. yol

            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}

            #endregion

            #region Ornek-4

            // klavyeden girilen 2 farklı sayı arasındaki çift sayıları ekrana yazdıran program

            //int sayi1;
            //int sayi2;

            //Console.WriteLine("1. sayıyı giriniz:");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("");

            //Console.WriteLine("2. sayıyı giriniz:");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Seçilen 2 sayı arasındaki çift sayılar");
            //    Console.WriteLine("");
            //    for (int i = sayi2; i <= sayi1; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Seçilen 2 sayı arasındaki çift sayılar");
            //    Console.WriteLine("");
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {

            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            #endregion

            #region Ornek-5

            // 1 ile 20 arasındaki tek sayıların toplamını ekrana yazdıran programı yazın

            //int toplam = 0;

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        toplam = toplam + i;
            //        Console.WriteLine(i);

            //    }
            //}

            //Console.WriteLine("");
            //Console.WriteLine("1den 20ye kadar olan tek sayıların toplamı:");
            //Console.WriteLine("");
            //Console.WriteLine(toplam);

            #endregion

            #region Ornek-6

            // 0'dan başlayıp klavyeden girilen sayıya kadar olan sayılardan 3'e VE 5'e bölünenleri ekrana yazdıran program

            //int sayi;

            //Console.WriteLine("Bir sayı giriniz:");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= sayi; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Ornek-7

            // Klavyeden girilen sayının faktöriyelini hesaplayan programı yazın...
            // 5! = 5*4*3*2*1 = 120

            //int sonuc = 1;
            //int sayi;

            //Console.WriteLine("Bir sayı giriniz:");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++)
            //{
            //    sonuc = sonuc * i;                
            //}

            //Console.WriteLine(sayi + " sayısının faktöriyeli " + sonuc);

            #endregion

            #region for'da continue kullanımı

            // for döngüsü ile continue kullandığımız zaman continue olan satırı geldiğinde döngü içindeki continue'dan sonra gelen kodlar çalışmaz ve tekrar for olan satıra giderek döngü normal çalışmasına devam eder

            #endregion

            #region Ornek-8 - continue

            // 1'den 100'e kadar olan sayılardan 5'in katları hariç ekrana yazdıran programı yazın

            //for (int i = 1; i <= 100; i++)
            //{

            //    if (i % 5 == 0)
            //    {                 
            //        continue;                  
            //    }

            //    Console.WriteLine(i);
            //}

            #endregion

            #region for ile break kullanımı

            // break; belirli bir durumda döngü çalışmasına devam ederken, döngüden çıkmak istediğimizde kullanacağımız keyword'tür.

            #endregion

            #region Ornek-9 - break

            // 1'den 100'e kadar olan sayıları ekrana yazdıralım fakat sayı 75'den büyükse yazmasın

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i > 75)
            //    {
            //        break;   // döngü sonlanır
            //    }
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Ornek-10

            // Klavyeden girilen 5 sayıyı toplayıp ekrana yazdıran program

            //int toplam = 0;

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i + ". sayıyı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi; // bunu yazarak girilen her sayıyı toplamın içine atarak topluyor. += -= *= /= şeklinde de kullanılabilir
            //}
            ////Console.WriteLine(); bunun yerine \n kullanılarak da bir alt satıra geçilebilir
            //Console.WriteLine("\nGirilen sayıların toplamı: " + toplam);

            #endregion

            #region Ornek-11

            // klavyeden girilen 5 sayıdan kaç tanesinin pozitif kaç tanesinin negatif olduğunu bulan programı yazınız

            //int pozitif = 0; // Toplam girilen pozitiflerin sayısı için
            //int negatif = 0; // Toplam girilen negatiflerin sayısı için
            //int sifir = 0; // Toplam girilen sıfırların sayısı için
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i + ". sayıyı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi > 0)
            //    {
            //        pozitif++;
            //    }
            //    else if (sayi < 0)
            //    {
            //        negatif++;
            //    }
            //    else
            //    {
            //        sifir++;
            //    }
            //}
            ////Console.BackgroundColor = ConsoleColor.Green; // Yazının arkaplan rengini değiştirmek için
            ////Console.ForegroundColor = ConsoleColor.Red; // Yazının rengini değiştirmek için
            //Console.WriteLine("\nGirmiş olduğunuz sayılardan " + pozitif + " tanesi pozitif ve " + negatif + " tanesi negatif ve " + sifir + " tanesi 0'dır.");
            #endregion

            #region For varyasyonları

            #region Varyasyon 1

            // başlangıç değişkenini ve değerini for öncesinde tanımlayabiliriz

            //int i = 0;
            //for (; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Varyasyon 2

            // değişkeni dışarıda tanımlayıp başlangıç değerini parametre kısmında verebiliriz
            //int i;
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Varyasyon 3         

            // değişkeni dışarıda tanımlayıp başlangıç değerini parametre kısmında verebiliriz

            //for (int i = 0; i < 10;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}



            #endregion

            #region Varyasyon 4

            //int i = 0;
            //for ( ; i < 10; )
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            #endregion

            #region Varyasyon 5

            // if gibi çalışıyor ama sonsuz bir döngü oluşuyor

            //string sehir = "İstanbul";

            //for (; sehir == "İstanbul" ; )
            //{
            //    Console.WriteLine("sehir İstanbul");
            //    break;   
            //}

            #endregion

            #region Varyasyon 6

            // başlangıç değerini verdiğimiz 1. parametredeki yer aslında değişken tanımladığımız alandır. Eğer döngü içerisinde başka bir değişken daha kullanacaksak bu değişkeni burada tanımlayabiliriz. Ve yine değerini arttırıp azaltabiliriz...

            //for (int i = 0, x = 10; i < x; i++, x--)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion



            #endregion

            #region Sonsuz döngü

            //for (; ; )
            //{
            //    Console.WriteLine("network akademi");
            //}

            #endregion

            #region İçiçe For Döngüleri

            //for (int i = 0; i < 5; i++)
            //{

            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region Ornek-12

            //içiçe for döngüsü kullanarak çarpım tablosu ekrana yazdıralım

           //int sonuc;

           // for (int i = 1; i <= 9; i++)
           // {

           //     for (int j = 1; j <= 9; j++)
           //     {
           //         sonuc = i * j;
           //         Console.Write($"{j} * {i} = {sonuc}\t");

           //     }
           //     Console.WriteLine("");
           // }

            #endregion









            Console.ReadLine();
        }
    }
}
