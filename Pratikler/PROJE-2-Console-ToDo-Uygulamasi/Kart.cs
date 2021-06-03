namespace PROJE_2_Console_ToDo_Uygulamasi
{
    class Kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public buyukluk KartBuyuklugu { get; set; }
        
        public Uye AtananKisi { get; set; }
        
        public line Status { get; set; }

        public Kart(){}
        public Kart(string baslik, string ıcerik, buyukluk kartBuyuklugu, Uye atananKisi, line status)
        {
            Baslik = baslik;
            Icerik = ıcerik;
            KartBuyuklugu = kartBuyuklugu;
            AtananKisi = atananKisi;
            Status = status;
        }
    
    }
}