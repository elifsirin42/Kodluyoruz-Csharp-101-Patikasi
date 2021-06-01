using System;

namespace inheritance
{

    public class Hayvanlar : Canlilar{
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");   
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temase tepki verir.");
            
        }
    }
    public class Surungenler : Hayvanlar{
        public Surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SurunerekHareketEderler(){
            Console.WriteLine("Sürüngenler sürünerek haraket ederler");   
        }
    }
    public class Kuslar : Hayvanlar{
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void Ucmak(){
            Console.WriteLine("Kuslar uçar.");   
        }
    }

}