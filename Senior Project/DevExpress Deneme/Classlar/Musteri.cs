using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Otel_Uygulamasi.Classlar
{
    class Musteri
    {
        public string Isim { get; set; }
        public string soyIsim { get; set; }
        public string email { get; set; }
        public string tablo { get; set; }

        public Musteri(string isim ,string soyisim, string Email,string Tablo)
        {
            Isim = isim;
            soyIsim = soyisim;
            email = Email;
            tablo = Tablo;
        }
    }
}
