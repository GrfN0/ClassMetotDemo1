using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo

{
    class MusteriManager
    {
        public void Ekle(Musteri musteriler)
        {
            Console.WriteLine("Hoşgeldiniz!" + " " + musteriler.Ad + " " + musteriler.Soyad + " - " + musteriler.Id + " ");
                
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("---------------- Müşteri Listesi -----------------");
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " - " + musteri.Id + " ");
            Console.WriteLine("----------------- Liste Sonu --------------");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Müşteri silindi :" + " " + musteri.Ad + " " + musteri.Soyad + " - " + musteri.Id + " ");
        }
    }

}
