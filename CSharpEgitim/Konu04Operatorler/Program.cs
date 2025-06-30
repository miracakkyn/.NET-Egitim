using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu04Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operatorler
            //aritmetik operatorler
            int sayi1 = 10;
            int sayi2 = 5;
            int toplam = sayi1 + sayi2; // toplama operatoru
            
            int fark = sayi1 - sayi2; // cikarma operatoru
            int carpim = sayi1 * sayi2; // carpma operatoru
            int bolum = sayi1 / sayi2; // bolme operatoru
            int kalan = sayi1 % sayi2; // mod alma operatoru (kalan)

            //iliskisel operatorler
            bool esitMi = sayi1 == sayi2; // esitlik operatoru

            //mantiksal operatorler
            bool veOperatoru = (sayi1 > 0) && (sayi2 > 0); // ve operatoru
            bool veyaOperatoru = (sayi1 > 0) || (sayi2 < 0); // veya operatoru
            bool degilOperatoru = !(sayi1 < sayi2); // degil operatoru
        }
    }
}
