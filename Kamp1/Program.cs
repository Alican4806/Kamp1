using System;

namespace Kamp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            double DolarDun = 7.55;
            double DolarBugun = 7.55;

            if (DolarDun > DolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");

            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            bool sistemeGirisYapmisMi = true;
            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
