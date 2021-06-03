using System;
using System.Collections.Generic;

namespace PROJE_2_Console_ToDo_Uygulamasi
{
    class Islemler
    {
         // Kullanıcıya yapabilceği işlemlerin listelenmesi sağlanmıştır.
        public int IslemleriListele(){
            Console.WriteLine();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("**********************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
          

            Console.Write("İşlem Numarasi: ");
            
            int sonuc = 0;
            try
            {
               sonuc = Int32.Parse(Console.ReadLine());
                
            }
            catch (System.Exception)
            {
                 Console.WriteLine("Sistemden çıkış Yapılıyor...");
                 Environment.Exit(0);    
            }
            if(sonuc==1){
                Console.WriteLine("(1) Board Listelemek");
                return 1;
            }
            else if ( sonuc==2){

                 Console.WriteLine("(2) Board'a Kart Eklemek");
                return 2;
            }
            else if ( sonuc==3){
                Console.WriteLine("(3) Board'dan Kart Silmek");
                return 3;
                
            }
            else if ( sonuc==4){
                  Console.WriteLine("(4) Kart Taşımak");
                    return 4;  
            }else{
                Console.WriteLine("Geçersiz bir işlem girdiniz. Sistemden çıkılıyor.");
                //Environment.Exit(0);
            }
            return 0;
        }
        // Board line'lara ayrılarak listelenmesi ve kullanıcıya gösterilmesi sağlanmıştır.
        public void BoardListele(List<Kart> kartlar,List<Kart> toDoKartlar, List<Kart> inProgressKartlar, List<Kart> doneKartlar){
            kartlariAyir(kartlar,toDoKartlar,inProgressKartlar,doneKartlar);
            Console.WriteLine();
            
            Console.WriteLine("TODO Line");
            Console.WriteLine("********************************");
            
            for (var i = 0; i < toDoKartlar.Count; i++)
            {
                if (toDoKartlar.Count == 0){
                    Console.WriteLine("~ BOŞ ~");   
                }
                Console.WriteLine("Baslik       :  " + toDoKartlar[i].Baslik);
                Console.WriteLine("İçerik       :  " + toDoKartlar[i].Icerik);
                Console.WriteLine("Atanan Kişi  :  " + toDoKartlar[i].AtananKisi.toString());
                Console.WriteLine("Büyüklük     :  " + toDoKartlar[i].KartBuyuklugu);
                Console.WriteLine("-");
                
            }
            Console.WriteLine();
            
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("********************************");
            
            for (var i = 0; i < inProgressKartlar.Count; i++)
            {
                if (inProgressKartlar.Count == 0){
                    Console.WriteLine("~ BOŞ ~");   
                }
                Console.WriteLine("Baslik       :  " + inProgressKartlar[i].Baslik);
                Console.WriteLine("İçerik       :  " + inProgressKartlar[i].Icerik);
                Console.WriteLine("Atanan Kişi  :  " + inProgressKartlar[i].AtananKisi.toString());
                Console.WriteLine("Büyüklük     :  " + inProgressKartlar[i].KartBuyuklugu);
                Console.WriteLine("-");
                
            }
            Console.WriteLine();

            Console.WriteLine("DONE Line");
            Console.WriteLine("********************************");
            
            for (var i = 0; i < doneKartlar.Count; i++)
            {
                if (doneKartlar.Count == 0){
                    Console.WriteLine("~ BOŞ ~");   
                }
              Console.WriteLine("Baslik       :  " + doneKartlar[i].Baslik);
                Console.WriteLine("İçerik       :  " + doneKartlar[i].Icerik);
                Console.WriteLine("Atanan Kişi  :  " + doneKartlar[i].AtananKisi.toString());
                Console.WriteLine("Büyüklük     :  " + doneKartlar[i].KartBuyuklugu);
                Console.WriteLine("-");
                
            }
            Console.WriteLine();
        }

        // Yeni bir kartın oluşturularak Board'a eklenmesi sağlanmıştır.
        public bool BoardEkle(List<Kart> kartlar, List<Uye> kisiler){
           
            Console.Write("Baslik Giriniz                                 :  " );
            string baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz                                 :  " );
            string icerik = Console.ReadLine();
            Console.Write("Büyüklük seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :  " );
            int kartBüyüklük =Convert.ToInt32(Console.ReadLine());
            Console.Write("Kişi Seçiniz(ID)                               :  ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (var k in kisiler)
            {
                if(k.Id == id){
                    kartlar.Add(new Kart(baslik,icerik, (buyukluk) kartBüyüklük,k,line.ToDo));
                    Console.WriteLine("Kart Board'a başarılı bir şekilde eklenmiştir.");
                    return true;
                }
            }
            Console.WriteLine("Takım üyesi ID numarasi mevcut değildir.");
            Console.WriteLine("Hatalı girişler yaptınız!");
            
            return false;

        }

        //Board'da kullanıcının girdileri doğrultusunda kartın silinmesi sağlanmıştır.
        public bool BoardSil(List<Kart> kartlar){
           
            Console.Write("Öncellikle silmek istediğiniz kartı seçmeniz gerekiyor." );
            Console.Write(" Lütfen kart başlığını yazınız:  " );
            string baslik = Console.ReadLine();

            foreach (var k in kartlar)
            {
                if(k.Baslik.Equals(baslik)){
                    kartlar.Remove(k);
                    Console.WriteLine("Kart Board'dan başarılı bir şekilde silinmiştir.");
                    return true;
                }
            }
            return false;

        }

        //Kullanıcının girdileri doğrultusunda kartın farklı bir line'a taşınması sağlanmıştır.
        public bool KartTasi(List<Kart> kartlar ){
           
            Console.Write("Öncellikle taşımak istediğiniz kartı seçmeniz gerekiyor." );
            Console.Write(" Lütfen kart başlığını yazınız:  " );
            string baslik = Console.ReadLine();

            foreach (var k in kartlar)
            {
                if(k.Baslik.Equals(baslik)){
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Baslik       :  " + k.Baslik);
                    Console.WriteLine("İçerik       :  " + k.Icerik);
                    Console.WriteLine("Atanan Kişi  :  " + k.AtananKisi.toString());
                    Console.WriteLine("Büyüklük     :  " + k.KartBuyuklugu);
                   
                    Console.WriteLine(); 
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO ");
                    Console.WriteLine("(2) IN PROGRESS ");
                    Console.WriteLine("(3) DONE ");

                    string yanit = Console.ReadLine();

                    if (yanit.Equals("1")){
                        k.Status = line.ToDo;
                    }else if(yanit.Equals("2")){
                        k.Status = line.InProgress;
                    }else if(yanit.Equals("3")){
                        k.Status = line.Done;
                    }else{
                        Console.WriteLine("Hatalı bir seçim yaptınız");
                        return false;     
                    }
                    Console.WriteLine("Kart istenilen Board'a başarılı bir şekilde taşınmıştır.");
                    return true;
                }
            }
            return false;

        }

        //Kartların To Do, In Progress ve Done olarak ayrılması sağlanmıştır. 
        public void kartlariAyir(List<Kart> kartlar, List<Kart> toDoKartlar, List<Kart> inProgressKartlar, List<Kart> doneKartlar){
            toDoKartlar.Clear();
            inProgressKartlar.Clear();
            doneKartlar.Clear();
            foreach (var k in kartlar)
            {
                if(k.Status.Equals(line.ToDo)){
                    toDoKartlar.Add(k);
                }
                if(k.Status.Equals(line.InProgress)){
                    inProgressKartlar.Add(k);
                }
                if(k.Status.Equals(line.Done)){
                    doneKartlar.Add(k);
                }
            }
        }
    }
}