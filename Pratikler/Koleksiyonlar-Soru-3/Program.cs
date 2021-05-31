using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = CumleAl();

            //Kullanıcıdan alınan sesli harfler bir dizi içerisinde saklanmıştır.
            List<char> sesliHarfler = SesliHarfler(cumle);

            //Kullanıcıdan alınan sesli harfler sıralanmıştır.
            sesliHarfler.Sort();

            //Kullanıcıdan alınan sesli harfler sıralı bir şekilde console a yazdırılmıştır.
            foreach (var sesliHarf in sesliHarfler)
            {
                Console.WriteLine(sesliHarf);
                
            }
        }

        //Kullanıcıdan cümle alınması sağlanmıştır.
        public static string CumleAl(){

            Console.WriteLine("Lütfen bir cümle giriniz: ");
            string alinanCümle = Console.ReadLine();

            return alinanCümle;
        }

        public static List<char> SesliHarfler(string cumle){
            List<char> sesliHarfler = new List<char>();
            List<char> alinanHarfler = new List<char>();
            
            for (int i = 0; i < cumle.Length; i++)
            {
                if(cumle[i] == ' '){
                    Console.WriteLine("Boşluğa denk geldik!");
                }else{
                    alinanHarfler.Add(cumle[i]);
                }
            }

            foreach (var harf in alinanHarfler)
            {
                if((harf == 'a') || (harf == 'a') || (harf == 'e') || (harf == 'i') || (harf == 'o')|| (harf == 'u')){
                    sesliHarfler.Add(harf);
                }  
            }

            return sesliHarfler;
        }
    }
}
