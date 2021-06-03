namespace PROJE_2_Console_ToDo_Uygulamasi
{
    class Uye
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public Uye(int ıd, string ısim)
        {
            Id = ıd;
            Isim = ısim;
        }
        
        public string toString(){
            return Id + " numarali " + Isim ;
        }
    }
}