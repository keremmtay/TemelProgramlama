using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDongusu
{
    internal class WhileDongusu
    {
        static void Main(string[] args)
        {
            #region while Döngüsü

            // syntax'ı aşağıdaki gibidir.
            // For döngüsü ile yapabildiğimiz herşeyi bu döngü ile de yapabiliriz.
            // Genel olarak nerelerde kullanılır dersek; Sonsuz döngülerde ya da süreci bilinmeyen döngülerde kullanabiliriz.

            //while (kosul)
            //{
            //    // Tekrarlanmasını istediğimiz kodlarımızı buraya yazıyoruz
            //}


            #endregion

            #region Ornek-1

            // 1'den 10'a kadar sayıları ekrana yazdıralım

            // for ile yazdırmak isteseydik yazmamız gereken kod

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            #endregion

            #region Ornek-2

            // Klavyeden girilen bir sayıdan 0'a kadar sayan programı yazalım

            //Console.Write("Bir sayı giriniz:  ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    while (sayi >= 0)
            //    {
            //        Console.WriteLine(sayi);
            //        sayi--;
            //    }
            //}
            //else
            //{
            //    while (sayi <= 0)
            //    {
            //        Console.WriteLine(sayi);
            //        sayi++;
            //    }
            //}

            ////2. yol
            ///
            //Console.Write("Bir sayı giriniz:  ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //bool x = true;
            //while (x)
            //{
            //    Console.WriteLine(sayi);
            //    sayi--;
            //    if (sayi < 0)
            //    {
            //        x = false;  
            //    }
            //}
            #endregion

            #region Ornek-3

            //  Klavyeden 0 girinceye kadar çalışan program
            // DRY => Don't repeate yourself! kavramını araştır

            //int sayi = 1;

            //while (sayi != 0)
            //{
            //    Console.Write("Bir sayı giriniz:  ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girdiğiniz sayı " + sayi);
            //}

            //Console.WriteLine("\t\t\t**Program sonlanıyor**");

            #endregion

            #region do-while döngüsü

            // while döngüsünün kardeşi, çalışma mantığı while döngüsü ile aynı
            // Tek farkı döngünün içindeki kodlar önce bir kere çalışıyor, sonra karşılaştırma yapılıyor
            // syntax'ı aşağıdaki gibidir:

            //do
            //{
            //    Console.WriteLine("Döngü içerisindeki kodlar");
            //} while (true);

            // koşul sağlansa da sağlanmasa da döngü içerisindeki kodlar 1 kere çalışır, tekrar çalışması için koşulun sağlanması gerekir


            #endregion

            #region Ornek-4

            // 0'a basıncaya kadar çalışan programı yazınız
            //int sayi = 1;
            //do
            //{
            //    Console.WriteLine("Bir sayi girin...: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //} while (sayi != 0);

            #endregion

            #region Ornek-5

            // Klavyeden girdiğimiz sayıları toplayarak ekranda göstersin. 0'a bastığımızda döngü sonlansın.

            //int toplam = 0;
            //int sayi = 1;
            //do
            //{
            //    Console.Write("Bir sayı giriniz:\t");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam = toplam + sayi;
            //    Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);
            //} while (sayi != 0);

            #endregion

            #region Ornek-6

            // Sayı tahmin oyunu
            // Bilgisayar bir sayı üretecek
            // Kullanıcı klavyeden bir sayı girerek bu sayıyı tahmin etmeye çalışacak
            // Bilemediği takdir oyun devam edecek ve tekrar deneyiniz yazacak. Tekrar bir sayı tahmin edilecek.
            // sayı bilinirse oyun sonlanacak

            //Random random = new Random();
            //int rastgele = random.Next(1, 10);
            //int sayi = 0;
            //do
            //{
            //    Console.Write("Sayıyı tahmin etmeye çalışınız: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi != rastgele)
            //    {
            //        Console.WriteLine("Tekrar deneyiniz.");
            //    }

            //} while (sayi != rastgele);

            //Console.WriteLine("\n\t\t\t\t***Tebrikler, doğru bildiniz.***");

            #endregion

            #region Ornek-7

            // Hesap makinesi oyunu (4 işlem yapılacak)
            // Ekranda seçenekler görünecek. Çıkış için X harfine basıldığında programdan çıkılacak

            /// Toplama +
            /// Çıkarma -
            /// Çarpma *
            /// Bölme /
            /// Çıkış X
            /// 

            //bool devamMi = true;

            //do
            //{

            //    Console.WriteLine("**** Hesap Makinesi ****\n\n1 - Toplama (+)\n2 - Çıkarma (-)\n3 - Çarpma (*)\n4 - Bölme (/)\n5 - Çıkış (x)\n");

            //    Console.Write("Yapmak istediğiniz işlemi seçin.:");
            //    char secim = Convert.ToChar(Console.ReadLine());
            //    int sayi1;
            //    int sayi2;

            //    switch (secim)
            //    {
            //        case '+':
            //            Console.WriteLine("Bir sayı giriniz.");
            //            sayi1 = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("Bir sayı giriniz.");
            //            sayi2 = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine($"Toplama işleminin sonucu : {sayi1 + sayi2}\n");
            //            break;
            //        case '-':
            //            Console.WriteLine("Bir sayı giriniz.");
            //            sayi1 = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("Bir sayı giriniz.");
            //            sayi2 = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine($"Çıkarma işleminin sonucu : {sayi1 - sayi2}\n");
            //            break;
            //        case '*':
            //            Console.WriteLine("Bir sayı giriniz.");
            //            sayi1 = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("Bir sayı giriniz.");
            //            sayi2 = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine($"Çarpma işleminin sonucu : {sayi1 * sayi2}\n");
            //            break;
            //        case '/':
            //            Console.WriteLine("Bir sayı giriniz.");
            //            sayi1 = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("Bir sayı giriniz.");
            //            sayi2 = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine($"Bölme işleminin sonucu : {sayi1 / sayi2}\n");
            //            break;
            //        case 'x':
            //        case 'X':
            //            devamMi = false; // devamMi değişkeni ilk aşamada true değerini aldığı için döngü sürekli çalışacak. Eğer x ya da X tuşuna basılırsa bu durumda buradaki case çalışacak. Burada da devamMi değişkenin içeriğini false olarak değiştirdiğimizde while(false) olacağından döngü tekrarlamayacaktır.
            //            break;

            //        default:
            //            Console.WriteLine("Seçiminiz yanlış, lütfen doğru seçimi yapınız...\n");
            //            break;
            //    }



            //} while (devamMi);

            //Console.WriteLine("Hesap makinesi kapatılıyor.");

            #endregion





            Console.ReadLine();
        }
    }
}
