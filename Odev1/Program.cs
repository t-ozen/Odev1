using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Taha";
            musteri.Soyad = "Özen";

            Musteri musteri1 = new Musteri();
            musteri1.Id = 2;
            musteri1.Ad = "İpek";
            musteri1.Soyad = "Özen";

            Musteri[] musteriler = new Musteri[] { musteri, musteri1 };

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " ");
                Console.WriteLine(musteri.Ad + musteri.Soyad);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Sil(musteri1);

        }
    }
}