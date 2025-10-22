using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu15KapsullemeEncapsulation
{
    class Bolum
    {
        private string BolumAdi; //disardan erisilemez

        //accessor metodlar (get set) islemlerini yapoar

        public string GetBolumAdi()
        {
            return BolumAdi;
        }

        //Mutatar metod (set) islemlerini yapar
        public void SetBolumAdi(string bolumAdi)
        {
            if (bolumAdi == "Programlama")
            {
                Console.WriteLine("Okulumuzda {0} bolumu bulunmamaktadir ", bolumAdi);
            }
            else
            {
                BolumAdi = bolumAdi;
            }
        }

    }

    class Fakulte
    {

        private string FakulteAdi;
        public string fakulteAdi
        {
            get { return FakulteAdi; }
            set
            {
                if (value == "Programlama")
                {
                    Console.WriteLine("Bu {0} bolumu mevcut degildir", value);
                }
                else
                {
                    FakulteAdi = value;
                }
            }


        }
    }




    //Yalniz okunur property (read only)
    class Universite {
        private string UniversiteAdi;

        //yapilandirici metod
        public Universite(string str)
        {
            UniversiteAdi = str;
        }
        public string universiteAdi
        {
            get { return UniversiteAdi; }
        }

    
    }

    //Sadece yazilir property (write only)
    class YuksekOkul
    {
        private string YuksekOkulAdi;
        public string yuksekOkulAdi
        {
            set
            {
                YuksekOkulAdi = value;
                Console.WriteLine("Sectiginiz Bolum Adi : "+YuksekOkulAdi);
            }
        }
    }
        internal class Program
        {
            //kapsulleme (encapsulation) 
            //sinif icerisindeki verilerin ve metodlarin erisebilirliginin sinif icinde ortulmes
            //korunmak amaciyla kullanilir get set metodlariyla erisim saglanir
            //amac:verilerin dogru ve guvenli sekilde kullanilmasini saglamak

            static void Main(string[] args)
            {
            /*Metod kullanarak kapsulleme islem
             * Bolum bolum=new Bolum();
            Console.WriteLine("Lutfen bolum adini giriniz");
            var bolumAdi = Console.ReadLine();
            bolum.SetBolumAdi(bolumAdi);
            Console.WriteLine("Bolum adi {0} !",bolum.GetBolumAdi());
            */



            // Property kullanarak kapsulleme islemi
            /*Fakulte fakulte = new Fakulte();
            Console.WriteLine("Lutfen bolum adini giriniz");

            fakulte.fakulteAdi = Console.ReadLine();
            Console.WriteLine("Sectiginiz bolum adi: " +fakulte.fakulteAdi);
            


            //Yalniz okunur property ornegi
            Console.WriteLine("Universite adi giriniz : ");
            string uniAdi=Console.ReadLine();
            Universite uni=new Universite(uniAdi);//yapilandirici metot ile deger atandi
            Console.WriteLine("Universite adi: "+uni.universiteAdi);*/




            //Yalniz yazilir property ornegi
            YuksekOkul yuksekOkul=new YuksekOkul();
            yuksekOkul.yuksekOkulAdi = "Bilgisayar Muhendisligi";









        }
    }
}

