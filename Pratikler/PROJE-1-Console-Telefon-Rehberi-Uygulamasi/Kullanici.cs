using System;

namespace PROJE_1_Console_Telefon_Rehberi_Uygulamasi {

    //Kullanici sınıfı oluşturulmuştur.
    public class Kullanici {


        public string isim { get; set; }
        public string soyIsim { get; set; }
       public string TelNo { get; set;}

        public Kullanici () { }
        public Kullanici (string isim, string soyIsim) {
            this.isim = isim;
            this.soyIsim = soyIsim;

        }
        public Kullanici (string isim, string soyIsim, string telNo) {
            this.isim = isim;
            this.soyIsim = soyIsim;
            TelNo = telNo;
        }

    }

}