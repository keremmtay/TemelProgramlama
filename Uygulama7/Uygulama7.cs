// Klavyeden 2 ürünün fiyatını girin. Toplam ürün fiyatı 200TL üzeri ise 2. ürüne %25 indirim yaparak ödenmesi gerek toplam ücreti ekrana yazdıran programı yazın.

double fiyat1;
double fiyat2;

Console.WriteLine("1. ürünün fiyatını giriniz:");
fiyat1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("2. ürünün fiyatını giriniz:");
fiyat2 = Convert.ToDouble(Console.ReadLine());

double toplam = fiyat1 + fiyat2;

if (toplam > 200)
{
    toplam = fiyat1 + (fiyat2 * 0.75);
    Console.WriteLine($"Ürünlerin toplam fiyatı = {toplam}");
}
else
{
    Console.WriteLine($"Ürünlerin toplam fiyatı = {toplam}");
}

Console.ReadLine(); 