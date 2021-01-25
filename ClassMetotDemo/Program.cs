using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Bal";
            musteri1.Tc = "12345678";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Zeynep";
            musteri2.Soyadi = "Toprak";
            musteri2.Tc = "9875432";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri1.Adi);
                Console.WriteLine(musteri2.Adi);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);

        }
    }
}
