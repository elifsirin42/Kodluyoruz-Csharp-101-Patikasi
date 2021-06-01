using System;

namespace abstract_ornek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Hondo;                                                                                              
        }   

        public int KacTekerlektenOlusur()
        {
            return 4; 
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;  
        }
    }
}