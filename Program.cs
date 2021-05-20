using System;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {  
            string metin = "0";
            do{
            Console.WriteLine("Selam ben papağan uygulama!");
            Console.WriteLine("Yazı yaz ama 0 basarsan bu uygulama kapanır");  
            metin = Console.ReadLine();
            isimKaydet(metin);
            }while(metin != "0");

            
        }
        static void isimKaydet(string metin)
        {
            string yazi = metin;
            Console.WriteLine(yazi);
        }

    }
}
