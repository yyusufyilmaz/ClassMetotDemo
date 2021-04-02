using System;

namespace MusteriTakibi
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1111111110;
            musteri1.MusteriAdi = "Yusuf";
            musteri1.MusteriSoyadi = "Yılmaz";
            musteri1.MusteriTc = "26545874125";
            musteri1.MusteriTelefon = "0 552 007 1559";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 1111111111;
            musteri2.MusteriAdi = "İlyas";
            musteri2.MusteriSoyadi = "Çetin";
            musteri2.MusteriTc = "15658545226";
            musteri2.MusteriTelefon = "0 545 408 2665";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 1111111112;
            musteri3.MusteriAdi = "Mehmet";
            musteri3.MusteriSoyadi = "Karabacak";
            musteri3.MusteriTc = "27896542158";
            musteri3.MusteriTelefon = "0 539 892 9907";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Listele(musteriler);
            musteriManager.Sil(musteri1);

        }
    }
}
