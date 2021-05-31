using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T -> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(52);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
            

            //Foreach ve List.ForEach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
                
            }
             foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
                
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listenden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            
            //Liste içerisinde Arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içerisinde bulundu!");

            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));
            
            //Diziyi List'e çevirme
            string[] hayvanlar = {"kedi", "köpek", "kuş"};
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?
            hayvanlarListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.isim = "ELif";
            kullanici1.soyisim = "Şirin";
            kullanici1.yas = 23;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.isim = "Merve";
            kullanici2.soyisim = "Altek";
            kullanici2.yas = 29;
            
            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar(){
                isim = "Elif",
                soyisim = "Şirin",
                yas = 23
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici Adi: " + kullanici.isim);
                Console.WriteLine("Kullanici Soyadi: " + kullanici.soyisim);
                Console.WriteLine("Kullanici Yaşı: " + kullanici.yas);
                
            }

            kullaniciListesi.Clear();
            
    
            
        }
    }

    public class Kullanicilar{
        public string isim { get; set; }
        public string soyisim { get; set; }

        public int yas { get; set; }    
        
    }

}
