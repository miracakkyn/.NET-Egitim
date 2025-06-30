using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte plaka_kodu = 255; // Plaka kodu 255 olarak tanımlandı. byte veri tipi 0-255 aralığında değer alabilir.
            const int plaka_kodu_istanbul = 34;// İstanbul'un plaka kodu 34'tür const ise bir sabit tanımlamadır ve değeri değiştirilemez.
            Console.WriteLine("istanbulun plaka kodu : " + plaka_kodu_istanbul + "byte plaka kodu "+plaka_kodu);
            short kisa_sayi = 32767; // short veri tipi -32768 ile 32767 arasında değer alabilir.
            sbyte kisa_sayi2 = -128; // sbyte veri tipi -128 ile 127 arasında değer alabilir.
            ushort kisa_sayi3 = 65535; // ushort veri tipi 0 ile 65535 arasında değer alabilir.

            // Tam sayılar için veri tipleri
            long uzun_sayi = 9223372036854775807; // long veri tipi -9223372036854775808 ile 9223372036854775807 arasında değer alabilir.
            ulong uzun_sayi2 = 18446744073709551615; // ulong veri tipi 0 ile 18446744073709551615 arasında değer alabilir.
            uint tamsayi = 4294967295; // uint veri tipi 0 ile 4294967295 arasında değer alabilir.

            // Ondalık sayılar için veri tipleri
            float ondalikli_sayi = 3.40282347E+38F; // float veri tipi yaklaşık 1.5 x 10^-45 ile 3.4 x 10^38 arasında değer alabilir.
            double ondalikli_sayi2 = 1.7976931348623157E+308; // double veri tipi yaklaşık 5.0 x 10^-324 ile 1.7 x 10^308 arasında değer alabilir.

            // Decimal veri tipi, finansal ve hassas hesaplamalar için kullanılır.
            decimal ondalikli_sayi3 = 79228162514264337593543950335M; // decimal veri tipi yaklaşık 1.0 x 10^-28 ile 7.9 x 10^28 arasında değer alabilir.hassas veri işlemler için kullanılır.

            //char veri tipi, tek bir karakteri temsil eder.
            char karakter = 'A'; // char veri tipi tek bir karakteri temsil eder. Unicode karakter setini kullanır.

            //string veri tipi, karakter dizilerini temsil eder.
            string metin = "Merhaba, C# programlama dili!"; // string veri tipi karakter dizilerini temsil eder. Unicode karakter setini kullanır.
            string isim = "Mirac";
            string soyisim = "Akkoyun";
            string deneme = "Ahmet muhsin \n \t biraz uzaklastik";// \n yeni satir \t tab karakteri ekler
            Console.WriteLine(deneme);

            //boolean veri tipi, doğru veya yanlış değerlerini temsil eder.
            bool dogruMu = true;
            bool yanlisMi = false;
            Console.WriteLine(dogruMu + " " + yanlisMi);
        }
    }
}
