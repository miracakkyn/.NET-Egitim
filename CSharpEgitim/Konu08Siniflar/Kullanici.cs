
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu08Siniflar
{
    internal class Kullanici
    {
        string KurucuMetod;
        public Kullanici()// Kurucu(Constructor) metod, sinifin bir nesnesi olusturuldugunda calisir
        {
            KurucuMetod = "Kullanici sinifindan bir nesne olusturuldu.";
            Console.WriteLine(KurucuMetod);// Kurucu metodun calistigini gosteriyoruz

        }
        public int Id;
        public string KullaiciAdi;
        public string Sifre;
        public bool AktifMi;
        public void EkranaYaziYaz(string yazi)
        {
            // Bu metod, parametre olarak alinan yaziyi ekrana yazdirir
            Console.WriteLine(yazi);
        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static string SinifDegiskeni = "Siniflarda metot ve degisken de kullanabiliriz";
        // static degisken, sinif seviyesinde tanimlanir ve tum nesneler icin ortaktir
        public bool MailGonder(string mail)
        {
            if(!string.IsNullOrWhiteSpace(mail))
            {
                Console.WriteLine("Mail gonderildi: " + mail);
                return true; // Mail gonderme islemi basarili
            }
            else
            {
                Console.WriteLine("Mail gonderilemedi, mail adresi bos.");
                return false; // Mail gonderme islemi basarisiz
            }
        }

    }
}
