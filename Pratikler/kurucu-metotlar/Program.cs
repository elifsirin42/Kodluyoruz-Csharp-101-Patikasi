using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
             /*** Soz Dizimi
            class SinifAdi
            {
                [Erişim Belirleyici] [Veri Tipi] özellikAdi;
                [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi[Parametre Listesi];
                {
                    //Metot Komutları
                }
            } 
            
            Erişim Belirleyiciler
            *Public
            *Private
            *Internal
            *Protected
            ***/

            Console.WriteLine($" **** Çalışan 1 **** ");
            Calisan calisan1 = new Calisan("ELif", "Şirin", 1453, "IT");
            calisan1.CalisanBilgileri();
            Console.WriteLine("**************");

            Console.WriteLine($" **** Çalışan 2 **** ");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 145453;
            calisan2.Departman = "IK";
            calisan2.CalisanBilgileri();
            Console.WriteLine("**************");

            Console.WriteLine($" **** Çalışan 3 **** ");
            Calisan calisan3 = new Calisan("Zikriye", "Ürkmez");
            calisan3.CalisanBilgileri();
            Console.WriteLine("**************");


        }
    }

    public class Calisan
    {
       
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }

        public Calisan(){}
        public Calisan(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
        public Calisan(string ad, string soyad, int no, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}",Ad);
            Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışan Numarası: {0}",No);
            Console.WriteLine("Çalışan Departmanı: {0}",Departman);
            
        }   
    }
}