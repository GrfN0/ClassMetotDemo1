using System;

namespace ClassMetotDemo

{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123456789;
            musteri1.Ad = "Samet";
            musteri1.Soyad = "Yılmaz";
            musteri1.HesapNo = 789456123;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 321654987;
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Korkmaz";
            musteri2.HesapNo = 456123789;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id : " + musteri.Id);
                Console.WriteLine("Müşteri Ad : " + musteri.Ad);
                Console.WriteLine("Müşteri Soyad : " + musteri.Soyad);
                Console.WriteLine("Müşteri Hesap No : " + musteri.HesapNo);
            }

            Console.WriteLine("------Metotlar-------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri1);




        }
    }
}
