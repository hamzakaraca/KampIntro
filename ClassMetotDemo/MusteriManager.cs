using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine( "Müşteri eklendi: " + musteri.Adi + musteri.SoyAdi);
        }
        public void MusteriListele(Musteri musteri,Musteri musteri1)
        {
            Musteri[] musteriler = new Musteri[] {musteri,musteri1 };
            foreach (Musteri a in musteriler)
            {
                Console.WriteLine(a.Id);
                Console.WriteLine(a.Adi);
                Console.WriteLine(a.SoyAdi);

            }
            
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.Adi + musteri.SoyAdi);
        }
    }
}
