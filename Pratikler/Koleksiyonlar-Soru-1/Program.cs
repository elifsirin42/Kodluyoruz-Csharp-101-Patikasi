using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {static void Main(string[] args)
        {
            /*** Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            (ArrayList sınıfını kullanara yazınız.)

                Negatif ve numeric olmayan girişleri engelleyin.
                Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın. ***/

            List<int> kullanicidanAlinanSayilar = new List<int>();
            List<int> asalSayilar = new List<int>();
            List<int> asalOlmayanSayilar = new List<int>();

            kullanicidanAlinanSayilar = YirmiAdetPozitifSayiAl();

            foreach (var sayi in kullanicidanAlinanSayilar)
            {
                if(AsalMi(sayi))
                    asalSayilar.Add(sayi);
                else
                    asalOlmayanSayilar.Add(sayi);
            }
            Console.WriteLine(" **** Sıralı Olarak Asal Sayilar **** ");
            asalSayilar.Sort();
            foreach (var asalSayi in asalSayilar)
            {
                Console.WriteLine(asalSayi);  
            }

            Console.WriteLine(" **** Sıralı Olarak Asal Olmayan Sayilar **** ");
            asalOlmayanSayilar.Sort();
            foreach (var asalOlmayanSayi in asalOlmayanSayilar)
            {
                Console.WriteLine(asalOlmayanSayi);  
            }

            //Asal Olanların eleman sayıları ve elemanlarının ortalamaları yazdırılmıştır
            Console.WriteLine("Asal Olanların Eleman Sayısı: " + asalSayilar.Count);
            Console.WriteLine("Asal Olan Sayıların Ortalaması: " + OrtalamaHesapla(asalSayilar));
            

            //Asal Olmayan eleman sayıları ve elemanlarının ortalamaları yazdırılmıştır
            Console.WriteLine("Asal Olmayanların Eleman Sayısı: " + asalOlmayanSayilar.Count);
            Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + OrtalamaHesapla(asalOlmayanSayilar));
            


        }

         //Konsoldan girilen sayının kontrolü için oluşturulmuştur.
        public static int SayiKontrol(string konsoldakiİfade){

            try
            {
                int n = Int32.Parse(konsoldakiİfade);
                
                if(n <=0 ) {
                    Console.WriteLine("Girdiğiniz sayı 0'dan küçük ve eşit olamaz!");
                    Console.WriteLine("Lütfen yeni bir n sayısı giriniz!");
                    konsoldakiİfade = Console.ReadLine();
                    return SayiKontrol( konsoldakiİfade);
                }

                return n;            
            }
            catch (FormatException)
            {
                Console.WriteLine("Girdiğiniz sayı string bir ifade olamaz!");
                Console.WriteLine("Lütfen yeni bir n sayısı giriniz!");
                konsoldakiİfade = Console.ReadLine();
                return SayiKontrol(konsoldakiİfade);
            }

                return SayiKontrol(konsoldakiİfade);

        }

        //Kullanıcıdan n adet pozitif sayı alınması sağlanmıştır.
        public static List<int> YirmiAdetPozitifSayiAl(){

            List<int> alınanSayilar = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ",i+1);
                int sayi = SayiKontrol(Console.ReadLine());
                alınanSayilar.Add(sayi);

            }
            return alınanSayilar;
        }

        //Sayıların asal olup olmadığının sorgulanması sağlanmıştır.
        public static bool AsalMi(int sayi)
        {
        if ((sayi & 1) == 0)
        {
            if (sayi == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        for (int i = 3; (i * i) <= sayi; i += 2)
        {
            if ((sayi % i) == 0)
            {
                return false;
            }
        }
        return sayi != 1;
        }

        public static int OrtalamaHesapla(List<int> liste){
            int toplam = 0;
            for (var i = 0; i < liste.Count; i++)
            {
               toplam +=liste[i]; 
            }
            return toplam/liste.Count;
        }
    
    }
}

