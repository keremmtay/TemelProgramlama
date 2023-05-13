#region Tür Dönüşümleri

// Bilinçli (Explicit) ve Bilinçsiz (Implicit) Tür Dönüşümleri

#region Bilinçsiz Tür Dönüşümleri (Implicit)

//Bilinçsiz tür dönüşümü yapmak için, alt seviyedeki bir türü kendisinden daha üst seviyedeki bit türe dönüştürürken bu yöntem  kullanılabilir.

//byte b = 15;
//short s = 10;
//byte b1;
//short s1;
//int sayiInt;

//s1 = b;

//int sonuc = s1 * 5;

//sayiInt = s;

////b1 = s;

//Console.WriteLine(sayiInt);
//Console.WriteLine(sonuc);



#endregion

#region Bilinçli Tür Dönüşümleri (Explicit)

#region Parse metodu ile tür dönüşümü
//String ifadeleri diğer türlere çevirmek için kullanıyoruz.

//string x = "5";
//int sayi = int.Parse(x);
//int sonuc = sayi * 3;

//Console.WriteLine(sonuc);

//string medeniHal = "false";

//bool medeniHalbool = bool.Parse(medeniHal);

//Console.WriteLine(medeniHalbool);

//string cinsiyet = "k";
//char cinsiyetChar = char.Parse(cinsiyet);

//Console.WriteLine(cinsiyetChar);



#endregion

#region TryParse metodu ile tür dönüşümü

//string sayi = "15";

//int sayiInt;

//bool sonuc;

//sonuc = int.TryParse(sayi, out sayiInt);

//if (sonuc)
//{
//    Console.WriteLine(sayiInt);
//    Console.WriteLine(sonuc);
//    Console.WriteLine(sayiInt * 2);
//}
//else
//{
//    Console.WriteLine(sonuc);
//    Console.WriteLine("Çevirmek istediğiniz verinin sayısal türde bir karşılığı yoktur.");
//}

#endregion

#region Convert Sınıfı ile tür dönüşümü

//string a = "15";
//byte sayiByte = Convert.ToByte(a);
//short sayiShort = Convert.ToInt16(a);
//int sayiInt = Convert.ToInt32(a);
//long sayiLong = Convert.ToInt64(a);

//string pi = "3,14";
//double sayiDouble = Convert.ToDouble(pi);

//Console.WriteLine(sayiDouble * 2);


#endregion

#region Cast Yöntemi ile tür dönüşümü

//byte bSayi = 15;
//int sayiInt;

//sayiInt = (int)bSayi;

//short sayiShort = 270;

//byte sayiByte = (byte)sayiShort;

//Console.WriteLine(sayiByte);

#endregion

#region Diğer türlerin string türe dönüştürülmesi

//değişkenAdı.ToString(): Farklı türleri metinsel ifadelere çevirmek için kullanılır.

//string sayiString;
//int sayi = 158;

////sayiString = sayi.ToString();

//Console.WriteLine(sayi.ToString() + 2);




#region object 

//object o1 = "Ali";
//object o2 = 56;
//int a = 5;
//object o3 = true;

//bool b = (bool)o3;

//string isim = (string)o1;

//Console.WriteLine((int)o2 * 2);

#endregion

#endregion

#endregion

#endregion

Console.ReadLine();