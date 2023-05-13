///// 4 işlem yapılacak
///// Önce ekrana yapılacak işlemlerin listesi çıkacak
///// Kullanıcıdan hangi işlemin yapılacağı bilgisi alınacak, Toplama (+), Çıkarma (-), Çarpma (*), Bölme (/)
///// switch case ile yapılan seçime göre ilgili case'e gidecek
///// Kullanıcıdan işlem yapılacak sayılar alınacak
///// İşlem yapılacak ve ekrana yazılacak
///// 


//double sayi1;
//double sayi2;
//double sonuc;
//string islem;
//string toplama = "+";
//string cikarma = "-";
//string carpma = "*";
//string bolme = "/";

//Console.WriteLine("*** Hesap Makinesi ***");

//Console.WriteLine("Mevcut olan işlemler:");

//Console.WriteLine("Toplama için = +");
//Console.WriteLine("Çıkarma için = -");
//Console.WriteLine("Çarpma için = *");
//Console.WriteLine("Bölme için = /");

//Console.WriteLine("Hangi işlem yapılacak?");
//islem = Convert.ToString(Console.ReadLine());


//Console.WriteLine("1. sayıyı giriniz:");
//sayi1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("2. sayıyı giriniz:");
//sayi2 = Convert.ToDouble(Console.ReadLine());

//switch (islem) // neyi kontrol ediyoruz? işlem değişkenini, işlemin içerisindeki veri case'lerde var mı yok mu? Varsa ilgili case'e gider yoksa default çalışır. Default yoksa switch bloğunun dışından devam eder.
//{
//    case "+":
//        Console.WriteLine($"Sonuç: {sayi1 + sayi2}");
//        break;
//    case "-":
//        Console.WriteLine($"Sonuç: {sayi1 - sayi2}");
//        break;
//    case "*":
//        Console.WriteLine($"Sonuç: {sayi1 * sayi2}");
//        break;
//    case "/":
//        Console.WriteLine($"Sonuç: {sayi1 / sayi2}");
//        break;
//    default:
//        Console.WriteLine("Geçerli bir işlem girmediniz");
//        break;
//}

//Console.ReadLine();