using System;

namespace sinif_kavrami
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

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Elif";
            calisan1.Soyad = "Şirin";
            calisan1.No = 1453;
            calisan1.Departman = "IT";
            calisan1.CalisanBilgileri();
            Console.WriteLine("**************");
            
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 145453;
            calisan2.Departman = "IK";
            calisan2.CalisanBilgileri();
            Console.WriteLine("**************");
            
            

        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}",Ad);
            Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışan Numarası: {0}",No);
            Console.WriteLine("Çalışan Departmanı: {0}",Departman);
            
        }
        
        
        
        
        
        
        
        
    }
}
