using System;

namespace KampIntro
{
    class Program
    {
     

        static void Main(string[] args)
        {
            //type safety=tip güvenliği
            //Do not repeat yourself

             string kategoriEtiketi = "kategoriler"; //değer tutucu, takma isim 
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45; //ondalıklı
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            

            if (sistemeGirisYapmisMi == true)  //tab-tab
            {
                Console.WriteLine("Kullanıcı Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

         
        }
    }
}
