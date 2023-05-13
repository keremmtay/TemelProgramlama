// Operatörler
// 1 - Aritmatik Operatörler (+,-,*,/,%,++,--)

//int a = 10;
//int b = 25;
//int sonuc;

//a = 50;

// 4 işlem

//sonuc = a + b;
//sonuc = b - a;
//sonuc = a / b;
//sonuc = a * b;
//sonuc = a + 10;

//string ad = "Kerem";
//string soyad = "Tay";

//string isimSoyisim = ad + " " + soyad; //araya boşluk eklemek için " " yazılabilir


//Console.WriteLine(isimSoyisim);

//string yas = "15";

//string x;

//x = yas + 10;

//Console.WriteLine(x);

// % mod işlemleri yapmak için kullanılan operatördür

//sonuc = 10 % 3;

//sonuc = b % a;


// ++ Arttırma Operatörü

//int a = 5;

//a++;
//++a;
//a = a + 1;

//int b;
//b= a++;   // b=5 olarak alınır ve a=6 olarak. ++ işareti önde olursa önce arttırma işlemini sonra atama işlemini yapar

//Console.WriteLine(a);
//Console.WriteLine(b);

// -- Eksiltme Operatörü

//b = --a;

// ++ ile aynı çalışma mantığı

//Console.WriteLine(a);
//Console.WriteLine(b);

// 2 - Atama Operatörleri (=, +=, -=, *=, /=, %=)

// = Atama Operatörümüz.
// Operatörün sağındaki veriyi soldaki değişkene atamak için kullanıyoruz.

//int a = 5;
//int b;

//b = a;

//a = 15;

// +=

//Console.WriteLine(a);

/*a += 10; */   // a = a + 10;   a = 15

//Console.WriteLine(a);

// -=

//a = 10;
//Console.WriteLine(a);

//a -= 3;
//Console.WriteLine(a);


// *=

//a *= 3;

// /=

//a /= 2;
//Console.WriteLine(a);

// %=

//a %= 2;
//Console.WriteLine(a);


// 3 - Karşılaştırma Operatörleri (==, !=, <, >, <=, >=)

// Geriye True ya da False türünde bir veri oluşturuyoruz.

//int sayi1 = 10, sayi2 = 10, sayi3 = 20;
//bool sonuc;

// == Eşitlik var mı? Varsa True, yoksa False değerini verecek

//sonuc = sayi1 == sayi2;

//Console.WriteLine(sonuc);
//Console.WriteLine(sayi1 == sayi3);

// != Eşitlik yok mu? Eşitlik yoksa true, eşitlik varsa false değerini verir. == komutunun tersi şeklinde çalışır

//sonuc = (sayi1 != sayi2);
//sonuc = (sayi2 != sayi3);
//Console.WriteLine(sonuc);

// < küçük mü? sağ taraftaki değer ile sol taraftaki değer karşılaştırılıyor. sol taraftaki değer küçük ise True değilse False değerini döndürüyor.

//sonuc = sayi1 < sayi3;
//Console.WriteLine(sonuc);

// > büyük mü? sağ taraftaki değer ile sol taraftaki değer karşılaştırılıyor. Sol taraftaki değer büyükse True, değilse False değerini döndürüyor.

//sonuc = sayi3 > sayi1;
//Console.WriteLine(sonuc);

// <= Sol taraftaki değer sağ taraftaki değerden küçük ya da eşit mi sorusunu soruyor. küçük ya da eşitse True değilse False değerini döndürüyor.

// >= Sol taraftaki değer sağ taraftaki değerden büyük ya da eşit mi sorusunu soruyor. büyük ya da eşitse True değilse False değerini döndürüyor.


//sonuc = sayi1 <= sayi2;       // True
//sonuc = sayi3 <= sayi1;       // False

//sonuc = sayi3 >= sayi1;       // True

//Console.WriteLine(sonuc);


// 4 - Mantıksal Operatörler (&&(and), ||(or), !(not)) 

// and operatöründe iki değer de true verirse sonuç true çıkar. or operatöründe bir tanesinin true olması sonucu true verir. not operatörü sonucu tersine çevirir, true olan sonuç false olarak gözükür

//bool b1 = true;

//b1 = 35 > 10 && 10 == 50;   //False
//b1 = 35 > 10 && 10 != 50;   //True

//b1 = 5 < 5 || 12 * 3 != 120;    //True

//b1 = !(15 <= 30);   //False

//Console.WriteLine(b1);









Console.Read();


