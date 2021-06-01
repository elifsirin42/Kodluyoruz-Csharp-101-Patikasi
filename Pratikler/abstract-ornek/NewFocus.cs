using System;

namespace abstract_ornek
{
    public class NewFocus : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }

    }
}