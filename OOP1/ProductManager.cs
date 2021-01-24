using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        //void seklinde belirtilen metotlar 
        public void Add(Product product) //product türünde product1 in içindekileri eklemiş olacak
        {
            Console.WriteLine(product.ProductName + " EKLENDİ");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "GÜNCELLENDİ");
        }









        /*
        //void farkını anlamak için
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2; //int tipinde geri dönüş yapar sonucu bize. 
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2); //return olsaydı sonucu tekrar kullanabilirdik. Burada sadece 1 defa yazdırmış olduk
        }




         public void BiseyYap(int sayi)
          {
              sayi = 99;
          } */
    }
}
