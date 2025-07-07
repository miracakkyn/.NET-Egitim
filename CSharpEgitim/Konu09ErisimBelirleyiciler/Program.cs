using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu09ErisimBelirleyiciler
{
    internal class Program
    {
        public class Deneme
        {
            public string UrunAdi="public ogeye heryerden erişilebilir.";  
        }
        protected class Deneme2
        {
            protected string UrunAdi = "protected ogeye sadece tanımlandığı sınıf ve alt sınıflarından erişilebilir.";
        }
        internal class Urun// internal erişim belirleyicisi, sadece tanımlandığı proje içinde erişilebilir.
        {
            internal string UrunAdi = "internal";
        }
        private class Deneme3// private erişim belirleyicisi, sadece tanımlandığı sınıf içinde erişilebilir.
        {
            private string UrunAdi = "private";
        }

        static void Main(string[] args)
        {
            //Erisim belirleyiciler herhangi bir sınıfın, metodun, özelliğin veya alanın erişilebilirliğini kontrol eder.
            //interal, public, protected, private gibi erişim belirleyiciler kullanılır.
            //public: Her yerden erişilebilir.
            //private: Sadece tanımlandığı sınıf içinde erişilebilir.
            //protected: Sadece tanımlandığı sınıf ve alt sınıflarından erişilebilir.
            //internal: Sadece tanımlandığı proje içinde erişilebilir.


            Kullanici kullanici = new Kullanici();
            kullanici.Adi = "Ali"; // public alan
            kullanici.Soyadi = "Veli"; // internal alan, aynı proje içinde erişilebilir
            Console.WriteLine("Kullanici adi: "+kullanici.Adi);
            Console.WriteLine("Kullanici soyadi: " + kullanici.Soyadi);


        }

    }
}
