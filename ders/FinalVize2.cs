using System;

namespace delta
{              
    class Program
    {
        static void Main(string[] args)
        {
            String ad,soyad;
           float vize,final,ortalama;
           System.Console.WriteLine("Adınızı Girin.");
           ad = Console.ReadLine();
           System.Console.WriteLine("Soyadınızı Girin.");
           soyad = Console.ReadLine();
           System.Console.WriteLine("Vize Notunuzu Girin.");
           vize = Convert.ToSingle(Console.ReadLine())/100*40;
           System.Console.WriteLine("Final Notunuzu Girin.");
           final = Convert.ToSingle(Console.ReadLine())/100*60;
           ortalama = (vize+final)/2;
           System.Console.WriteLine("Merhaba {0} {1}",ad,soyad);
           System.Console.WriteLine("Ortalamanız: " + ortalama);
        }
    }
}
