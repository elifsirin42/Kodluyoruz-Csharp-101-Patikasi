using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           //Atama ve işlemli Atama

           Console.WriteLine("****** Atama ve İşlemli Atama ******");

           int x = 3;
           int y = 3;
           y = y+2;
           Console.WriteLine("y=y+2: y=" +  y);
           y +=2;
           Console.WriteLine("y+=2: y=" + y);
           y/=1;
           Console.WriteLine("y/=1: y=" + y);
           x *=2;
           Console.WriteLine("x*=2: x=" + x);

           //Mantıksal Operatörler
           // ||, &&, !
            
            Console.WriteLine("****** Mantıksal Operatörler ******");

            bool isSucces = true;
            bool isCompleted = false;

            if(isSucces && isCompleted)
                Console.WriteLine("Perfect!");
            

            if(isSucces || isCompleted)
                Console.WriteLine("Great!");
            

            if(isSucces && !isCompleted)
                Console.WriteLine("Fine!");
            

            //İlişkisel Operatörler
            // <, >i <=, >=, ==, !=

            Console.WriteLine("****** İlişkisel Operatörler ******");
            int a = 3;
            int b = 4;
            bool sonuc = a<b;
        
            Console.WriteLine(sonuc);

            sonuc = a>b;
            Console.WriteLine(sonuc);
            
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            
            sonuc = a==b;
            Console.WriteLine(sonuc);

            sonuc = a!=b;
            Console.WriteLine(sonuc);

            //Aritmetik Operatörler
            // /, *, +, -

            Console.WriteLine("****** Aritmetik Operatörler ******");
            
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1-sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);
            
            //% : mod alır
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);
            
            


        }
    }
}
