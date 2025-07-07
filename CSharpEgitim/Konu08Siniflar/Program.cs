using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Konu08Siniflar
{

    class Ev
    {
        internal int KapiNo;
        internal string SokakAdi;
        internal string Ilce;
        internal string Sehir;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ev sinifindan bir nesne olusturuyoruz
            Ev ev1=new Ev();
            ev1.KapiNo = 12; // KapiNo'yu public olarak tanimladigimiz icin erisebiliyoruz
            ev1.Ilce= "Besiktas"; // Ilce'yi public olarak tanimladigimiz icin erisebiliyoruz
            ev1.SokakAdi = "Barbaros Bulvari";
            ev1.Sehir = "Istanbul";// Ev sinifindan olusturdugumuz ev1 nesnesinin ozelliklerini yazdiriyoruz
            Console.WriteLine("Ev adresi: "+ ev1.Sehir+ "/"+ ev1.Ilce + " "+ ev1.SokakAdi+ " No:"+ ev1.KapiNo );

            Ev ev2=new Ev()
            {
                KapiNo = 34, // KapiNo'yu public olarak tanimladigimiz icin erisebiliyoruz
                Ilce = "Kadikoy", // Ilce'yi public olarak tanimladigimiz icin erisebiliyoruz
                SokakAdi = "Bahariye Caddesi",
                Sehir = "Istanbul" // Ev sinifindan olusturdugumuz ev2 nesnesinin ozelliklerini yazdiriyoruz
            }; // Ev sinifindan ikinci bir nesne olusturuyoruz
            Console.WriteLine("Ev adresi: " + ev2.Sehir + "/" + ev2.Ilce + " " + ev2.SokakAdi + " No:" + ev2.KapiNo);

            Kullanici kullanici = new Kullanici();
            kullanici.EkranaYaziYaz("Mirac");
            Console.WriteLine("Iki sayinin toplami : "+kullanici.Topla(5, 10));
            Console.WriteLine(Kullanici.SinifDegiskeni);
            var islemSonucu2=kullanici.MailGonder("");
            Console.WriteLine(islemSonucu2);
            var islemSonucu=kullanici.MailGonder("abc@gmail.com");
            Console.WriteLine(islemSonucu);
        }
    }

}
