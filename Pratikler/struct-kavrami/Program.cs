using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            /***Yapıların özellikleri:

            Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
            Diğer struct yada sınıflardan kalıtım almazlar.
            Interface'lerden kalıtım alabilirler.
            new anahtar sözcüğü ile nesneleri yaratılabilir.
            Sınıflar gibi metot, property ve field'lardan oluşurlar.
            Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
            Static üye barındırabilirler. **/

            //Class => Heap'te tutulur.
            //Struct => Stack'te tutulur.
        
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar=3;
            dikdortgen.UzunKenar=4;

            Console.WriteLine("Class Alan Hesabi: {0}",dikdortgen.AlanHesapla());
            
            Dikdortgen_Struct dikdortgen_struct;
            dikdortgen_struct.KisaKenar=3;
            dikdortgen_struct.UzunKenar=4;

            Console.WriteLine("Struct Alan Hesabi: {0}",dikdortgen_struct.AlanHesapla());
            

        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar*this.UzunKenar;   
        }
    }
    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar*this.UzunKenar;   
        }

    }
}
