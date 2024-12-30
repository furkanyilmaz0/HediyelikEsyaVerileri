using ÜrünLib.Interface;
using ÜrünLib.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ÜrünLib.Class
{


    public class UrunServis : IUrunIslemleri, IDosyaIslemleri
    {

        //Ürünleri tutan liste
        List<Urun> urunler = new List<Urun>();


        //Yeni ürün ekler   
        public void Ekle(Urun urun)
        {
            urunler.Add(urun);
        }
        //Verilen ID'ye sahip ürünü siler
        public void Sil(int id)
        {
            Urun urun = Ara(id);
            urunler.Remove(urun);

        }

        //Mevcut ürünü günceller
        public void Guncelle(int eskiID, int guncellenmisYeniID, string guncellenmisUrunAdi, decimal guncellenmisUrunFiyatı, ParaBirimi guncellenmisParaBirimi, string guncellenmisUrunAciklamasi, string guncellenmisUrunResmi, UrunKategori guncellenmisKategori)
        {
            foreach (Urun urun in Listele())
            {
                if (urun.UrunID == eskiID) // Eski ID'yi bulursa, güncellemeleri yapar
                {
                    urun.UrunID = guncellenmisYeniID;
                    urun.UrunAdi = guncellenmisUrunAdi;
                    urun.UrunFiyati = guncellenmisUrunFiyatı;
                    urun.ParaBirimi = guncellenmisParaBirimi;
                    urun.UrunAciklamasi = guncellenmisUrunAciklamasi;
                    urun.UrunResmi = guncellenmisUrunResmi;
                    urun.UrunKategori = guncellenmisKategori;
                }
            }

        }

        public List<Urun> Listele()
        {
            return urunler;
        }


        public Urun Ara(int id)
        {
            foreach (Urun urun in urunler)
            {
                if (urun.UrunID == id)

                {
                    return urun; //Eğer ürün var ise döndürür
                }

            }
            return null;
        }

        // Ürün listesini belirtilen dosyaya JSON formatında yazar.
        public void DosyayaYaz(string dosyaYolu)
        {
            string json = JsonConvert.SerializeObject(urunler);// Listeyi JSON'a dönüştürür

            using (StreamWriter writer = new StreamWriter(dosyaYolu, false))
            {
                writer.Write(json);// JSON verisini dosyaya yazar
            }
        }
        public void DosyadanOku(string dosyaYolu)
        {
            if (File.Exists(dosyaYolu))

                using (StreamReader reader = new StreamReader(dosyaYolu))
                {
                    string json = reader.ReadToEnd(); // JSON verisini okur

                    urunler = JsonConvert.DeserializeObject<List<Urun>>(json);// Listeyi JSON'dan geri yükler
                }
        }
    }
}

