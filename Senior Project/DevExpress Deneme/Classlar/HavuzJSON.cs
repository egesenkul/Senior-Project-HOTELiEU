using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Otel_Uygulamasi.Classlar
{
    class HavuzJSON
    {
        public string HavuzAdi { get; set; }
        public string url { get; set; }
        public string sicaklik { get; set; }
        public DateTime GuncellenmeTarihi { get; set; }
        
        public HavuzJSON(string havuzadi,string URL)
        {
            HavuzAdi = havuzadi;
            url = URL;
        }
    }
}
