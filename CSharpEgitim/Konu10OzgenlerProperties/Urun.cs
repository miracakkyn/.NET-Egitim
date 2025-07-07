using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu10OzgenlerProperties
{
    internal class Urun
    {
        public string urunAdi;
        private double urunFiyati;
        public double UrunFiyati
        {
            get { return urunFiyati; }
            set {                 
                if (value <= 0)
                {
                    UrunFiyati = 1;// Negatif veya sıfır değer atanmaması için varsayılan değer olarak 1 atanıyor
                }
                else
                {
                    urunFiyati = value;
                }
            }
        }
    }
}
