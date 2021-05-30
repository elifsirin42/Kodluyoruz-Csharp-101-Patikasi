using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı :" + sayi);  
            }
            catch (Exception ex)
            {
                 Console.WriteLine("Hata: " + ex.Message.ToString());
                 
            }
            //Optinal code block
            finally
            {
               Console.WriteLine("İşlem Tamamlandı!");
                
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-22224455484546454");
            }
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex);
            }
            catch(FormatException ex){
                              
                Console.WriteLine("Format uygun değil!");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                              
                Console.WriteLine("Çok küçük veya çok büyük değer girdiniz!");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("İşlem başarıyla tamamlandı :)");
                
            }
            
        }
    }
}
