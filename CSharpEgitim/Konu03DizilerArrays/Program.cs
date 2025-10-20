using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu03DizilerArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayi;// Dizi tanımlama
            //sayi[1] = 12; // Diziye değer atama (Bu satır hata verecektir çünkü dizi henüz oluşturulmadı)
            int[] ogrenciler = new int[7];// Dizi oluşturma ve boyutunu belirleme (7 elemanlı bir dizi)
            ogrenciler[0] = 101; // Diziye değer atama
            ogrenciler[1] = 102; // Diziye değer atama  
            ogrenciler[2]  = 103; // Diziye değer atama
            ogrenciler[3] = 104; // Diziye değer atama
            ogrenciler[4] = 105; // Diziye değer atama
            ogrenciler[5] = 106; // Diziye değer atama
            ogrenciler[6] = 107; // Diziye değer atama
            //ogrenciler[7] = 108; // Bu satır hata verecektir çünkü dizi boyutu 7 olarak tanımlandı, 8. eleman eklenemez.
            Console.WriteLine(ogrenciler[0]);

            // Diziler (Arrays)
            //Diziler ayni turdeki birden fazla veriyi tek bir isim altinda tutmamizi saglar

            string[] siviller = new string[5]; // 5 elemanlı bir string dizisi oluşturma
            siviller[0] = "Ahmet"; // Diziye değer atama
            siviller[1] = "Mehmet"; // Diziye değer atama
            siviller[2] = "Ayşe"; // Diziye değer atama
            Console.WriteLine(siviller[2]);
            string[] sehirler = new string[3]; // 3 elemanlı bir string dizisi oluşturma
            sehirler[0]= "Ankara"; // Diziye değer atama

            int[] ogrenciler2 = {1000,200,300,400,500,600,700}; // Dizi tanımlama ve değer atama


            //cok boyutlu diziler
            int[,] matris = new int[2, 2];
            matris[0,1] = 1; // 1. satır 2. sütun
            matris[1,0] = 2; // 2. satır 1. sütun
            matris[1,1] = 3; // 2. satır 2. sütun
            matris[0,0] = 4; // 1. satır 1. sütun
            for(int i=0;i<2;i++) // Satır döngüsü
            {
                for(int j = 0; j < 2; j++) // Sütun döngüsü
                {
                    Console.Write(matris[i,j] + " "); // Matris elemanlarını yazdırma
                }
                Console.WriteLine(); // Yeni satıra geçme
            }
        }
    }
}
