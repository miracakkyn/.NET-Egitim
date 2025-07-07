using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu10OzgenlerProperties
{
    internal class Kisi
    {
        private int yas;
        private string dogumYeri;
        private string meslek;
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Aktif { get; set; }

    }
}
