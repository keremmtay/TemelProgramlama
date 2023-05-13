using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Ornekleri
{
    internal class Algoritma_Ornekleri
    {
        static void Main(string[] args)
        {
            #region Ornek-1

            // Birbirinden farklı olarak verilen iki adet sayıdan, büyük olanı bulup gösteren algoritma ve akış diyagramını tasarlayınız.

            //Console.WriteLine("Birinci sayıyı giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci sayıyı giriniz:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Girdiğiniz ilk sayı, ikinci sayıdan büyüktür.");
            //}
            //else if (sayi2 > sayi1)
            //{
            //    Console.WriteLine("Girdiğiniz ikinci sayı, ilk sayıdan büyüktür.");
            //}


            #endregion

            #region Ornek-2

            // Girilen vize ve final notlarına göre öğrencinin dersten geçip geçmediğini bulan algoritma ve akış diyagramını tasarlayınız.

            //Console.WriteLine("Vize notu giriniz:");
            //double vize = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Final notu giriniz:");
            //double final = Convert.ToDouble(Console.ReadLine());

            //double gecme = (vize * 0.3) + (final * 0.7);

            //if (gecme > 50)
            //{
            //    Console.WriteLine("Ortalama not= " + gecme + "\nÖğrenci dersten başarıyla geçmiştir.");
            //}
            //else
            //{
            //    Console.WriteLine("Ortalama not= " + gecme + "\nÖğrenci dersten başarısız olmuştur.");
            //}

            #endregion

            #region Ornek-3

            // Verilen tamsayının sıfır, pozitif ya da negatif olup olmadığını bulan algoritma ve akış diyagramını tasarlayınız.

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Girmiş olduğunuz sayı pozitiftir.");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Girmiş olduğunuz sayı negatiftir.");
            //}
            //else if (sayi == 0)
            //{
            //    Console.WriteLine("Girmiş olduğunuz sayı sıfırdır.");
            //}


            #endregion

            #region Ornek-4

            // Ekrana 10 defa programcının adını yazan algoritmayı yapınız”.

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Mustafa Kerem");
            //}

            #endregion

            #region Ornek-5

            // 1’den 100’e kadar tek sayıları yazdıran algoritma ve akış diyagramını yapınız.

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            #endregion

            #region Ornek-6

            // Klavyeden girilen fiyatı, KDV(%18) ekleyerek ekrana yazdırın.

            //Console.WriteLine("Ürünün fiyatını giriniz:");
            //double fiyat = Convert.ToDouble(Console.ReadLine());


            //double kdv = fiyat + (fiyat * 0.18);
            //Console.WriteLine("\nÖdemeniz gereken tutar: " + kdv);


            #endregion

            #region Ornek-7

            // Beş sayının toplamını ve ortalamasını veren programa ait algoritmayı oluşturunuz.

            //double toplam = 0;
            //double ort = 0;
            //double sayi;

            //for (int i = 1; i < 6; i++)
            //{
            //    Console.Write($"{i}. sayıyı giriniz:\t");
            //    sayi = Convert.ToDouble(Console.ReadLine());

            //    toplam = toplam + sayi;

            //}

            //Console.WriteLine("\nGirdiğiniz sayıların toplamı:\n" + toplam);
            //ort = toplam / 5;
            //Console.WriteLine("\nGirdiğiniz sayıların ortalaması:\n" + ort);


            #endregion

            #region Ornek-8

            // Klavyeden girilen sayı kadar (N) sayının faktoryelini alan programın akış şeması.

            //int sayi;
            //int faktoriyel = 1;
            //Console.WriteLine("Klavyeden bir sayı giriniz:");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel = faktoriyel * i;
            //}

            //Console.WriteLine(faktoriyel);
            #endregion

            #region Ornek-9

            // Klavyeden girilen Fahrenayt derecesini Cantigrad’a çeviren programın akış şemasını çizin.

            //double fahrenheit;
            //double celsius;

            //Console.WriteLine("Fahrenayt cinsinden derece giriniz:");
            //fahrenheit = Convert.ToDouble(Console.ReadLine());

            //celsius = (fahrenheit - 32) * 0.5556;

            //Console.WriteLine(celsius);


            #endregion

            #region Ornek-10

            // ax²+bx+c=0 şeklinde verilen 2. derece denklemin köklerini bulan programın akış diyagramını çizin.

            //int a;
            //int b;
            //int c;



            #endregion

            #region Ornek-11

            // Bir ürünü alış fiyatı üzerinden klavyeden vergi oranı ve kar oranı eklenerek satış fiyatına hesaplayan programın algoritması nedir?

            #endregion

            #region Ornek-12

            // Üniversite bir dersin başarı notu bir vize bir final sınav notu ile hesaplanır . vize notunun kat sayısı %30 final notunun kat sayısı %70’dir. Bir öğrencinin sınavda almış olduğu bu notlar neticesinde ders ortalaması bulan programın algoritmasını ve akış şemasını çiziniz.

            #endregion

            #region Ornek-13

            // Yükseklik ve taban uzunluğu klaveden girilen üçgenin alanını hesaplayan uygulamayı gerçekleştiriniz .

            #endregion

            #region Ornek-14

            // Bir iletkenin kutupları arasındaki gerilim (V) iletkenden geçen amper türünde akım (I) iletken üzerinde var olan direncin (R) çarpımına eşittir. V=I*R formülüyle gösterilir. Formülden faydalanarak kullanıcı tarafından girilen akım ve direnç değerlerine göre iletkenin kutupları arasındaki gerilimi hesaplayan programın algoritmasını oluşturunuz.

            #endregion

            #region Ornek-15

            // Klavyeden girilen bir sayının pozitif ya da nagatif olduğunu ekrana yazdıran algoritmayı oluşturunuz.

            #endregion

            #region Ornek-16

            // Öğrencinin bir dersten aldığı not klavyeden girilerek başarı durumu ekrana geçti veya kaldı şeklinde yazan uygulamanın algoritmasını oluşturunuz .

            #endregion

            #region Ornek-17

            // Bir öğrencinin derslerinden 2 not ve 1 sözlü klavyeden girilerek başarı durumu ekrana “geçti” ve “kald”ı şeklinde yazan algoritmayı oluşturun.

            #endregion

            #region Ornek-18

            // Kullanıcıdan alınan sayının tek ya da çift olduğunu  kontrol edip ekranda yazdıran algoritmayı oluşturun.

            #endregion

            #region Ornek-19

            // Üniversite için vize final notları yapılmaktadır. Bir öğrencinin dersten geçme şartı vizenin %30 ile final notunun %70 in toplamı 50 ve üzeri ve final notunun 50 ve daha yüksek olmasıdır. Buna uygun algoritmayı oluşturunuz.

            #endregion

            #region Ornek-20

            // Kullanıcının klavyeden girdiği sayı 3’ e ve 5’ e tam bölünüyorsa ekrana tam bölünüyor yazan bölünmüyor sa bölünmüyor yazan algoritmayı oluşturun.

            #endregion

            #region Ornek-21

            // Kullanıcının klavyeden girdiği sayı 0-100 aralığındaysa ekranda “geçerli” değilse “geçersiz” yazan algoritmayı oluşturun.

            #endregion

            #region Ornek-22

            // Öğrencinin sınavdan almış olduğu puana göre notunu ekrana yazdıran programın sahte kodlarını yazınız ?

            #endregion

            #region Ornek-23

            // Suyun sıcaklık derecesine göre katı sıvı gaz halinde olduğu bulan ve ekrana yazan algoritma ?

            #endregion

            #region Ornek-24

            // Kullanıcıdan ax2+bx+c=0 şeklindeki ikinci derecede denkleme ait a,b ve c değerleri istenerek deltayı hesaplayan ve gösteren çıkan delta sonucuna göre denklemin köklerinin yukardaki tabloya göre gösterilmesi sağlanan algoritma ?

            #endregion

            #region Ornek-25

            // Klavyeden girilen 0 ile 99.999 arasındaki basamak sayısını ekrana yazdıran algoritma ?

            #endregion

            #region Ornek-26

            // Bir fabrikada sabit maaşla çalışan işçiler aile durumlarına göre ek maaş almaktadırlr. Çocuk sayısı 1 ise maaşının %5’i kadar , çocuk sayısı 2 ise %10’u 3 ve daha fazla ise %15’i kadar aile yardımı almaktadır. Buna göre kullanıcıdan işçinin maaşı ve çocuk sayısı istenerek gerekli hesaplamayı yapan algoritma ?

            #endregion

            #region Ornek-27

            // Bir fabrikada işçinin alacağı ücret hesaplanırken şu kraterlere uyulmaktadır ; Eğer işçi 40 saatten az çalışmışsa çalıştığı saat ve saat ücreti çarpılarak alacağı ücret hesaplanıyor , eğer işçi 40 saat ve daha fazla çalışmışsa çalıştığı saat 2 saat olarak hesaplanacak buna göre bilgileri alınarak ödenecek tutarı yazdıran algoritması.

            #endregion

            #region Ornek-28

            // 2.Dereceden Denkelem köklerini bulan programa ait akış şeması örneği.

            #endregion

            #region Ornek-29

            // Bir ücretlinin sicil numarası, çalışma saati ve saat ücreti bilgisayara giriş olarak veriliyor.Ücretlinin bu bilgilerle maaşını hesaplayan algoritmayı ve akış şemasını çiziniz.

            #endregion

            #region Ornek-30

            // İki sayının farkını bulan algoritmayı yapınız.

            #endregion

            #region Ornek-31

            // Klavyeden girilen N sayısına göre 1 den N ye kadar olan tek sayıların toplamı ve çarpımı çift sayıların ise karelerinin toplamını bulan programın algoritması

            #endregion

            #region Ornek-32

            // Klavyeden girilen 10 sayıyı toplayan ve sonucu ekranda gösteren programın algoritmasını yazınız.

            #endregion

            #region Ornek-33

            // Klavyeden girilen a ve b sayıları arasındaki sayıları listeleyen Akış Şeması Örneği:

            #endregion

            #region Ornek-34

            // Klavyeden 2 sayı girilecek daha sonra işlem numarası girilecek girilen işlem numarasına gööre işlem yapılacak sonuç ekranda görüntelenecek algoritma akış diyagramı

            #endregion

            #region Ornek-35

            // Klavyeden girilen 3 basamaklı sayının 1. 2. ve 3. basamağını (Basamak Değerlerini) yazdıran programın algoritması.

            #endregion

            #region Ornek-36

            // Ekrana 10 defa Adını yazdıran Akış Şeması

            #endregion

            #region Ornek-37

            // Bir dersten 3 sınav notu alan bir öğrencinin : a- ortalamasını, b-5 li sistemdeki not karşılığını, c-harfli sistemdeki not karşılığını yazdıran programın algoritmasını ve akış diyagramını tasarlayınız.

            #endregion

            #region Ornek-38

            // Bir fabrikada sabit maaşla çalışan işçiler aile durumlarına ve ürettikleri parça sayısına göre de ek maaş almaktadır. Aşağıda verilen yönergelere göre işçilerin maaşlarını hesaplayan programın algoritmasını ve akış diyagramını tasarlayınız.

            #endregion

            #region Ornek-39

            // Klavyeden 3 adet kenar uzunluğu giriliyor. Girilen kenar uzunlukları ile : a-Üçgenin çizilip çizilemeyeceğini, b-Eğer üçgen çizilirse Üçgenin çeşidini(ikizkenar, çeşitkenar, eşkenar), c- çizilen üçgenin alan ve çevresini bulup ekrana yazan programın algoritmasını ve akış diyagramını tasarlayınız.


            #endregion

            #region Ornek-40

            // Girilen 10 adet sayi içerisinden pozitiflerin ve negatiflerin ve “0”  sayısını ayrı ayrı bulan akış şeması.

            #endregion

            #region Ornek-41

            // Kürenin alanını ve hacmini hesaplayan algoritma ve akış şeması örneği.

            #endregion

            #region Ornek-42

            // Silindirin Alanı ve Hacmini hesaplayan algoritma ve akış şeması örneği



            #endregion

            #region Ornek-43

            // Girilen 3 sayıdan en büyüğünü bulan algoritma örneği

            #endregion

            #region Ornek-44

            // 7-24 arası tek sayıların toplamını ve ortalamasını bulan algoritma

            #endregion

            #region Ornek-45

            // Klavyeden Girilen 3 sayının ortalamasını alan algoritma

            #endregion

            #region Ornek-46

            // Klavyeden girirlen 5 adet sayının ortalamasının döngü mantnığı ile bulup ekrana yazdıran akış diyagramını oluşturunuz.

            #endregion

            #region Ornek-47

            // 1 ile 40 arasında bulunan 5 in katı olan sayıları ekrana yazan akış şeması

            #endregion

            #region Ornek-48

            // Çarpma kullanmadan klavyeden girilen sayının 3 katını bulan akış diyagramı.

            #endregion

            #region Ornek-49

            // Taban uzunluğu ve yüksekliği girilen paralelkenarın alanını hesaplayan algoritma.

            #endregion

            #region Ornek-50

            // Klavyeden girilen 1-25 arasındaki bir tamsayının faktöriyelini alan programın algoritma ve akış diyagramını

            #endregion

            #region Ornek-51

            // Klavyeden ardı ardına sayı girişi isteyen ve bu sayı 10 ile 15 arasında olmadığı sürece bu işleme devam eden programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-52

            // 1den 25 e kadar olan sayıların kareleri toplamını bulan programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-53

            // Klavyeden 10 tane tamsayı girilmesini isteyen ve bu girilen tamsayılardan kaç tanesinin negatif olduğunu bulan programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-54

            // a,b,ve c klavyeden girilmek üzere, ax2+bx+c=0 şeklindeki bir denklemin köklerini bulan programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-55

            // Klavyeden girilen 1-12 arasındaki tamsayıların hangi aya denk geldiğini bulup ekrana yazan programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-56

            // Dört işleme birer kod numarası vererek, klavyeden girilen iki sayıyı yine klavyeden girilen işlem koduna göre toplayan, çıkaran, çarpan veya bölen programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-57

            // Klavyeden ardı ardına girilen sayıları toplayan ve girilen sayı negatif olduğunda duran programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-58

            // Klavyeden bir not girilmesini isteyen ve bu not 0-49 arasındaysa “Başarısız”, 50-64 arasındaysa “Orta”, 65-84 arasındaysa “İyi”, 85-100 arasındaysa “Çok iyi “ Yazan programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-59

            // Klavyeden girilen iki tamsayıdan büyük olanı bulup ekrana yazdıran programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-60

            // Klavyeden girilen iki pozitif tamsayıdan birincisinin ikincisi cinsinden kuvvetini alan programın algoritma ve akış diyagramını hazır fonksiyon kullanmadan yazınız.

            #endregion

            #region Ornek-61

            // n! değerini hesaplayan programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-62

            // 1+4+9+ … +100= değerini hesaplayan programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-63

            // Toplama, çıkarama, çarpma ve bölme işlemi yapan programın algoritma ve akış diyagramını yazınız.

            #endregion

            #region Ornek-64

            // Saatte ortalama 60 km yol giden bir aracın, klavyeden girilen mesafeyi kaç saatte gideceğini hesaplayan programın algoritma ve akış diyagramını yazınız.

            #endregion


          
            Console.ReadLine();

        }
    }
}
