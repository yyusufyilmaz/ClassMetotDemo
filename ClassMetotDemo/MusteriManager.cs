using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakibi
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("MÜŞTERİ BAŞARIYLA EKLENDİ");
            Console.WriteLine("MÜŞTERİ ID: " + musteri.MusteriId + "\nMÜŞTERİ ADI: " + musteri.MusteriAdi + "\nMÜŞTERİ SOYADI: " + musteri.MusteriSoyadi + "\nMÜŞTERİ TC KİMLİK NO: " + musteri.MusteriTc + "\nMÜŞTERİ TELEFON NO: " + musteri.MusteriTelefon);
            Console.WriteLine("--------------------------------");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("MÜŞTERİ BAŞARIYLA LİSTELENDİ");
                Console.WriteLine("MÜŞTERİ ID: " + musteri.MusteriId + "\nMÜŞTERİ ADI: " + musteri.MusteriAdi + "\nMÜŞTERİ SOYADI: " + musteri.MusteriSoyadi + "\nMÜŞTERİ TC KİMLİK NO: " + musteri.MusteriTc + "\nMÜŞTERİ TELEFON NO: " + musteri.MusteriTelefon);
                Console.WriteLine("--------------------------------");
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("MÜŞTERİ BAŞARIYLA SİLİNDİ");
            Console.WriteLine("MÜŞTERİ ID: " + musteri.MusteriId + "\nMÜŞTERİ ADI: " + musteri.MusteriAdi + "\nMÜŞTERİ SOYADI: " + musteri.MusteriSoyadi + "\nMÜŞTERİ TC KİMLİK NO: " + musteri.MusteriTc + "\nMÜŞTERİ TELEFON NO: " + musteri.MusteriTelefon);
            Console.WriteLine("--------------------------------");
        }
    }
}
