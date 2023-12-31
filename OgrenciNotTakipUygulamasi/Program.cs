using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotTakipUygulamasi
{
    class MEB
    {
        
    }
    class Ogrenci : MEB
    {
        string ad, soyad, numara;
        double[] notlar;
        public static double NotOrtalamasıHesaplama(double[] notlar)
        {
            if(notlar.Length==0)
                return 0;
            double toplam = 0;
            foreach (double d in notlar)
                toplam += d;
            return toplam/notlar.Length;
        }
        public void OgrenciBilgileri()
        {
            Console.WriteLine("Öğrenci Bilgilerini Girin:");
            Console.Write("Ad: ");
            ad = Console.ReadLine();

            Console.Write("Soyad: ");
            soyad = Console.ReadLine();

            Console.Write("Numara: ");
            numara = Console.ReadLine();
            Console.WriteLine("Kaç not girilecek?");
            int notsayisi=Convert.ToInt32(Console.ReadLine());
            notlar = new double[notsayisi];
            for(int i = 0; i < notsayisi; i++)
            {
                Console.WriteLine((i+1)+".not: ");
                notlar[i] = Convert.ToDouble(Console.ReadLine());
            }

        }
        public void OgrenciBilgileryazdır()
        {
            Console.WriteLine();
            Console.WriteLine("Öğrenci Bilgileri:");
            Console.WriteLine("Ad: "+ad);
            Console.WriteLine("Soyad: "+soyad);
            Console.WriteLine("Numara: " + numara);
            
            for(int i = 0; i < notlar.Length; i++)
            {
                if (notlar.Length == 0)
                    break;
                Console.WriteLine((i+1)+".not: " + notlar[i]);
            }
            Console.WriteLine("Not ortalaması: " + NotOrtalamasıHesaplama(notlar));
        }
    }
    class Personel : Ogrenci
    {
        string ad, soyad,Gorev;
        public void PersonelBilgileri()
        {
            Console.Write("Ad: ");
            ad = Console.ReadLine();

            Console.Write("Soyad: ");
            soyad = Console.ReadLine();
            Console.Write("Görev: ");
            Gorev = Console.ReadLine();
        }
        public void PersonelBilgileriyazdır()
        {
            Console.WriteLine();
            Console.WriteLine("Personel Bilgileri:");
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Gorev: " + Gorev);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel Personel = new Personel();
            Console.WriteLine("Personel Girişi:");
            Personel.PersonelBilgileri();
            Console.WriteLine();
            Console.WriteLine("Öğrenci Girişi:");
            Ogrenci ogrenci= new Ogrenci();
            ogrenci.OgrenciBilgileri();
            Personel.PersonelBilgileriyazdır();
            Console.WriteLine();
            ogrenci.OgrenciBilgileryazdır();
            
        }
    }
}
