using System;
using System.Collections.Generic;

namespace PROJE_1_Console_Telefon_Rehberi_Uygulamasi
{
    public class KullaniciIslemleri{

        //
        public void TelefonNoKaydet( List<Kullanici> kullanicilar,List<string> kullaniciIsimleri, List<string> kullaniciSoyisimleri ){

            Kullanici kullanici = new Kullanici();
            Console.Write("Lütfen isim giriniz.                : ");
            string isim = Console.ReadLine().ToString();
            kullanici.isim = isim;
            Console.Write("Lütfen soyisim giriniz.             : ");
            string soyIsim = Console.ReadLine();
            kullanici.soyIsim = soyIsim ;
            Console.Write("Lütfen telefon numarası giriniz.    : ");
            string telNo = Console.ReadLine();
            kullanici.TelNo = telNo ;

            kullaniciIsimleri.Add(kullanici.isim);
            kullaniciSoyisimleri.Add(kullanici.soyIsim);

            kullanicilar.Add(kullanici);
            Console.WriteLine();
            Console.WriteLine("Yeni kullanici başarıyla eklenmiştir!");
            Console.WriteLine();
            
        }
        public bool TelefonNoSil(List<Kullanici> kullanicilar, List<String> kullaniciIsimleri, List<string> kullaniciSoyisimleri){
            
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını veya soyadını giriniz:  ");
            string kullanici;
            kullanici = Console.ReadLine().ToString();
    
            if (kullaniciIsimleri.Contains(kullanici) || kullaniciSoyisimleri.Contains(kullanici)){

                for (var i = 0; i < kullanicilar.Count; i++)
                {
                    if(kullanici.Equals(kullanicilar[i].isim)) {

                        Console.Write(kullanici + " isimli kişi rehberde silinmek üzere, onaylıyor musunuz? (y/n) ");
                        string cevap = Console.ReadLine();
                        
                        if(cevap.Equals("y") || cevap.Equals("Y")){
                            kullanicilar.Remove(kullanicilar[i]);
                            kullaniciIsimleri.Remove(kullanici);
                            Console.WriteLine("***Kullanıcı Silinmiştir!");
                            return true; 
                        }else{
                            Console.WriteLine("***Kullanıcı Silinememiştir!");
                            return true; 
                        }
                        
                        
                    }
                    else if(kullanici.Equals(kullanicilar[i].soyIsim )){
                        Console.Write(kullanici + " soyisimli kişi rehberde silinmek üzere, onaylıyor musunuz? (y/n) ");
                        string cevap = Console.ReadLine();

                        if(cevap.Equals("y") || cevap.Equals("Y")){
                            kullanicilar.Remove(kullanicilar[i]);
                            kullaniciSoyisimleri.Remove(kullanici);
                            Console.WriteLine("***Kullanıcı Silinmiştir!");
                            return true;
                        }else{
                           Console.WriteLine("***Kullanıcı Silinememiştir!");
                            return true; 
                        }
                    }
                }

                return true;
            }else{
                Console.WriteLine();
                Console.WriteLine("****Bu isme veya soyisme sahip bir kullanıcı bulunanmamıştır!!!");
                Console.WriteLine();

                return false; 
            }

        }
        public bool TelefonNoGüncelle(List<Kullanici> kullanicilar, List<String> kullaniciIsimleri, List<string> kullaniciSoyisimleri){
            
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını veya soyadını giriniz:  ");
            string kullanici;
            kullanici = Console.ReadLine().ToString();
    
            if (kullaniciIsimleri.Contains(kullanici) || kullaniciSoyisimleri.Contains(kullanici)){

                for (var i = 0; i < kullanicilar.Count; i++)
                {
                    if(kullanici.Equals(kullanicilar[i].isim)) {

                        Console.Write(kullanici + " isimli kişi güncellemek üzere, onaylıyor musunuz? (y/n) ");
                        string cevap = Console.ReadLine();
                        
                        if(cevap.Equals("y") || cevap.Equals("Y")){
                            Console.Write("Yeni numarayı giriniz : ");
                            string yeniNo = Console.ReadLine();
                            
                            //int kullaniciIndex = kullanicilar.IndexOf()
                            kullanicilar[i].TelNo = yeniNo;
                           
                            Console.WriteLine("***Kullanıcı Numarası Güncellenmiştir!");
                            return true; 
                        }else{
                            Console.WriteLine("***Kullanıcı Güncellenememiştir!");
                            return true; 
                        }
                        
                        
                    }
                    else if(kullanici.Equals(kullanicilar[i].soyIsim )){
                        Console.Write(kullanici + " soyisimli kişi rehberde güncellenmek üzere, onaylıyor musunuz? (y/n) ");
                        string cevap = Console.ReadLine();

                        if(cevap.Equals("y") || cevap.Equals("Y")){
                            kullanicilar.Remove(kullanicilar[i]);
                            kullaniciSoyisimleri.Remove(kullanici);
                            Console.WriteLine("***Kullanıcı Güncellenmiştir!");
                            return true;
                        }else{
                           Console.WriteLine("***Kullanıcı Güncellenememiştir!");
                            return true; 
                        }
                    }
                }

                return true;
            }else{
                Console.WriteLine();
                Console.WriteLine("****Bu isme veya soyisme sahip bir kullanıcı bulunanmamıştır!!!");
                Console.WriteLine();

                return false; 
            }

        }
        public void RehberiListele(List<Kullanici> kullanicilar){
            
            Console.WriteLine();
            
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("********************************");
            
            for (var i = 0; i < kullanicilar.Count; i++)
            {
                Console.WriteLine("{0}. Kullanıcıya Ait Bilgiler : ",i+1);
                Console.WriteLine("İsim:  " + kullanicilar[i].isim);
                Console.WriteLine("Soyisim: " + kullanicilar[i].soyIsim.ToString());
                Console.WriteLine("Telefon Numarasi: " + kullanicilar[i].TelNo.ToString());
                Console.WriteLine();
                Console.WriteLine("-");
                
            }
            Console.WriteLine();
            
        }
        public void RehberdeAramaYap(List<Kullanici> kullanicilar){
            Console.WriteLine();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("******************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1) ");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2) ");

            string cevap = Console.ReadLine();

            if(cevap.Equals("1")){
                Console.Write("Lütfen bir isim veya soyisim giriniz: ");
                string aranan = Console.ReadLine();

                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("************************************");
                foreach (var a in kullanicilar)
                {
                    if(a.isim.Equals(aranan) || a.soyIsim.Equals(aranan)){
                        Console.WriteLine("İsim: " + a.isim);
                        Console.WriteLine("Soyisim: " + a.soyIsim);
                        Console.WriteLine("Telefon Numarasi: " + a.TelNo);
                    }
                }    
            }else{
                Console.Write("Lütfen bir telefon numarası giriniz: ");
                string aranan = Console.ReadLine();

                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("************************************");
                foreach (var a in kullanicilar)
                {
                    if(a.TelNo.Equals(aranan)){
                        Console.WriteLine("İsim: " + a.isim);
                        Console.WriteLine("Soyisim: " + a.soyIsim);
                        Console.WriteLine("Telefon Numarasi: " + a.TelNo);
                    }
                }    
            }

        }
        public int IslemleriListele(){
            Console.WriteLine();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("**********************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek (A-Z, Z-A seçimli) ");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            Console.Write("İşlem Numarasi: ");
            
            int sonuc = 0;
            try
            {
               sonuc = Int32.Parse(Console.ReadLine());
                
            }
            catch (System.Exception ex)
            {
                 Console.WriteLine("Sistemden çıkış Yapılıyor...");
                 Environment.Exit(0);    
            }
            if(sonuc==1){
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                return 1;
            }
            else if ( sonuc==2){

                 Console.WriteLine("(2) Numarayı Silmek");
                return 2;
            }
            else if ( sonuc==3){
                Console.WriteLine("(3) Varolan Numarayı Güncellemek");
                return 3;
                
            }
            else if ( sonuc==4){
                  Console.WriteLine("(4) Rehberi Listelemek");
                    return 4;
                
            }
            else if ( sonuc==5){
                 Console.WriteLine("(5) Rehberde Arama Yapmak");
                 return 5;
            }else{
                Console.WriteLine("Geçersiz bir işlem girdiniz. Sistemden çıkılıyor.");
                //Environment.Exit(0);
            }
            return 0;
        }

        
    }
}