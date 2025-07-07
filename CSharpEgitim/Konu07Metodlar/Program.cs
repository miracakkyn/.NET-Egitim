using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu07Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Topla(12, 24);

            int sonuc=ToplaVeDondur(24,113);
            Console.WriteLine(sonuc);

            string kelime = "Merhaba Dunya";
            Console.WriteLine("Kucuk harf sayisi: " + KucukHarfSay(kelime));
        }

        //static yaznanizibn sebebi main metodumuzun static olmasi
        //void ifadesi ise toplama metodunun sadece 1 şey yapacagini ve geriye bir deger dondurmeyecegini belirtir

        static void Topla(int a, int b)
        {
            int toplam = a + b;
            Console.WriteLine(toplam);
        }

        //void ifadesi yerine int yazarsak, bu metodun bir deger dondurmesi gerekecegini belirtmis oluruz
        static int ToplaVeDondur(int a, int b)
        {
            int toplam = a + b;
            return toplam; // return ifadesi ile degeri donduruyoruz

        }
        static int KucukHarfSay(string kelime)//kucuk harfleri sayan metod
        {
            int kucukHarfSayisi=0;
            foreach(char harf in kelime)
            {
                if(char.IsLower(harf))
                {
                    kucukHarfSayisi++;
                }

            }
            return kucukHarfSayisi; // return ifadesi ile degeri donduruyoruz
        }
        

        static bool MailGonder(string MailAdresi)
        {
            
            if (!string.IsNullOrWhiteSpace(MailAdresi))
            {
                return true;
            }
            else
            {
                return false;
            }

    }
}
