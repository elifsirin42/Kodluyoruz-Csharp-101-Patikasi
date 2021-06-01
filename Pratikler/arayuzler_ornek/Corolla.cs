using System;

namespace arayuzler_ornek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Toyoto;                                                                                              
        }   

        public int KacTekerlektenOlusur()
        {
            return 4; 
        }

        public Renk StandartRengiNe()
        {
            return Renk.Kırmızı;  
        }
    }
}