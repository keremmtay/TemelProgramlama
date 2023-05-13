// 100'lük sistemdeki notları harfli sisteme çeviren programı yazın
//Kullanıcı notunu girecek karşılığında bize harfli sistemdeki karşılığını verecek.
// A = 85-100
// B = 65-84
// C = 50-64
// D = 45-49
// F = 0-44


int not;

Console.WriteLine("Notunuzu girin:");
not = Convert.ToInt32(Console.ReadLine());

if (not>=85 && not<=100)
{
    Console.WriteLine("Harf Notunuz A");
}
else if (not>=65 && not<=84)
{
    Console.WriteLine("Harf Notunuz B");
}
else if (not>=50 && not<=64)
{
    Console.WriteLine("Harf Notunuz C");
}
else if (not>=45 && not<=49)
{
    Console.WriteLine("Harf Notunuz D");
}
else if (not>=0 && not<=44)
{
    Console.WriteLine("Harf Notunuz F");
}
else
{
    Console.WriteLine("Geçerli bir not girmediniz.");
}
Console.ReadLine(); 