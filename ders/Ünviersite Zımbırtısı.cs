using System;

namespace delta
{              
    class Program
    {
        static void Main(string[] args)
        {
            String ad, soyad, telefonNo, istenilenUni, alinanUni;
            double diplomaPuan, uniPuan;
            System.Console.WriteLine("Adınızı Girin.");
            ad = Console.ReadLine();
            System.Console.WriteLine("Soyadınızı Girin.");
            soyad = Console.ReadLine();
            CHECK1:
            System.Console.WriteLine("Telefon Numaranızı Girin.");
            telefonNo = Console.ReadLine();
            if (telefonNo.Length<11 || telefonNo.Length>11) {
                System.Console.WriteLine("Geçerli Numara Gir!");
                goto CHECK1;
            }   
            CHECK2:
            System.Console.WriteLine("Diploma Puanınızı Girin.");
            diplomaPuan = Convert.ToDouble(Console.ReadLine());
            if (diplomaPuan>100 || diplomaPuan<0) {
                System.Console.WriteLine("Geçerli Not Gir. 100den büyük olamaz. 0'dan küçük olamaz.");
                goto CHECK2;
            }
            System.Console.WriteLine("Üniversite Puanınızı Girin.");
            uniPuan = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Hedeflediğiniz Üniversiteyi Girin.");
            istenilenUni = Console.ReadLine();
            System.Console.WriteLine("Kazandığınız Üniveristeyi Girin.");
            alinanUni = Console.ReadLine();

            System.Console.WriteLine("\nMerhaba {0} {1} - Telefon Numaranız: {2}",ad,soyad,telefonNo);
            System.Console.WriteLine("\nDiploma Puanınız: {0} \n Üniversite Puanınız: {1}", diplomaPuan,uniPuan);
            System.Console.WriteLine("\nİstediğiniz Üniversite: {0} \nKazandığınız Üniversite {1}",istenilenUni,alinanUni);
        }
    }
}
