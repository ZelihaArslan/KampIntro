using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitInStock = 4,
                ProductName = "Kalem",
                UnitPrice = 35
            };
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //kamera

          
            
            












            
            /* productManager.Topla2(3, 6); //returne ihtiyacım var çünkü sonucu tekrar kullanmam gerekebilir.

            int toplamaSonucu = productManager.Topla(3, 6); //burada topla fonksiyonunu kullanarak tekrar sonucu kullanabildik
            Console.WriteLine(toplamaSonucu*2);


           // int sayi = 100;
            //productManager.BiseyYap(sayi); //sayının sadece değerini yolluyoruz. sayı tanımıyla baglantımız bitiyor.
           // Console.WriteLine(sayi); //100

            //int,doble,bool... değer tiplerde atamalar tamamen değeri üzerinde olur.
            //diziler,class,abstract class, interface... referans tiplerde atamalar referansın adresiyle yapılır.

        */
         }
            
    } 
}
