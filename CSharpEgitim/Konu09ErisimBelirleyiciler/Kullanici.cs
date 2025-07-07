using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu09ErisimBelirleyiciler
{
    public class Kullanici//ana siniflar sadece public veya internal olarak tanımlanabilir.
    {
        public string Adi;
        internal string Soyadi;
        private string Telefon;
        protected string Mail;
        string sifre;//varsayılan olarak private olarak tanımlanır.
    }
    internal class  Adres
    {
        private class Siparis
        {
            public string UrunAdi = "Sipariş sınıfı sadece Adres sınıfı içinde erişilebilir.";
        }
        protected class Musteri
        {
            public string Adi = "Müşteri sınıfı sadece Adres sınıfı ve alt sınıflarından erişilebilir.";
        }
    }

}
