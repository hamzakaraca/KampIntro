using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Musteri musteri1= new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Eyüp";
            musteri1.SoyAdi = "Metinoğlu";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.SoyAdi = "Karaca";
            musteri2.Adi = "Savaş";
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriListele(musteri1,musteri2);
            
        }
    }
}
