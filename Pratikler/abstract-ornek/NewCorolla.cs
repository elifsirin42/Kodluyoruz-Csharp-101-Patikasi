using System;

namespace abstract_ornek
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Toyoto;
        }

    }
}