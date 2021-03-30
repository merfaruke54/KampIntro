using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Strap";
            urun1.Fiyati = 70;
            urun1.Aciklama = "Deri";

            Urun urun2 = new Urun();
            urun2.Adi = "Demir";
            urun2.Fiyati = 100;
            urun2.Aciklama = "Sert";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("----------- Metodlar -----------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("armut", "yeşil armut", 12 , 10);
            sepetManager.Ekle2("elma", "yeşil elma", 12, 9);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12, 12);

        }
    }
}
