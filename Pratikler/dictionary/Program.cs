using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collection.Generic
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(1, "ELif Şirin");
            kullanicilar.Add(2,"Ayşe Yılmaz");
            kullanicilar.Add(18, "Ahmet Çınar");
            kullanicilar.Add(22,"Özcan Yılmaz");

            //Dizinin Elemanlarına Erişim
            Console.WriteLine(" ***** Dizinin Elemanlarına Erişim ***** ");
            Console.WriteLine(kullanicilar[2]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
                
            }

            //Count
            Console.WriteLine(" **** Count ***** ");
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine(" **** Contains ***** ");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsKey(1));
            Console.WriteLine(kullanicilar.ContainsValue("ELif Şirin"));

            //Remove
            Console.WriteLine(" **** Remove ***** ");
            kullanicilar.Remove(22);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
                
            }

            //Keys
            Console.WriteLine(" **** Keys ***** ");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
                
            }

            //Values
            Console.WriteLine(" **** Values ***** ");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
                
            }

            
            
            
            
        }
    }
}
