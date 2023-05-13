// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");

// Comment line - Açıklama satırı

/// Alt satıra da devam eden açıklama satırı
/// 2. satıra devam etmesi için boş bırakılmaması gerekiyor
/// 

/* Bunun da arasına açıklama yazabiliyoruz 
 
 
 bunu da uzatabiliyoruz */

// Değişkenler
// DeğişkeninTürü DeğişkeninAdı = DeğişkeninDeğeri

// Satırların sonuna ";" işareti koyulmak zorunda

// Değişken Adları nasıl olmalı?
// C# büyük küçük harf duyarlıdır. sayi ile Sayi farklı değişkenlerdir.

//int sayi = 10;
//int Sayi = 10;

// Tanımladığımız değişkenler rakam ile başlayamaz

// int sayi1;
//int 1sayi;


// Değişken tanımlarken arada boşluk kullanamayız.

//string AdiSoyadi;
//int birinciSayi;

// Özel karakterleri kullanamayız. (_ hariç olmak üzere)

// int sayi*;
// int sayi/;
// % & GetIndexBinder karakterler kullanılamaz.

//string Adi_Soyadi; _ kullanılabilir

// for, if, else, switch, class, abstract gibi dile özgü anahtar kelimeleri değişken isimleri olarak kullanamayız.

// int for; kullanılmaz ancak int forUser; kullanılabilir.

// Daha önce tanımlanan değişken adı aynı blok/scope içerisinde tekrar kullanılamaz.

// İsimlendirme kuralları
// snake_case: _ işaretini kullanarak isimlendirme yapabiliyoruz.
//string adi_soyadi;

// Pascal Case: Kelimelerin ilk harfleri büyük, diğer harfleri küçük olarak yazılıyor.
//int DogumYili;

// camel Case: İlk kelimenin ilk harfi küçük, diğer kelimelerin ilk harfleri büyük olacak şekilde isimlendirme yapılır.
//string adiSoyadi;

// Metinsel türde verileri tutmak için string kullanılır
// Bir verinin metinsel olarak kabul edilebilmesi için "" çift tırnak içerisinde tanımlanması gerekiyor.

//string sehir;
//sehir = "İstanbul";
//string dogumTarihi = "1999";

// char türündeki  değişkenlerde sadece  tek karakter tutabiliyoruz. '' tek tırnak içerisinde tanımlanması gerekiyor.

//char cinsiyet = 'K';
//char yas = '9';

// Sayısal Verileri tutmak için kullandığımız değişkenler

//tam sayılar

//byte sayiByte = 120;
//short sayiShort = 15658;
//int sayiInt = 369845662;
//long sayiLong = 45678945612348;

//byte sayiByte2 = 655; değer aralığından farklı bir verimiz varsa bunu ilgili türdeki değişken içinde tutamayız.

// Ondalıklı sayıları tutmak için kullanacağımız değişken tipleri

// Float için girilen değerin sonuna F koymak zorunlu, decimal için sonuna M koymak zorunlu

//float sayiFloat = 15.6F;
//double sayiDouble = 19.5;
//double sayiDouble2 = 20;
//decimal sayiDecimal = 20.86M;

// Mantıksal veriler... True ve False şeklinde veri tutan değişken tipleri

//bool status = true;
//bool status1 = false;

// var ile de değişken tanımlaması yapabiliyoruz. var ile tanımlanan değişkenler verinin tipine göre belirlenir. Veri string türündeyse değişkenin türü de string olur. Veri int türündeyse değişkening türü de int türünde olacaktır.

//int x;
//int y;
//string ulke = "Türkiye";

// var degisken; kabul edilmez

//var city = "İstanbul";
//var sayi2 = 15;
//var aktifMi = true;

//ulke = "Almanya";

//int sayi3 = 5;
//sayi3 = 10;

// Değişkenler tanımlandıktan sonra içlerindeki veriler değiştirilebilir.

// const komutu verisi değiştirilemeyen değişkenler tanımlamak için kullanılır.

//const double pi = 3.14;

//pi = 10;




//                                                    ALIŞTIRMALAR

// öğrencinin boy ve kilosunu tutan değişken hangi türlerde olabilir: float, byte, short

// öğrencinin adı ve soyadı: string

// öğrencinin okul numarası: string, int, short, byte

// şubesi: char, string

// öğrencinin cinsiyeti: char, string, bool

// öğretmenin maaşı: double, float, decimal