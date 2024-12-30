using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜrünLib.Class;

namespace ÜrünLib.Interface
{
    public interface IDosyaIslemleri
    {
         void DosyayaYaz(string dosyaYolu); //Dosyadan yazma işlemi
         void DosyadanOku(string dosyaYolu); //Dosyadan okuma işlemi
    }
}
