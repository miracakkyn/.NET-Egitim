using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu14KalitimInheritance
{
    //Kalıtım (Inheritance)
    //bir sınıftan başka bir sınıfa miras bırakılandır

    class AtaSinif
    {
        public AtaSinif()
        {
            Console.WriteLine("Atasınıf Kurucu metodu Çalıştı");
        }
        public void Yaz()
        {
            Console.WriteLine("Atasınıf içindeki yaz metodu çalıştı");

        }
    }
    class OgulSinif : AtaSinif //kalıtım alma işlemi c# da bu şekilde yapılır
    {
        public OgulSinif()
        {
            Console.WriteLine("Oğul sınıfı Kurucu metodu Çalıştı");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OgulSinif ogul = new OgulSinif();
            ogul.Yaz();

            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new Cizici();
            birCizici[1] = new DogruCiz();
            birCizici[2]=new DaireCiz();
            birCizici[3]=new KareCiz();

            foreach(var item in birCizici)
            {
                item.Ciz(); //her bir cizici nesnesinin ciz metodunu çağırır
            }

            Console.ReadLine();
        }
    }

    class Ev
    {
        public string sahip;
        public void EvSahibiniYaz(string sahip)
        {
            Console.WriteLine("Ev sahibi: "+sahip);
        }
    }
    class ApartmanKati : Ev //apartman katı ev sınıfından miras alıyor
    {
        internal string apartmanYoneticisi;
        public void ApartmanYoneticisiniYaz(string yonetici)
        {
            Console.WriteLine("Yonetici : "+yonetici);
        }
    }

    //polimorfizm (çok biçimlilik)
    //bir nesnenin farklı şekillerde davranabilmesidir

    public class Cizici
    {
        public virtual void Ciz() //virtual ile işaretlenen metotlar alt sınıflarda ezilebilir
        {
            //yani bu metod kendi içerisindeki kodları değil de alt sınıflardaki kodları çalıştırır
            Console.WriteLine("Cizici çiziyor");
        }
    }
    public class DogruCiz : Cizici
    {
        public override void Ciz() { 
            Console.WriteLine("Cizici duz çiziyor");
            // normalde cizici ayzmıyor yazması lazım ancak override ettiğimiz için şuan istediğimizi ayzıyor
            //yani override ifadesi ile ciz metodumuzu ezerek farklı çıktı elde etmesini sağladık

        }
    }

    public class DaireCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Cizici daire çiziyor");
            
        }
    }

    public class KareCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Cizici kare çiziyor");


        }
    }
}
