using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu05KosulYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * String admin="admin";
            String password="1234";

            while (true)
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz:");
                String kullaniciAdi = Console.ReadLine();
                Console.WriteLine("Parolanızı Giriniz:");
                String parola = Console.ReadLine();
                if (kullaniciAdi == admin && parola == password)
                {
                    Console.WriteLine("Giriş Başarılı");
                    break;
                }
                else if (kullaniciAdi != admin && parola == password)
                {
                    Console.WriteLine("Hatali Kullanici Adi Lutfen Tekrar Giris Yapin");
                }
                else if (kullaniciAdi == admin && parola != password)
                {
                    Console.WriteLine("Hatali Parola Lutfen Tekrar Giris Yapin");
                }
                else
                {
                    Console.WriteLine("Hatali Kullanici Adi ve Parola Lutfen Tekrar Giris Yapin");
                }
            }*/


            //switch-case yapısı
            //Console.WriteLine("1 ile 12 arasinda bir sayi girin : ");
            int ay = DateTime.Now.Month;//Sistemden tarighi aldi 
            //Convert.ToInt32(Console.ReadLine());
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis Mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Ilkbahar Mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimi");
                    break;

            }
        }
    }
}
