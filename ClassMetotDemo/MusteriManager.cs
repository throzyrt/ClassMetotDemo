using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi!");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri Kaydı Silindi!");
        }
        public void Lıstele(Musteri musteri)
        {
            Console.WriteLine("Musteri Id : " + musteri.Id);
            Console.WriteLine("Musteri Ad : " + musteri.Ad);
            Console.WriteLine("Musteri Soyad : " + musteri.Soyad);
            Console.WriteLine("Musteri Sehir : " + musteri.Sehir);

        }
    }
}
