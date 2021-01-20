using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //Id bir datayı diğerlerşnden ayırt etmek için kullanılan eşsiz değeri anlatır(Yani tc no,soyad gibi).
        //Property - özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

        

    }
}

