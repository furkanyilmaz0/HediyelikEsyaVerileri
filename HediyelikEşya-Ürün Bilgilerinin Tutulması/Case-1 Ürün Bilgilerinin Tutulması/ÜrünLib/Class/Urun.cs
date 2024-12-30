using ÜrünLib.Enum;

namespace ÜrünLib.Class
{
    public class Urun
    {
        //  Ürün propertylerinin tutulması
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public ParaBirimi ParaBirimi { get; set; }

        public string UrunAciklamasi { get; set; }
        public string UrunResmi { get; set; }

        public UrunKategori UrunKategori { get; set; }









        
    }
}
