using System;
using System.Collections.Generic;

namespace PROJE_1_Console_Telefon_Rehberi_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            // 5 kullanıcı listeye eklenmiştir.
            List<Kullanici> kullanicilar = new List<Kullanici>();
            kullanicilar.Add(new Kullanici("Elif","Şirin","+90 415 414 4522"));
            kullanicilar.Add(new Kullanici("Burak","Yılmaz","+90 102 451 4114"));
            kullanicilar.Add(new Kullanici("Arda","Türkmen","+46 221 254 5452 ")); 
            kullanicilar.Add(new Kullanici("Merve","Kalim","+14 258 532 5246")); 
            kullanicilar.Add(new Kullanici("Albert","Black","+63 412 212 5225"));
        
            // Eklenen kullanıcıların isimleri fonksiyonlarda kullanılmak üzere ayrı bir listede tutulmuştur.
            List<string> kullaniciIsimler = new List<string>();
            foreach (var k in kullanicilar)
            {
                kullaniciIsimler.Add(k.isim);
            }

            // Eklenen kullanıcıların soyisimleri fonksiyonlarda kullanılmak üzere ayrı bir listede tutulmuştur.
            List<string> kullaniciSoyisimler = new List<string>();
            foreach (var k in kullanicilar)
            {
                kullaniciSoyisimler.Add(k.soyIsim);
            }

            // Kullanıcının işlem yapabilmesi için KullaniciIslemleri tipinde bir nesne oluşturulmuştur.
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();

            int islem = kullaniciIslemleri.IslemleriListele();

            // Kullanıcının sistemden çıkmadan devamlı olarak işlem girebilmesi sağlanmıştır.
            // İşlem numaralarına göre gerekli işlemin başlatılması sağlanmıştır.
            while(islem != 0){
                
                if(islem == 1){
                    kullaniciIslemleri.TelefonNoKaydet(kullanicilar,kullaniciIsimler,kullaniciSoyisimler);
                    //kullaniciIslemleri.RehberiListele(kullanicilar);
                }

                else if ( islem == 2) {
                    /*bool flag =true;
                    while(flag){
                        flag = kullaniciIslemleri.TelefonNoSil(kullanicilar,kullaniciIsimler,kullaniciSoyisimler);
                    }*/
                    bool bool_islem = kullaniciIslemleri.TelefonNoSil(kullanicilar,kullaniciIsimler,kullaniciSoyisimler); 
                    if(bool_islem){
                        Console.WriteLine("Kullanıcı başarıyla silinmiştir!");
                    }else{
                        Console.WriteLine($"Aradığınız kriterlere uygun veri rehberde bulunamadi. Lütfen bir seçim yapınız.");
                        Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
                        Console.WriteLine("*Yeniden denemek için : (2) ");
                        string sonuc = Console.ReadLine();
                        if (sonuc.Equals("1")) {
                            Console.WriteLine("İşlem Sonlandırılmıştır..");
                        }else{
                            bool_islem = kullaniciIslemleri.TelefonNoSil(kullanicilar,kullaniciIsimler,kullaniciSoyisimler); 
                        } 
                    };
                }

                else if ( islem == 3) {
                    /*bool flag =true;
                    while(flag){
                        flag = kullaniciIslemleri.TelefonNoSil(kullanicilar,kullaniciIsimler,kullaniciSoyisimler);
                    }*/
                    bool bool_islem = kullaniciIslemleri.TelefonNoGüncelle(kullanicilar,kullaniciIsimler,kullaniciSoyisimler); 
                    if(bool_islem){
                        Console.WriteLine("Kullanıcı başarıyla güncellenmiştir!");
                    }else{
                        Console.WriteLine($"Aradığınız kriterlere uygun veri rehberde bulunamadi. Lütfen bir seçim yapınız.");
                        Console.WriteLine("*Güncellemeyi sonlandırmak için : (1)");
                        Console.WriteLine("*Yeniden denemek için : (2) ");
                        string sonuc = Console.ReadLine();
                        if (sonuc.Equals("1")) {
                            Console.WriteLine("İşlem Sonlandırılmıştır..");
                        }else{
                            bool_islem = kullaniciIslemleri.TelefonNoGüncelle(kullanicilar,kullaniciIsimler,kullaniciSoyisimler); 
                        } 
                    };

                    // kullanicilar listesinin kullanıcının isteği şekilde sıralanarak konsola yazdırılarak kullanıcıya gösterilmesi sağlanmıştır.
                } else if(islem == 4 ){
                    Console.WriteLine($"Rehberi A-Z seçimli olarak listelemek için: (1) ");
                    Console.WriteLine($"Rehberi Z-A seçimli olarak listelemek için: (2) ");
                    string yanit = Console.ReadLine();
                    if(yanit.Equals("1")){
                    kullanicilar.Sort((k1,k2) => k1.isim.CompareTo(k2.isim));
                        kullaniciIslemleri.RehberiListele(kullanicilar);
                    }else{
                        kullanicilar.Sort((k1,k2) => k1.isim.CompareTo(k2.isim));
                        kullanicilar.Reverse();
                        kullaniciIslemleri.RehberiListele(kullanicilar);
                    }
                }else if (islem == 5){
                    kullaniciIslemleri.RehberdeAramaYap(kullanicilar);
                }
                
                islem = kullaniciIslemleri.IslemleriListele();
            }   

        }
    }
}
