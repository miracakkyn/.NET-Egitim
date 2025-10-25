using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu16InterfacesArayuzler
{
    interface OrnekArayuz
    {
        //interfaceler propertyleri barindirabilirler(imzasini barindirir)
        int MyProperty { get; set; } //arayuz icerisinde proberty tanimlanir ama erisim belirteci verilmez yani public vs olmaz. Cunku zaten interfaceler publicdir

       
    }

    interface Idemo
    {
        void Goster();
        //interfacelerde sadece imzalar bulunur, metodun govdesi olmaz
    }

    interface Inokta
    {
        //ozgenlerin imzalari

        int x { get; set; }
        int y { get; set; }

    }

    //Inokta arayuzunu implement eden sinifimiz
    class Nokta : Inokta
    {
        //alanlar fields
        public int _x { get; set; }
        public int _y { get; set; }
        public int x { 
            get { return _x; } 
            set { _x = value; } 
        }
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
        //burda Inokta arayuzunden gelen ozgenlerin imzalarini implement ettik
    }
    interface icerebilecekleri : Idemo
    {
        //bir interface baska bir interface i kalitabilir

        //Bir interfacein icerebilecegi ozellikler
        //-> public int MyProperty { get; set; } bir interface erisim belirteci almaz daima publictir zaten

        int Sayi { get; set; } //interfaceler erisim belirtecleri olmadan porbertyleri barindirabilirler
        //static int Sayi2 { get; set; } //static propertyleri interfaceler icerisinde kullanamiyoiruz

        void Mesajver(); //interfaceler metod imzalarini barindirabilirler

        //string metin; //interfaceler alan(field) barindiramazlar (icerisinde degisken kullanilamaz)


        //interfaceler classlardaki kuruc metodlari kullanmazlar

        int CikarmaYap(int sayi1,int sayi2);//interfaceler parametreli metod imzasi alabilirler



        /*int CikarmaYap(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }*/ //interfacelerde metod govdesi olamaz , metodlarin yapacagi islem tanimlanamaz
    }
    internal class Program
    {
        //Arayuzler (Interfaces)
        //Arayuzler bir sinifin uygulamak zorunda oldugu metotlari, property'leri, olaylari (events) ve indexleyicileri tanimlamak icin kullanilir.
        //Arayuzler soyut veri tipleridir , classlara benzerler ancak icerisinde sadece imzalar bulunur.
        //kullanim amaci bir class icersiinde kullanacagimiz metodlari degiskenleri bir arayuzde tanimlayip daha sonra bu arayuzu implement eden classlarda bu metodlari kullanmaktir.
        //yani bir arayuz bir protokol gibi dusunulebilir.
        //interfaceten kalitim alan classlar bu interface icerisinde tanimlanan tum metotlari implement etmek zorundadirlar.
        //bu islem implementasyon olarak adlandirilir.

        static void Main(string[] args)
        {
        }
    }
}
