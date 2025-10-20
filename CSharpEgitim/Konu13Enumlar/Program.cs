using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu13Enumlar
{
    internal class Program //nesneleri numarandırmak için kullanılır enumlar
    {

        enum Aylar : byte // artık byte yazdığımız için ayların veri tipi byte oluyor
        {
            Ocak , Subat , Mart , Nisan , Mayıs , Haziran , Temmuz , Ağustos , Eylül , Ekim , Kasım , Aralık

        }
        enum CalisilanGunler
        {
            Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
        }
        enum SiparisDurumlari
        {
            Hazırlanıyor, Yolda, TeslimEdildi, İptalEdildi //türkçe yapı kullanılır ancak bosluk bırakılmaz
        }
        enum Meyveler : int
        {
            Elma = 5, Armut = 10, Muz = 15, Çilek = 20
        }
        static void Main(string[] args)
        {
            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Çilek;
            byte c = (byte)Meyveler.Elma;
            Console.WriteLine("Armut = {0} , Elma ={1} , Çilek={2}",a,b,c);
        }
    }
}
