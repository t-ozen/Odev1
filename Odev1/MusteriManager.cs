using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    internal class MusteriManager
    {
        Musteri musteri = new Musteri();
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad + "Müşteri Eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad + "Müşteri Silindi");
        }

        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad + musteri.Id);
        }

    }
}
