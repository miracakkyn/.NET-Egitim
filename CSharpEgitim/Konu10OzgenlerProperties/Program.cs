using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu10OzgenlerProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler ana bellekte kendisine yer ayiran veri yapisi
            //Ozgenler(propertie) degisken ile metod arasinda bir eyrdedir hem degisken hemde metod gibi davranir

            Skorlar skorlar = new Skorlar();
            skorlar.Skor = 10; // Skor = 10; gibi
            Console.WriteLine(skorlar.Skor);


            Kisi kisi = new Kisi();
            kisi.Ad = "Ahmet";
            kisi.Soyad = "Yılmaz";
            kisi.Id = 1;
            kisi.Aktif = true;
            //kisi.DogumYeri = "İstanbul"; // private property, dışarıdan erişilemez
            if (kisi.Aktif)
            {
                               Console.WriteLine($"{kisi.Ad} {kisi.Soyad} aktif bir kullanıcıdır.");
            }
            else
            {
                Console.WriteLine($"{kisi.Ad} {kisi.Soyad} pasif bir kullanıcıdır.");
            }

    }
    class Skorlar
    {
        private int skor;
        public int Skor//Skor adinda property(ozgen) tanimladik
        {
            get//get blogu, degiskeni dondurur
            {
                return skor;
            }
            set//set blogu, degiskene deger atar
            {
                skor = value;// Skor = 10; gibi , value, set blogunda atanan degeri tutar C# diline ozel bir yapidir value kelimesi
            }
        }
    }
}
