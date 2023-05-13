using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Diziler
    {
        static void Main(string[] args)
        {

            #region Diziler

            //
            //

            //string ogrenci1 = "Eren";
            //string ogrenci2 = "İbrahim";
            //string ogrenci3 = "Merve";
            //string ogrenci4 = "Elif";
            //string ogrenci5 = "Mehmet";

            // Diziler aynı tipteki birden fazla veriyi tutabildiğimiz yapılardır.
            // Dizi nasıl tanımlanır?
            // degiskenTuru[] degiskenAdi = new degiskenTuru[diziBoyutu];
            // Kural 1 - Dizinin hangi tipte veri tutacağını belirtmemiz gerekiyor. byte, short, int, long, float, decimal, double, char, string, bool etc...
            // Kural 2 - Mutlaka dizi boyutunu vermemiz gerekiyor.

            //string[] ogrenciler = new string[5];
            //int[] sayilar = new int[10];

            #endregion

            #region Diziye veri ataması nasıl yapılır?

            // dizinin indeks numaralarını kullanarak veri ataması yapabiliriz

            //string sehir;
            //sehir = "İstanbul";

            //string[] sehirler = new string[5];
            //sehirler[0] = "Adana";
            //sehirler[3] = "İzmir";
            //sehirler[4] = "Antalya";
            //sehirler[2] = "Ardahan";
            //sehirler[1] = "Konya";

            //sehirler[5] = "Trabzon";
            //sehirler[6] = "Eskişehir";         // Dizinin sahip olmadığı bir indeks numarasına veri ataması yaparsak, derleme aşamasında hata vermeyecektir fakat çalışma aşamasında Runtime dediğimiz çalışma zamanı hatası verecektir. IndexOutOfRangeException hatası verecektir.

            #endregion

            #region Diziden Veri Okuma

            // indeks numaralarından faydalanarak dizinin içerisindeki verileri okuyabiliriz

            //Console.WriteLine(sehirler[0]);
            //Console.WriteLine(sehirler[3]);

            #endregion

            #region Dizi elemanlarına For döngüsü ile ulaşma

            // Dizi içerisinden verileri yukarıdaki gibi indeks numarasını vererek okuyabiliriz. Fakat 1000 tane elemanı var ise ne yapacağız?
            // Cevap: basit... döngülerden faydalanacağız...

            //Console.WriteLine("**** For döngüsü ile Dizi elemanlarına ulaşma ****\n");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            //Console.WriteLine("sehirler dizisinin boyutu..." + sehirler.Length);

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            #endregion

            #region Dizi tanımlama varyasyonları

            // Klasik olarak aşağıdaki gibi dizi tanımlayabiliriz.
            //int[] sayilar = new int[10];

            // 2. yöntem: tanımlama aşamasında verileri aşağıdaki gibi ilk atamasını yapabiliriz
            //int[] sayilar2 = new int[5] { 6, 8, 15, -65, 90 };

            // 3. yöntem:
            //int[] sayilar3 = new int[] { 90, 6, 89, 3, 8, 5, 16, 28, 95, 40 }; // 10 veri girişi olduğu için dizinin boyutu otomatik olarak 10 olarak ayarlanıyor.

            // 4. yöntem:
            //int[] sayilar4 = { 28, 65, 12 }; // Dizinin boyutunu veri sayısı kadar ayarlayacak. Burada dizi boyutu 3'tür.


            #endregion

            #region Dinamik bir şekilde dizi oluşturmak

            //int diziBoyutu = 15;

            //int[] sayilar5 = new int[diziBoyutu];

            #endregion

            #region Karışık verimiz varsa

            //object[] veriler = new object[5] { true, 56, 55.6, "İstanbul", 'K'};

            //for (int i = 0; i < veriler.Length; i++)
            //{
            //    Console.WriteLine(veriler[i].GetType());
            //}


            #endregion

            #region Ornek-1

            // Bir dizi oluşturalım... Klavyeden girdiğimiz Mevsimleri bu diziye yerleştirelim.. Daha sonra dizi içeriğini yazdıralım.

            //string[] mevsimler = new string[4];

            //for (int i = 0; i < mevsimler.Length; i++)
            //{
            //    Console.WriteLine("Mevsim isimlerini girin:");
            //    mevsimler[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Dizi içeriği...");

            //for (int i = 0; i < mevsimler.Length; i++)
            //{
            //    Console.WriteLine(mevsimler[i]);
            //}

            #endregion

            #region Ornek-2

            // Eleman sayısını klavyeden girerek  oluşturduğumuz diziye, yine klavyeden girdiğimiz şehir isimlerini ekliyor...
            // Sonra dizi elemanlarını yazdırıyoruz

            //Console.Write("Oluşturmak istediğiniz boyutunu giriniz: ");
            //int diziBoyutu = Convert.ToInt32(Console.ReadLine());

            //string[] sehirler = new string[diziBoyutu];

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.Write("Şehir ismi giriniz:  ");
            //    sehirler[i] = Console.ReadLine();
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Dizi içeriği...\n");

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            #endregion

            #region Ornek-3

            // 


            #endregion

            #region foreach kullanımı

            // Collection türündeki değişkenlerin içindeki her bir nesneyi almak için kullanılır. Buradaki en önemli unsur döngünün ömrünü collection içindeki veri sayısı belirler.
            // Collection içerisindeki her bir veri bir değişkene atanır. Ve o değişken kullanılarak döngü içinde istenen işlem yapılır. 

            //foreach (var item in collection)
            //{
            // item ile ilgili istenen işlem burada yapılabilir...
            //}

            // Örnek

            //string[] sehirler = new string[5];
            //sehirler[0] = "Adana";
            //sehirler[3] = "İzmir";
            //sehirler[4] = "Antalya";
            //sehirler[2] = "Ardahan";
            //sehirler[1] = "Konya";

            //Console.WriteLine("foreach öncesi");

            //foreach (string sehir1 in sehirler)
            //{
            //    Console.WriteLine(sehir1);
            //}

            //Console.WriteLine("foreach dışı");

            #endregion

            #region Çok boyutlu diziler - 2 boyutlu

            //int[] sayilar = new int[3]; // tek boyutlu dizi tanımlaması
            //int[,,] ucBoyutluDizi = new int[3,4,5]; // 3 boyutlu dizi tanımlaması
            //int[,,,] cokBoyutlu = new int[2,3,4,5]; // 4 boyutlu dizi tanımlaması
            //int[,] ikiBoyutluDizi = new int[4, 3]; // 2 boyutlu dizi tanımlaması

            //sayilar[0] = 15;

            //ikiBoyutluDizi[0, 0] = 20;
            //ikiBoyutluDizi[0, 1] = 3;
            //ikiBoyutluDizi[0, 2] = 333;
            //ikiBoyutluDizi[1, 0] = 6;
            //ikiBoyutluDizi[1, 1] = 16;
            //ikiBoyutluDizi[1, 2] = -5;
            //ikiBoyutluDizi[2, 0] = 62;
            //ikiBoyutluDizi[2, 1] = 33;
            //ikiBoyutluDizi[2, 2] = 1;
            //ikiBoyutluDizi[3, 0] = 0;
            //ikiBoyutluDizi[3, 1] = 9;
            //ikiBoyutluDizi[3, 2] = 5;

            //Console.WriteLine("Çok boyutlu diziler:");
            //Console.WriteLine(ikiBoyutluDizi[0,2]);

            //Console.WriteLine("\nfor döngüsü ile veri okuma\n");

            //for (int i = 0; i < ikiBoyutluDizi.GetLength(0); i++) // GetLength(0) x boyutunu alır
            //{
            //    for (int j = 0; j < ikiBoyutluDizi.GetLength(1); j++) // GetLength(1) y boyutunu alır. 3 boyutlu olsa onu da GetLength(2) kullanarak z boyutunu alır
            //    {
            //        Console.Write(ikiBoyutluDizi[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < cokBoyutlu.GetLength(0); i++) // 4 boyutluda x boyutunu alır
            //{
            //    for (int j = 0; j < cokBoyutlu.GetLength(1); j++) // y boyutunu alır
            //    {
            //        for (int k = 0; k < cokBoyutlu.GetLength(2); k++) // z boyutunu alır
            //        {
            //            for (int l = 0; l < cokBoyutlu.GetLength(3); l++) // 4. boyutu alır
            //            {

            //            }
            //        }
            //    }
            //}

            #endregion

            #region Array Sınıfı ve metodlar

            // Diziler aslında birer Array'dir. Array bir sınıftır. Diziler de bu sınıftan türeyen yapılardır. 
            // Array = Dizi, Dizi = Array

            //int[] sayilar = new int[3];

            //Array sayilar1 = new int[5];

            //string[] sehirler = new string[3];

            //sehirler[0] = "İstanbul";
            //sehirler[1] = "Ankara";
            //sehirler[2] = "İzmir";

            //Console.WriteLine("Şehirler dizisi\n");

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            //Array bolgeler = new string[3];
            //bolgeler.SetValue("Akdeniz", 0);
            //bolgeler.SetValue("Marmara", 1);
            //bolgeler.SetValue("Karadeniz", 2);

            //Console.WriteLine("\nBölgeler dizisi\n");

            //for (int i = 0; i < bolgeler.Length; i++)
            //{
            //    Console.WriteLine(bolgeler.GetValue(i));
            //}

            #endregion

            #region Array Metotları

            #region Clear Metodu

            // Clear metodu verileri default değerlerine çevirmek için kullanılır... Silme işlemi yapmaz..
            // int için default değer 0'dır. string'de ise empty ya da null

            //Array sayilar = new int[4] {5,18,36,43};

            //Array.Clear(sayilar, 1, 2);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar.GetValue(i));
            //}

            #endregion

            #region Copy Metodu

            //Array sehirler = new string[3]
            //    {"İstanbul", "Ankara", "İzmir"};


            //Array cities = new string[3];
            //Array.Copy(sehirler, cities, 3);

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities.GetValue(i));
            //}

            #endregion

            #region IndexOf

            // dizi içerisinde bir elemanın var olup olmadığını kontrol ediyoruz. var ise indeks numarasını geriye döndürüyor

            //Array sehirler = new string[] { "İstanbul", "Ankara", "İzmir", "Trabzon" };

            //var indeks = Array.IndexOf(sehirler, "İzmir");
            //Console.WriteLine(indeks);

            // dizide olmayan bir veriyi aradığımda sonuç olarak -1 değerini döndürecek

            //if (indeks != -1)
            //{
            //    Console.WriteLine("Aranan veri dizi içerisinde mevcut ... indeks numarası... : " + indeks);
            //}
            //else
            //{
            //    Console.WriteLine("Aradığınız veri dizi içerisinde mevcut değildir.");
            //}


            #endregion

            #region Reverse Metodu

            //Array sehirler = new string[] { "İstanbul", "Zonguldak" , "Ankara", "İzmir", "Trabzon" , "Diyarbakır"};

            //Array.Reverse(sehirler);

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler.GetValue(i));
            //}


            #endregion

            #region Sort Metodu

            // Sort dizi elemanlarını sıralar

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler.GetValue(i));
            //}

            //Console.WriteLine("\nArray.Sort metodu uygulandı\n");
            //Array.Sort(sehirler);
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler.GetValue(i));
            //}


            //Array sayilar = new int[] { 56, 32, 166, -5, 0, 4, 3, 89, -42, 0 };
            //Array.Sort (sayilar);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar.GetValue(i));
            //}

            #endregion

            #endregion

            #region Array Özellikleri

            #region Length

            // dizinin içerisindeki eleman sayısını verir

            //Array sayilar = new int[] { 56, 32, 166, -5, 0, 4, 3, 89, -42, 0 };
            //Console.WriteLine(sayilar.Length);

            #endregion

            #region Rank

            // dizinin boyutunu veren özellik/property

            //Array sayilar = new int[] { 56, 32, 166, -5, 0, 4, 3, 89, -42, 0 };
            //Console.WriteLine(sayilar.Rank);

            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
