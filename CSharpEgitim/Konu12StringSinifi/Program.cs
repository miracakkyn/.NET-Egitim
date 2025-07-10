using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu12StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken;
            char karakter;
            string metinlericin = "Metin Yazisi";
            Console.WriteLine(metinlericin);
            Ornek1();
            Kiyasla();
        }
        static void Ornek1()
        {
            string birMetin = "Ankara Baskenttir";
            String birSayi= "12345";
            System.String birTarih = "01.01.2023";
            string s = "Baris Manco";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("s["+i+ "] = " + s[i]+s.GetType());
            }
        }


        static void StringMetotlari()
        {
           string metin="Hi My name is Baris Manco";
            var result = metin.Length;
            var result2 = metin.Clone();
            metin = "My name is Ali";

            bool result3 = metin.EndsWith("i");//metin i ile bitiyor mu?
            bool result4 = metin.StartsWith("My name");//metin My name ile başlıyor mu?

            var result5 = metin.IndexOf("name");//metin içinde name kelimesinin ilk geçtiği yerin index numarasını verir.
            var result6 = metin.LastIndexOf("name");//metin içinde name kelimesinin son geçtiği yerin index numarasını verir.
            var result7 = metin.Insert(0, "Hello ");//metin içine Hello kelimesini 0. indexten başlayarak ekler.
            var result9 = metin.Substring(3, 4); //metin içinde 3. indexten başlayarak 4 karakter alır.
            var result10 = metin.ToLower(); //metni küçük harfe çevirir.
            var result11 = metin.ToUpper(); //metni büyük harfe çevirir.
            var result12=metin.Replace("name", "isim"); //metin içinde name kelimesini isim ile değiştirir.



        }
        static void Kiyasla()
        {
            string metin1 = "Baris Manco";
            string metin2 = "Baris Manco";
            Console.WriteLine(metin2==metin1);
            Console.WriteLine(metin2!=metin1);
        }

    }

}
