using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> kullanicidanAlinanSayilar = new List<int>();
            kullanicidanAlinanSayilar = YirmiAdetSayiAl();

            //Kullanıcıdan alınan sayılar küçükten büyüğe sıralanıyor.
            kullanicidanAlinanSayilar.Sort();

            int[] ucKucukSayi = new int[3];
            int[] ucBuyukSayi = new int[3];

            //Alınan Sayılara göre uç Kuçuk sayı alınıyor.
            ucKucukSayi[0] = kullanicidanAlinanSayilar[0];
            ucKucukSayi[1] = kullanicidanAlinanSayilar[1];
            ucKucukSayi[2] = kullanicidanAlinanSayilar[2];

             //Alınan Sayılara göre uç Buyuk sayı alınıyor.
            ucBuyukSayi[0] = kullanicidanAlinanSayilar[17];
            ucBuyukSayi[1] = kullanicidanAlinanSayilar[18];
            ucBuyukSayi[2] = kullanicidanAlinanSayilar[19];

            //Kullanıcıdan alınan üç küçük sayı ekrana yazdırılıyor
             Console.WriteLine(" *** Kullanıcıdan Alınan 3 Küçük Sayi *** ");
            foreach (var k in ucKucukSayi)
            {
                Console.WriteLine(k);
                
            }   

            //Kullanıcıdan alınan üç büyük sayı ekrana yazdırılıyor
            Console.WriteLine(" *** Kullanıcıdan Alınan 3 Büyük Sayi *** ");
            foreach (var b in ucBuyukSayi)
            {
                Console.WriteLine(b);
                
            }          
            

            //Uç kuçuk sayının ortalaması hesaplanıyor.
            int kucukSayilarinOrtalamasi = OrtalamaHesapla(ucKucukSayi);
            Console.WriteLine("Kullanıcıdan alınan 3 küçük sayının ortalaması: " + kucukSayilarinOrtalamasi);
            

            
            //Uç buyuk sayının ortalaması hesaplanıyor.
            int buyukSayilarinOrtalamasi = OrtalamaHesapla(ucBuyukSayi);
            Console.WriteLine("Kullanıcıdan alınan 3 büyük sayının ortalaması: " + buyukSayilarinOrtalamasi);
            
            // 3 Küçük sayı ve 3 Büyük sayının ortalamaları toplamı ekrana yazdırılıyor.
            Console.WriteLine("3 Küçük sayı ve 3 Büyük sayının ortalamaları toplamı: " + (buyukSayilarinOrtalamasi + kucukSayilarinOrtalamasi));
            
        }

          //Konsoldan girilen sayının kontrolu için oluşturulmuştur.
        public static int SayiKontrol(string konsoldakiİfade){

            try
            {
                int n = Int32.Parse(konsoldakiİfade);
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
        public static List<int> YirmiAdetSayiAl(){

            List<int> alınanSayilar = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ",i+1);
                int sayi = SayiKontrol(Console.ReadLine());
                alınanSayilar.Add(sayi);

            }
            return alınanSayilar;
        }

        public static int OrtalamaHesapla(int[] liste){
            int toplam = 0;
            for (var i = 0; i < liste.Length; i++)
            {
               toplam +=liste[i]; 
            }
            return toplam/liste.Length;
        }
    }
}
