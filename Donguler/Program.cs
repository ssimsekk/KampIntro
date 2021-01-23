using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //array - dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
                "Programlamaya başlangıç için temel kurs","Java","Python","C#" };


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti!");

            foreach (string kurs in kurslar)   //foreach dizilere uygulanır
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
