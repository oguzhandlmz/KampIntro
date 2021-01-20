using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //Bir class ın sonunda olan (Manager, Service, Dal, Controller) gibi ifadeler operasyon tutarlar. 
    class SepetManager
    {
        //naming convention
        //c# da () görürsek orda metot çalışır demektir
        //Python daki def = pubic void
        //Fonksiyon ve metot aynı şeye çıkar
        //() içindeki Urun urun parametredir sepete neyi ekleyeceğimizi seçmiş olduk
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(String urunAdi, string aciklama, int fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
