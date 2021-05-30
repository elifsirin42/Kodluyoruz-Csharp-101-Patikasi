using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>=6 && time<11)
            Console.WriteLine("Günaydınn!");
            else if(time<=18)
            Console.WriteLine("İyi Günlerr!");
            else
                Console.WriteLine("İyi Gecelerr!");
                
            string sonuc = time <= 10 ? "İyi Günler!" : "İyi Geceler!";

            sonuc = time >= 6 && time <11 ? "Günaydinn!" : time <= 18 ? "İyi günlerr!" : "İyi Gecelerr!";

            Console.WriteLine(sonuc);       
        }
    }
}
