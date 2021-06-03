using System;
using System.Collections.Generic;
using System.Linq;

namespace PROJE_2_Console_ToDo_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takim üyeleri oluşturulmuştur ve listede tutulması sağlanmıştır.
            List<Uye> takimUyeleri = new List<Uye>();
            Uye uye1 = new Uye(1, "Elif");
            Uye uye2 = new Uye(2, "Mithat");
            Uye uye3 = new Uye(3, "Ali");
            Uye uye4 = new Uye(4, "Merve");
            Uye uye5 = new Uye(5, "Arda");
            
            takimUyeleri.Add(uye1);
            takimUyeleri.Add(uye2);
            takimUyeleri.Add(uye3);
            takimUyeleri.Add(uye4);
            takimUyeleri.Add(uye5);

            // Her bir line için kart listeleri oluşturulmuştur.
            List<Kart> kartlar = new List<Kart>();
            List<Kart> toDoKartlar = new List<Kart>();
            List<Kart> inProgressKartlar = new List<Kart>();
            List<Kart> doneKartlar = new List<Kart>();

            Kart kart1 = new Kart("C# ", "C# hakkında makale hazırlama", buyukluk.S, uye1,line.InProgress);
            Kart kart2 = new Kart(".Net", ".Net kurulum sağlama", buyukluk.L, uye5,line.Done);
            Kart kart3 = new Kart("Java", "App geliştirme", buyukluk.L, uye4,line.ToDo);
            Kart kart4 = new Kart("React", "Site hazırlama", buyukluk.XL, uye2,line.InProgress);

            kartlar.Add(kart1);
            kartlar.Add(kart2);
            kartlar.Add(kart3);
            kartlar.Add(kart4);

            Islemler islemler = new Islemler();
            islemler.kartlariAyir(kartlar,toDoKartlar,inProgressKartlar,doneKartlar);
            islemler.BoardListele(kartlar,toDoKartlar,inProgressKartlar,doneKartlar);

            int islem = islemler.IslemleriListele();

             // Kullanıcının sistemden çıkmadan devamlı olarak işlem girebilmesi sağlanmıştır.
            // İşlem numaralarına göre gerekli işlemin başlatılması sağlanmıştır.
            while(islem != 0){
                
                if(islem == 1){
                    islemler.BoardListele(kartlar,toDoKartlar,inProgressKartlar,doneKartlar);

                }else if ( islem == 2) {
                    islemler.BoardEkle(kartlar,takimUyeleri);

                    
                }else if ( islem == 3){
                    bool bool_islem = islemler.BoardSil(kartlar); 
                    if(bool_islem){
                        Console.WriteLine("Kart başarıyla eklenmiştir!");
                    }else{
                        Console.WriteLine($"Aradığınız kriterlere uygun kart bulunamadi. Lütfen bir seçim yapınız.");
                        Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
                        Console.WriteLine("*Yeniden denemek için : (2) ");
                        string sonuc = Console.ReadLine();
                        if (sonuc.Equals("1")) {
                            Console.WriteLine("İşlem Sonlandırılmıştır..");
                        }else{
                            bool_islem = islemler.BoardSil(kartlar); 
                        } 
                    }  
                }else if ( islem == 4){
                    bool bool_islem = islemler.KartTasi(kartlar); 
                }
                islem = islemler.IslemleriListele();
                
            }
        }

    }
}

