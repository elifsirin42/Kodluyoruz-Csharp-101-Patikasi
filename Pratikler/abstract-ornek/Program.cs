using System;

namespace abstract_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arayüzler Örnek Çıktısı yazılmıştır.
            Console.WriteLine();
            Console.WriteLine("********* Arayüzler Örnek Çıktısı **********");
            
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());
            Console.WriteLine("*********************************************");

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            Console.WriteLine("*********************************************");
            
            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla.KacTekerlektenOlusur().ToString());
            Console.WriteLine(corolla.StandartRengiNe().ToString());
            Console.WriteLine("*********************************************");

            //Abstract Örnek Çıktısı yazılmıştır.
            Console.WriteLine();
            Console.WriteLine("********* Abstract Örnek Çıktısı **********");

            NewFocus newFocus = new NewFocus();
            Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(newFocus.StandartRengiNe().ToString()); 
            Console.WriteLine("*********************************************");

            NewCivic newCivic = new NewCivic();
            Console.WriteLine(newCivic.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(newCivic.StandartRengiNe().ToString());
            Console.WriteLine("*********************************************");

            NewCorolla newCorolla = new NewCorolla();
            Console.WriteLine(newCorolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCorolla.KacTekerlektenOlusur().ToString());
            Console.WriteLine(newCorolla.StandartRengiNe().ToString());
            Console.WriteLine("*********************************************");
           
        }
    }
}
