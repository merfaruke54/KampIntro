using System;

namespace Dongular
{
    class Program
    {
        static void Main(string[] args)
        {
            //aray - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "programlamaya başlangıç için temel kurs", "java" ,"phyton","C#"};

            for (int i = 0;  i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("foor bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
             
            

            
        }
    }
}
