using System;

namespace abstract_ornek
{
    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Toyoto;
        }

        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
            
        }

    }
}