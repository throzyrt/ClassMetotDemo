using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri
            {
                Id = 1,
                Ad = "Tahir",
                Soyad = "Özyurt",
                Sehir = "İstanbul"
            };
            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.Lıstele(musteri);
            musteriManager.Ekle(musteri);
            musteriManager.Sil(musteri);
            
            Console.ReadLine();
        }
    }

}
