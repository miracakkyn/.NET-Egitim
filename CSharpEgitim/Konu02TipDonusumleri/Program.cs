using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veri tipi donusumleri(casting)
            
            int sayi1 = 123;
            long sayi2;
            // Implicit conversion (otomatik donusum)
            sayi2 = sayi1; // int to long, bu otomatik olarak yapılır.
            Console.WriteLine(sayi2);



            // Explicit conversion (açık donusum)
            double sayi3 = 123.45;
            // sayi4 = sayi3; // Bu satır hata verecektir çünkü double'dan int'e otomatik dönüşüm yoktur.
            int sayi4= (int)sayi3; // double'dan int'e dönüşüm için açık dönüşüm kullanılır.


            //convert metodunu kullanma
            Console.WriteLine(sayi4);
            string sayi5 = "456";
            int sayi6 = Convert.ToInt32(sayi5); // string'den int'e dönüşüm
            Console.WriteLine(sayi6);

        }
    }
}
