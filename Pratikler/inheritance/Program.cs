using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /***                    Canlılar
                                        |
                    Bitkiler                        Hayvanlar
                        |                               |
            Tohumlu          Tohumsuz      Surungenler      Kuslar
            ***/

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            //tohumluBitki.Beslenme();
            //tohumluBitki.Solunum();
            //tohumluBitki.Bosaltim();
            //tohumluBitki.Fotosentez();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("************************");
            
            Kuslar marti = new Kuslar();
            //marti.Solunum();
            //marti.Beslenme();
            //marti.Bosaltim();
            //marti.Adaptasyon();
            marti.Ucmak();
             


        }
    }
}
