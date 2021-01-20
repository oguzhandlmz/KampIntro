using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //İçine ürünle ilgili operasyonlar olur(ekleme, silme, listeleme vs)
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        //void sadece yap demek sonucu başka bi yerde kullanmak istiyorsam return kullanmalıyım yoksa sonucu bi daha kullanamam
    }
}
