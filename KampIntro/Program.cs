using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("aşağı oku");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("yukarı oku");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Girişi yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

           
        }
    }
}
