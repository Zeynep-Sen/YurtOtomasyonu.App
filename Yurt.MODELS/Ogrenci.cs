using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yurt.MODELS
{
    public class Ogrenci
    {
        public int ogrenciId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string anneAd { get; set; }
        public string anneSoyad { get; set; }
        public string babaAd { get; set; }
        public string babaSoyad { get; set; }
        public int okulId { get; set; }
        public int iletisimId { get; set; }
        public string tc { get; set; }
    }
}
