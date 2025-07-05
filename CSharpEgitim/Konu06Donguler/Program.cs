using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu06Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("For DOngusu");
            int toplam = 0;
            for(int i = 1; i <= 10; i++)
            {
                toplam += i;
                Console.WriteLine("Toplam: "+toplam);
            }*/



            //while dongusu 
            /*while (true)
            {
                Console.WriteLine("Cikis yapmak icin 'q' ya basin");
                Console.WriteLine("Deger giriniz");
                string deger = Console.ReadLine();
                if(deger== "q")
                {
                    Console.WriteLine("Cikis yapiliyor...");
                    break; // donguden cik
                }
                else
                {
                    try
                    {
                        int sayi = Convert.ToInt32(deger);
                        Console.WriteLine("Girdiginiz deger: " + sayi);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                    }
                }
            }*/



            /*Console.WriteLine("Do while dongusu");
            int toplam = 3;
            do
            {
                Console.WriteLine("Do while sayi {0}",toplam);
                toplam += 1;
            } while (toplam < 10);
        
            */


            //FOr each dongusu
            /*int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("For each dongusu");
            foreach (int sayi in sayilar) {
                Console.WriteLine("Sayi: "+sayi);
            }*/


        }
    }
}
