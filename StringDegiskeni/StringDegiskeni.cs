using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDegiskeni
{
    internal class StringDegiskeni
    {
        static void Main(string[] args)
        {

            #region String

            // String değişkeni özel bir değişkendir. Yapısı diğer değişkenlerden farklıdır. int, short, byte, long, char, decimal, float, double... bu değişkenleri value type değişkenlerdir. Yani memory'de Stack bölümünde tutulur.. Ve değişken tanımlaması yapılırken ilgili keywordlerden faydalanılır.

            // string diğer türlerden farklı olarak Referance Type türündedir. Fakat kendisine özgü keywordü bulunur..

            // Diğer tipler memory'de Stack'te tutuluyor fakat string Heap'de tutuluyor..

            //string sehir;
            //sehir = "İzmir";

            #endregion

            #region Null ve Empty durumları

            //string a = "";  // ile boş değerli (empty) bir string nesnesi bellekte yaratmış oluyoruz.

            //string b = null;
            //string c;       // bu 2 durumda da null olarak değişken tanımlaması yapmış oluyoruz.
            // Referans tip değişkenler null değer alabilirler
            // Value Type değişkenler null değer alamazlar..
            //string sehir1 = null;

            //int? sayi = null; // Value Type'ları null yapabilmek için değişken türünden sonra "?" eklememiz gerekiyor.

            // Bir değişken null değer alabiliyorsa, bu değişken için Ram'de herhangi bir alan ayrılmaz.

            #endregion

            #region Empty

            // Bir değişken empty ise bu değişken için Ram'de yer ayrılmıştır fakat değeri verilmemiştir.

            //int m; // Empty olarak tanımlanan bir değişken.. m = 0

            //bool l = false; // Empty

            //string isim = ""; // Empty

            //string isim1 = "    "; // Empty değil, çünkü içerisindeki boşluk karakteri de bir veri olarak sayılır

            // Null bir değişken ilk çalıştığımızda hata verecektir. (Runtime) 

            // Empty bir değişken ile çalıştığımızda hata vermeyecek. Çünkü default olarak almış oldukları değerleri kullanacaktır.



            #endregion

            #region String Metodları ve Property'lerinin kullanımı

            // elimdeki değişkenin içerisinde veri olup olmadığını kontrol etmek için kullanacaığım br metod

            //string sehir = "";

            //if (sehir != string.Empty && sehir != null)
            //{
            //    // sehir isimli değişken empty ve null değilse burası çalışacak

            //}

            // 2. yol

            //if (string.IsNullOrEmpty(sehir))
            //{
            //    Console.WriteLine("sehir değişkeni empty ya da null olarak tanımlanmış");
            //}
            //else
            //{

            //}


            #endregion

            #region IsNullOrWhiteSpace Fonksiyonu

            // Eğer IsNullOrEmpty ile kontrol ettiğimizde değişkenin içeriğinde boşluk karakteri varsa bu durum içerisinde veri varmış gibi kabul edecek ve geriye false döndürecektir.

            //string isim = "     ";

            //if (string.IsNullOrWhiteSpace(isim))
            //{
            //    Console.WriteLine("isim içerisindeki veri boşluk karakterlerine sahip...");
            //}

            #endregion

            #region string, char türünde bir dizidir.

            // string char türünde bir dizidr..

            //string sehir = "İstanbul";

            //for (int i = 0; i < sehir.Length; i++)
            //{
            //    Console.WriteLine(sehir[i]);
            //}

            #endregion

            #region string ile + Operatörü

            //string a = "İstanbul";
            //string b = "Manisa";

            //string c = a + b;
            //Console.WriteLine(c);

            #endregion

            #region String formatlandırma

            //string isim = "Mustafa";
            //string soyisim = "Kerem";
            //string kimlikNo = "12345678905";
            //int yas = 24;

            //// + ile formatlandırma

            //string sonuc = isim + " " + soyisim + " " + kimlikNo;


            //Console.WriteLine(sonuc);

            // interpolation formatlandırma

            //sonuc = $"{isim} - {soyisim} - {kimlikNo}";

            //Console.WriteLine(sonuc);

            //// parametre ile formatlandırma

            //Console.WriteLine("Adı: {0}  -  Soyadı: {1}  -  Kimlik Numarası: {2}", isim, soyisim, kimlikNo);


            #endregion

            #region String Fonksiyonları

            #region Contains

            // bir metinsel ifadenin içerisinde bir veri var mı yok mu kontrolünü yapıyor.

            //string metin = "Bugün hava çok güzel.";

            //if (metin.Contains("çok"))
            //{
            //    Console.WriteLine("çok verisi metin içerisinde bulunuyor.");
            //}

            #endregion

            #region StartsWith
            //Console.WriteLine(metin.StartsWith("Bug1"));
            #endregion

            #region EndsWith

            //Console.WriteLine(metin.EndsWith("Güzel."));

            // Büyük küçük harf duyarlılığı mevcut.. Dikkat edilmesi gerekiyor..

            #endregion

            #region Equals

            // 2 adet metinin birbirine eşit olup olmadığını kontrol ediyor.

            //Console.WriteLine(metin.Equals("Bugün hava çok güzel."));

            #endregion

            #region Compare

            // Metinsel ifadeleri karşılaştırıp sonuc olarak int türünde bir sonuç döndüren metodtur. 0,1,-1 değerlerini döndürür.
            // 0 ise eşit
            // 1 ise soldaki sağdakinden alfanumerik olarak büyük
            // -1 ise soldaki sağdakinden alfanumerik olarak küçük

            //int sonuc = string.Compare(metin, "Havalar sıcak");
            //sonuc = string.Compare(metin, "Acaba bugün.....");
            //sonuc = string.Compare(metin, "Bugün hava çok güzel.");

            //Console.WriteLine(sonuc);

            #endregion

            #region IndexOf

            // Aradığımız ifade ilgili metinde var mı yok mu? Varsa index numarasını geriye döndürüyor.

            //sonuc = metin.IndexOf("çok");
            //Console.WriteLine(sonuc);

            #endregion

            #region Insert

            // Metinsel bir ifadeye farklı bir metinsel veri eklememizi sağlıyor.
            //metin.Insert(5, "Mustafa");
            //Console.WriteLine(metin.Insert(5, "Mustafa"));

            #endregion

            #region Remove

            //metin.Remove(10); // indeks 10'dan itibaren verileri siler
            //Console.WriteLine(metin.Remove(10));

            //Console.WriteLine(metin.Remove(10, 3));

            #endregion

            #region Replace

            //Console.WriteLine(metin.Replace('ü', 'u')); // Karakter değiştirme için kullanılır. İlk yazılan karakter ikinciyle değiştirilir.

            #endregion

            #region Split

            // Belirlenen karakterden sonra alt satıra geçilmesini, o noktadan ayrılmasını sağlar.

            //string[] sonuc1 = metin.Split(' ');

            //for (int i = 0; i < sonuc1.Length; i++)
            //{
            //    Console.WriteLine(sonuc1[i]);
            //}

            #endregion

            #region ToLower

            //Console.WriteLine(metin.ToLower()); // tüm harfleri küçük yapar

            #endregion

            #region ToUpper

            //Console.WriteLine(metin.ToUpper()); // tüm harfleri büyük yapar

            #endregion

            #region Trim

            //string metin2 = "       Merhaba Dünya       .";

            //Console.WriteLine(metin2.Trim()); // tüm boşlukları siler
            //Console.WriteLine(metin2.TrimEnd()); // sondaki boşlukları siler
            //Console.WriteLine(metin2.TrimStart()); // baştaki boşlukları siler

            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
