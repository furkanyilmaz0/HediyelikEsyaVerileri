using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜrünLib.Class;
using ÜrünLib.Enum;

namespace ÜrünLib.Interface
{
    public interface IUrunIslemleri
    {
         void Ekle(Urun urun); //Ürün ekleme işlemi
        void Sil(int id); //ID'ye göre ürün silme işlemi
        void Guncelle(int eskiID, int guncellenmisYeniID , string guncellenmisUrunAdi, decimal guncellenmisUrunFiyatı, ParaBirimi guncellenmisParaBirimi, string guncellenmisUrunAciklamasi, string guncellenmisUrunResmi, UrunKategori guncellenmisKategori); //ID'ye göre ürün verilerini güncelleme işlemi
        List<Urun> Listele(); //Tüm ürünleri döndürme işlemi
        Urun Ara(int id); //ID'ye göre ürün arama işlemi

    }
}
