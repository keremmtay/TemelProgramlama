#region Karar Yapıları

// 2 çeşit karar yapımız var: switch case ve if - else yapıları

#region Switch Case Yapıları

//int gun;

//Console.WriteLine("Haftanın kaçıncı günü:");
//gun = Convert.ToInt32(Console.ReadLine());

//switch (gun)        // Hangi case çalışacağına karar veren veri switch (veri) parantez içerisindeki alana yazıyoruz.
//{

//    case 1:
//        // Buraya şart sağlandığında çalışmasını istediğimiz kodlarımızı yazıyoruz.
//        Console.WriteLine("Pazartesi");
//        break;
//    case 2:
//        Console.WriteLine("Salı");
//        break;
//    case 3:
//        Console.WriteLine("Çarşamba");
//        break;
//    case 4:
//        Console.WriteLine("Perşembe");
//        break;
//    case 5:
//        Console.WriteLine("Cuma");
//        break;
//    case 6:
//        Console.WriteLine("Cumartesi");
//        break;
//    case 7:
//        Console.WriteLine("Pazar");
//        break;
//    default:
//        // Eşleşen bir case bulunmaz ise buradaki kodlar çalışacak.
//        Console.WriteLine("Eşleşen case yok");
//        break;

//}
//Console.WriteLine("Switch bloğunun dışı");


#endregion

#region If Bloğu

// Belirli bir şarta göre programın akışını değiştiren kod bloğudur.

//if (koşul)
{
    // koşul true olduğunda çalışacak kodları bu bölüme yazıyoruz.

}

//Console.WriteLine("if bloğunun öncesi");

//if (false)
//{
//    Console.WriteLine("burası if bloğunun içi..");
//}

//Console.WriteLine("if bloğunun dışı");



//int sayi;
//Console.WriteLine("Bir sayı giriniz: ");
//sayi = Convert.ToInt32(Console.ReadLine());


//if (sayi > 10)
//{
//    Console.WriteLine("Girdiğiniz sayı 10'dan büyük");
//}



#endregion

#region If-Else Bloğu

// şart sağlanırsa if bloğu içindeki kod çalışacak, sağlanmaz ise else bloğu içindeki kod çalışacak.

//if (koşulumuz)
//{
//    // koşul sağlanırsa buradaki kodlar çalışacak
//    // koşul = true, burası çalışacak
//}
//else
//{
//    // koşul sağlanmadığı durumda çalışacak olan kodlar burada olacak
//    // koşul = false, buradaki kod çalışacak
//}



#endregion

#region Ornek If-Else

//int sayi = -10;

//if (sayi > 0)
//{
//    Console.WriteLine("Sayı pozitif");
//}
//else
//{
//    Console.WriteLine("Sayı negatif");
//}

//Console.WriteLine("if-else bloğunun dışındaki kodlar");

#endregion

#region If - Else If

//if (kosul1)
//{
//    // kosul1 true ise buradaki kodlar çalışıyor
//}
//else if (kosul2)
//{
//    // 2. koşul sağlanıyorsa buradaki kodlar çalışır
//}
//else if (kosul3)
//{
//    // 3. koşul sağlandığı durumda buradaki kodlar çalışır
//}
//else
//{
//    // yukarıdaki koşulların hiçbiri sağlanmıyorsa buradaki kodlar çalışacaktır
//}

#endregion

#region If - Else If Ornek

//int sayi = 0;

//if (sayi == 0)
//{
//    Console.WriteLine("Sayı 0'a eşittir");
//}
//else if (sayi > 0)
//{
//    Console.WriteLine("Sayı pozitif");
//}
//else if (sayi < 0)
//{
//    Console.WriteLine("Sayı negatif");
//}

//Console.WriteLine("if-else if bloğunun dışı");


#endregion

#region If - Else If Ornek 2

//string gun;
//Console.WriteLine("Gün adını giriniz:");
//gun = Console.ReadLine();

//if (gun == "Pazartesi")
//{
//    Console.WriteLine($"{gun} Haftanın 1. günü");
//}
//else if (gun == "Salı")
//{
//    Console.WriteLine($"{gun} Haftanın 2. günü");
//}
//else if (gun == "Çarşamba")
//{
//    Console.WriteLine($"{gun} Haftanın 3. günü");
//}
//else if (gun == "Perşembe")
//{
//    Console.WriteLine($"{gun} Haftanın 4. Günü");
//}
//else if (gun == "Cuma")
//{
//    Console.WriteLine($"{gun} Haftanın 5. Günü");
//}
//else if (gun == "Cumartesi")
//{
//    Console.WriteLine($"{gun} Haftanın 6. günü");
//}
//else if (gun == "Pazar")
//{
//    Console.WriteLine($"{gun} Haftanın 7. günü");
//}
//else
//{
//    Console.WriteLine($"{gun} geçerli bir gün adı değildir.");
//}

//Console.WriteLine("if-else if bloğunun dışı");

#endregion

#region İç içe if Kullanımı

// if, if-else, if-else if blokları iç içe çalışması aşağıdaki gibidir

//if (koşul1)
//{

//    if (koşul2)
//    {

//        if (koşul3)
//        {


//        }
//    }
//}

#endregion

#region İç içe if Örnek

// Kullanıcıdan kullanıcı adı ve şifresini alalım. eğer doğru ise sisteme login olsun.
// Yanlış ise, kullanıcı adı yanlış veya şifren yanlış şeklinde mesaj versin

//string kullaniciadi = "kerem";
//string sifre = "123";

//Console.WriteLine("Kullanıcı adı giriniz:");
//string girilenid = Console.ReadLine();

//Console.WriteLine("Şifre giriniz:");
//string girilensifre = Console.ReadLine();

//if (girilenid == kullaniciadi)
//{
    
//    if (girilensifre == sifre)
//    {
//        Console.WriteLine("Sisteme başarıyla giriş yaptınız.");
//    }
//    else
//    {
//        Console.WriteLine("Şifrenizi yanlış girdiniz.");
//    }
//}
//else
//{
//    Console.WriteLine("Kullanıcı adınızı yanlış girdiniz.");
//}


#endregion

#endregion

Console.ReadLine();