using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string [] renkler = new string[5];

            string [] hayvanlar = {"Kedi", "Köpek", "Kuş","Maymun"};
            
            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve Erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngüler ile dizi kullanımı
            //Klavyeden girinlen n tane sayının ortalamasını hesaplayan program
         Console.WriteLine("Lütfen dizinin eleman sayısını giriniz.");
         int diziUzunlugu = int.Parse(Console.ReadLine());
         int[] sayiDizisi = new int[diziUzunlugu];

         for (var i = 0; i < diziUzunlugu; i++)
         {
             Console.WriteLine("Lütfen {0}. sayısını giriniz.", i+1);
             sayiDizisi[i] = int.Parse(Console.ReadLine());
         }
         int toplam = 0;
         foreach (var sayi in sayiDizisi)
            toplam += sayi;
        
        Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);        
        }
    }
}
