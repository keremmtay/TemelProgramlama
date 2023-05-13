// Girilen X sayısının yine girilen Y sayısına tam bölünüp bölünmediğini kontrol eden programı yazınız

int X;
int Y;

Console.WriteLine("X sayısını girin:");
X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Y sayısını girin:");
Y = Convert.ToInt32(Console.ReadLine());

int bolum = X % Y;

if (bolum == 0)
{
    Console.WriteLine("X sayısı Y sayısına tam bölünmektedir.");
}
else
{
    Console.WriteLine($"X sayısı Y sayısına tam bölünmemektedir. Kalan = {bolum}");
}

Console.ReadLine();