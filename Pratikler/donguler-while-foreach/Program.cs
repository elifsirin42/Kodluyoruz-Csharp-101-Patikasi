using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1den başlayarak konsoldan gelen sayıya kadar, gelen sayı dahil, ortalamasaını hesaplayıp, konsola yazdıran program
            Console.WriteLine("Lütfen bir sayi giriniz: ");
            
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac<= sayi) 
            {
                toplam+= sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama: " + toplam/sayi);
            

            //a'dan z'ye kadar olan tüm harfleri console a yazdıran program
            char chracter = 'a';
            while (chracter < 'z')
            {
                Console.WriteLine(chracter);
                chracter++;
                
            }
            Console.WriteLine("*** Foreach ***");
            string [] arabalar = {"BMW", "Ford", "Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba); 
            }
            
        }
    }
}
