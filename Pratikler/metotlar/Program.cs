using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirtici geri_donus_tipi metot_adi(parametreListesi/arguman)
            //{
              ////Komutlar;
                //return;
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine("Toplam: "+ (a+b));
            
            int sonuc = Topla(a,b);
            Console.WriteLine("Sonuç: " + sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirveTopla(ref a, ref b);
            Console.Write($"Sonuc2:");
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));  
        }
        
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine("Ekrana yazdırılan veri: "+ veri);
            
        }

        public int ArttirveTopla(ref int deger1, ref int deger2)
        {
            deger2++;
            deger1++;
            return (deger1 + deger2);
        }
    }
}
