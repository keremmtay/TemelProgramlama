// kullanıcıdan 2 sayı alıp toplamları ekrana yazdıran program

int sayi1;

Console.WriteLine("1. sayıyı giriniz:");
sayi1 = Convert.ToInt32(Console.ReadLine());

int sayi2;

Console.WriteLine("2. sayıyı giriniz:");
sayi2 = Convert.ToInt32(Console.ReadLine());

int toplam = sayi1 + sayi2;

Console.WriteLine($"Toplam: {toplam}");

Console.Read();

