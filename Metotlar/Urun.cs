using System;
using System.Collections.Generic;
using System.Text;

//bir alışveriş sayfasındaki sepet kısmındaki işlemler ürün ile ilgili işlrmlrt için class açarız
namespace Metotlar  
{
    class Urun //birden fazla eleman tutabilirsin
    {
        //Property: Özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }


        public int StokAdedi { get; set; }

    }
}
