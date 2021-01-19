using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    //naming convention
    //syntax
    class SepetManager
    {
        public void Ekle(Product urun)

        {
            Console.WriteLine("Tebrikler Sepete eklendi : "+ urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double urunFiyati,int StokAdeti)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : " + urunAdi);
        }
    
    }


}
