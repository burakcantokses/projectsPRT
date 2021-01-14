using System;

namespace delta
{              
    class Program
    {
        static void Main(string[] args)
        {
           float vize,final,ortalama;
           System.Console.WriteLine("Vize Notunuzu Girin.");
           vize = Convert.ToSingle(Console.ReadLine())/100*40;
           System.Console.WriteLine("Final Notunuzu Girin.");
           final = Convert.ToSingle(Console.ReadLine())/100*60;
           ortalama = (vize+final)/2;
            System.Console.WriteLine("Ortalamanız: " + ortalama);
        }
    }
}
