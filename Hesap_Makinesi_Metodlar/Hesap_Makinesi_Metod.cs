using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi_Metodlar
{
    internal class Hesap_Makinesi_Metod
    {
        static void Main(string[] args)
        {

            double sayi1;
            double sayi2;
            double sonuc;

            string islem;
            bool devamMi = true;

            
            do
            {
                Console.WriteLine("Hesap Makinesi Uygulaması\t");
                Console.WriteLine("Toplama (+)");
                Console.WriteLine("Çıkarma (-)");
                Console.WriteLine("Çarpma (*)");
                Console.WriteLine("Bölme (/)");
                Console.WriteLine("Çıkış yapmak için (X)");

                Console.Write("\nYapmak istediğiniz işlemi seçin: ");
                islem = Console.ReadLine();

                if (islem == "+")
                {
                    Toplama();
                }
                else if (islem == "-")
                {
                    Cikarma();

                }
                else if (islem == "*")
                {
                    Carpma();

                }
                else if (islem == "/")
                {
                    Bolme();
                }
                else if (islem == "x" || islem == "X")
                {
                    devamMi = false;
                    Console.WriteLine("\n**** Hesap makinesi kapatılıyor ****");
                    break;
                    
                }
                else
                {
                    Console.WriteLine("\n**** Geçersiz bir işlem seçtiniz. ****\n");
                    
                }

            } while (devamMi);
            

            Console.ReadLine();
        }

        static void Toplama()
        {
            Console.Write("1. sayıyı giriniz:\t");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayıyı giriniz:\t");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = sayi1 + sayi2;
            Console.WriteLine($"\nToplama işleminin sonucu = {sonuc}\n");
        }
        static void Cikarma()
        {
            Console.Write("1. sayıyı giriniz:\t");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayıyı giriniz:\t");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = sayi1 - sayi2;
            Console.WriteLine($"\nÇıkarma işleminin sonucu = {sonuc}\n");
        }
        static void Carpma()
        {
            Console.Write("1. sayıyı giriniz:\t");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayıyı giriniz:\t");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = sayi1 * sayi2;
            Console.WriteLine($"\nÇarpma işleminin sonucu = {sonuc}\n");
        }
        static void Bolme()
        {
            Console.Write("1. sayıyı giriniz:\t");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayıyı giriniz:\t");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = sayi1 / sayi2;
            Console.Write($"\nBölme işleminin sonucu = {sonuc}\n");
        }
    }
}
