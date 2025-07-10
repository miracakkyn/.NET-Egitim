using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu11StructYapilar
{
    struct yapi
    {
        //farkli veri tipelrinden olusan bir yapidir
        // yapilar, classlara benzer ancak farkli ozellikleri vardir
        //siniflar ve stringler bellekte heapte tutuluyor
        //yapilar ve stering disi veri tipleri ise stackte tutuluyor
        //c# da degisten turleri deger ve referans turleri olarak ikiye ayrilir
        //referanslar heapte tutulur, degerler ise stackte tutulur
        //stackte ttulan ogeler isi bittiginde otomatik olarak silinir , heapte tutulan ogeler ise garbage collector tarafindan silinir yada biz silene kadar kalir

        //public int sayi = 12; ir
        //structlarda degiskenlere baslangic degeri atanamiyor
        public int sayi;
        public string metin;//tanimlama yapilir ama baslangic degeri atanamaz



        public void Metot()
        {
            Console.WriteLine("Yapi icindeki metot calisti");
        }




    }
    
    internal class Program
    {
        struct Kimlik
        {
            public string Ad;
            public string Soyad;
            public int Yas;
            public string DogumYeri;
            public struct Adres
            {
                public int ID { get; set; }
                public int KapiNo { get; set; }
                public string Sehir { get; set; }
                public string Ilce { get; set; }
                public string EvAdresi { get; set; }
            }


        }
        static void Main(string[] args)
        {
            //struct ile yapi kurmak
            Kimlik kimlik = new Kimlik();
            kimlik.Ad = "Ahmet";
            kimlik.Soyad = "Yılmaz";
            kimlik.Yas = 30;
            kimlik.DogumYeri = "İstanbul";
            Kimlik.Adres adres = new Kimlik.Adres();
            adres.ID = 1;
            adres.KapiNo = 10;
            adres.Sehir = "İstanbul";
            adres.Ilce = "Kadıköy";
            adres.EvAdresi = "Cadde No: 10";

            Console.WriteLine($"Ad: {kimlik.Ad}, Soyad: {kimlik.Soyad}, Yaş: {kimlik.Yas}, Doğum Yeri: {kimlik.DogumYeri}");
            Console.WriteLine($"Adres: {adres.EvAdresi}, Kapı No: {adres.KapiNo}, İlçe: {adres.Ilce}, Şehir: {adres.Sehir}");
        }
    }
}
