using System;

namespace ClasIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ömer";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Ömer Faruk";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Mert";
            kurs2.KursAdi = "JAVA";
            kurs2.IzlenmeOrani = 60;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Cengiz";
            kurs3.KursAdi = "Python";
            kurs3.IzlenmeOrani = 40;

            Kurs kurs4 = new Kurs();
            kurs4.Egitmen = "Halil";
            kurs4.KursAdi = "C++";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                //Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            //Console.WriteLine("Hello World!");
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
