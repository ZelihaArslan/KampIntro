using System;
//Metotlar: tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //urun sayısı kadar döner.
            //Urun : veri tipi
            foreach (Urun urun in urunler)  //urunler diye bir dizim var her bir elemanını tek tek gezsin ekrana tek tek bassın
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("------------------Metotlar--------------");
            //instance -örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Kiraz", "Kırmızı ", 25,78);
            sepetManager.Ekle2("Elma", "Yeşil Elma ", 49,88);
            sepetManager.Ekle2("Erik", "Bol ekşi ", 67,35);

        }
    }
}
//Best Practise: en iyi uygulama teknikleri 