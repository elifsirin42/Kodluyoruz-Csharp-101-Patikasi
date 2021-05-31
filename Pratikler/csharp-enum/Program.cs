using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*** Enum
                Uygulama geliştirirken sabit değerlerle çalışmak durumunda kalırız. 
                Bu noktalarda okunabilirliği yüksek bir program yazmak istiyorsak enum lasrdan faydalanırız.

                "enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir. 
                Sayısal verilerı string ifadelerle saklamanızı sağlar. 
                Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz. ***/

            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);
            
            int sicaklik = 32;

            if(sicaklik<=(int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanin biraz daha ısınmasını bekle!");
            else if (sicaklik>=(int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün!");
            else if (sicaklik>=(int)HavaDurumu.Sıcak && sicaklik<(int)HavaDurumu.CokSıcak)
                Console.WriteLine("Hadi dışarıya çıkalım!");
            
        }
    }
    enum Gunler
    {
        Pazatesi,
        Sali,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk = 5,
        Normal =20,
        Sıcak=25,
        CokSıcak=30
    }
}
