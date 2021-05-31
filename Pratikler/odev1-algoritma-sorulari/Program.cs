using System;
using System.Collections.Generic;

namespace odev1_algoritma_sorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Birinci sorudaki istenilenler yapılmıştır.
            Console.WriteLine("**** Birinci Sorunun Cevabı ****");
            
            Soru1 cevap1 = new Soru1();
            List<int> kullanicidanAlinanSayilar = cevap1.NAdetPozitifSayiAl();
            cevap1.CiftSayilariYazdir(kullanicidanAlinanSayilar);

            Console.WriteLine("*****************************************");
            
            //İkinci sorudaki istenilenler yapılmıştır.
            Console.WriteLine("**** İkinci Sorunun Cevabı ****");
            
            Soru2 cevap2 = new Soru2();
            int[] alinanMveNSayilari = cevap2.NveMSayilarınıAl();
            int n1 = alinanMveNSayilari[0];
            int m = alinanMveNSayilari[1];
            List<int> kullanicidanAlinanNadetSayi = cevap2.NAdetPozitifSayiAl(n1);
            cevap2.MeEsitveyaBolunebilenler(kullanicidanAlinanNadetSayi, m);

            Console.WriteLine("*****************************************");

            //Üçüncü sorudaki istenilenler yapılmıştır.
            Console.WriteLine("**** Üçüncü Sorunun Cevabı ****");
            
            Soru3 cevap3 = new Soru3();
            int n2 = cevap3.NSayisiniAl();
            List<string> kullanicidanAlinanNadetKelime = cevap3.NAdetKelimeAl(n2);
            cevap3.KelimeleriSondanBaşaYazdir(kullanicidanAlinanNadetKelime);

            Console.WriteLine("*****************************************");

            //Dördüncü sorudaki istenilenler yapılmıştır.
            Console.WriteLine("**** Dördüncü Sorunun Cevabı ****");
            
            Soru4 cevap4 = new Soru4();
            string cumle = cevap4.CumleAl();
            cevap4.KelimeSayisi(cumle);
            cevap4.HarfSayisi(cumle);

            Console.WriteLine("*****************************************");
        }
    }

    public class Soru1
    {
        
        /*** Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. ***/


        //Konsoldan girilen sayının kontrolü için oluşturulmuştur.
        private int SayiKontrol(string konsoldakiİfade){

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
        public List<int> NAdetPozitifSayiAl(){

            List<int> alınanSayilar = new List<int>();
            Console.WriteLine("Ekrana Yazdırılmak istenen sayı miktarını  giriniz (n): ");
            string input = Console.ReadLine();
            int n = SayiKontrol(input);

            Console.WriteLine("Ekrana Yazdırılmak istenen sayı miktarı (n): " + n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ",i+1);
                int sayi = SayiKontrol(Console.ReadLine());
                alınanSayilar.Add(sayi);

            }
            return alınanSayilar;
        }

        //Kullanıcıdan alınan çift sayıları konsola yazdırması için oluşturulmuştur.
        public void CiftSayilariYazdir(List<int> list){
            Console.WriteLine("**** Kullanıcıdan Alınan Çift Sayılar ****");
            foreach (var item in list)
            {
                if(item%2==0)
                    Console.WriteLine(item);
            }
        }
    }

     public class Soru2
    {
        
        /*** Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
         Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın ***/


        //Konsoldan girilen sayının kontrolü için oluşturulmuştur.
        private int SayiKontrol(string konsoldakiİfade){

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

        //Kullanıcıdan 2 adet pozitif sayı (m,n) alınması sağlanmıştır.
        public int[] NveMSayilarınıAl(){

            int[] alınanSayilar = new int[2];
            Console.WriteLine("Lütfen n sayısını giriniz: ");
            string alinanN = Console.ReadLine();
            int n = SayiKontrol(alinanN);

            Console.WriteLine("Lütfen m sayısını giriniz: ");
            string alinanM = Console.ReadLine();
            int m = SayiKontrol(alinanM);

            alınanSayilar[0] = n;
            alınanSayilar[1] = m;      

            Console.WriteLine("Alinan sayılar (n,m): " + n  +"," + m);

            return alınanSayilar;
        }

        //Kullanıcıdan n adet pozitif sayı alınması sağlanmıştır.
        public List<int> NAdetPozitifSayiAl(int n){

            List<int> alınanSayilar = new List<int>();

            Console.WriteLine("Ekrana Yazdırılmak istenen sayı miktarı (n): " + n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ",i+1);
                int sayi = SayiKontrol(Console.ReadLine());
                alınanSayilar.Add(sayi);

            }
            return alınanSayilar;
        }


        //Kullanıcıdan alınan çift sayıları konsola yazdırması için oluşturulmuştur.
        public void MeEsitveyaBolunebilenler(List<int> list, int m){
            Console.WriteLine("**** Kullanıcıdan Alınan Sayılardan M'e Eşit veya Tam Bölünebilenler ****");
            foreach (var item in list)
            {
                if(item%m==0)
                    Console.WriteLine(item);
            }
        }
        
    }

    public class Soru3
    {
        
        /*** Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. ***/


        //Konsoldan girilen sayının kontrolü için oluşturulmuştur.
        private int SayiKontrol(string konsoldakiİfade){

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

        //Kullanıcıdan n sayısının alınması sağlanmıştır.
        public int NSayisiniAl(){

            Console.WriteLine("Lütfen n sayısını giriniz: ");
            string alinanN = Console.ReadLine();
            int n = SayiKontrol(alinanN);

            return n;
        }

        //Kullanıcıdan n adet kelime alınması sağlanmıştır.
        public List<string> NAdetKelimeAl(int n){

            List<string> alınanKelimeler = new List<string>();

            Console.WriteLine("Ekrana Yazdırılmak istenen kelime sayisi (n): " + n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. kelimeyi giriniz: ",i+1);
                string kelime = Console.ReadLine();
                alınanKelimeler.Add(kelime);

            }
            return alınanKelimeler;
        }


        //Kullanıcıdan alınan kelimeleri sondan başa doğru yazdırır.
        public void KelimeleriSondanBaşaYazdir(List<string> list){
            Console.WriteLine("**** Kullanıcıdan Alınan Kelimeleri Sondan Başa Doğru Yazılması ****");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        
    }

    
    public class Soru4
    {
        
        /*** Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
        Cümledeki toplam kelime ve harf sayısını console'a yazdırın. ***/


        //Kullanıcıdan cümle alınması sağlanmıştır.
        public string CumleAl(){

            Console.WriteLine("Lütfen bir cümle giriniz: ");
            string alinanCümle = Console.ReadLine();

            return alinanCümle;
        }

        //Kullanıcıdan alınan cümlenin toplam kelime sayisi hesaplanmıştır..
        public void KelimeSayisi(string cumle){

            cumle+=" ";
            List<string> alinanKelimeler = new List<string>();
            int sayac = 0;
            string kelime= "";

            for (int i = 0; i < cumle.Length; i++)
            {
                if(cumle[i] == ' '){
                    sayac++;
                    alinanKelimeler.Add(kelime);
                    kelime = "";
                }else{
                    kelime += cumle[i];
                }
            }

            Console.WriteLine("Alınan Kelime Sayısı: " + sayac );
            Console.WriteLine("Alınan Kelimeler: ");
            
            foreach (var k in alinanKelimeler)
            {
                Console.WriteLine(k);
            }
        }

        //Kullanıcıdan alınan cümlenin toplam harf sayisi hesaplanmıştır..
        public void HarfSayisi(string cumle){
            
            List<char> alinanHarfler = new List<char>();
            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if(cumle[i] == ' '){
                    Console.WriteLine("Boşluğa denk geldik!");
                    
                }else{
                    sayac++;
                    alinanHarfler.Add(cumle[i]);
                }
            }

            Console.WriteLine("Alınan Harf Sayısı: " + sayac );
            Console.WriteLine("Alınan Kelimeler: ");
            
            foreach (var harf in alinanHarfler)
            {
                Console.WriteLine(harf);
            }
        }

        
    }
}
