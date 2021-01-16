using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazılım geliştirme kursu";
            string kurs2 = "programlamaya başlangıç kursu";
            string kurs3 = "java kursu";
            string kurs4 = "c++";
            string kurs5 = "r dersleri";
            // array - dizi
            string[] kurslar = new string[] { "yazılım geliştirme kursu","programlamaya başlangıç kursu", "java kursu", "c++", "r dersleri" };
            
            
            
            
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");


            foreach (string i in kurslar)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("foreach bitti");


            

        }  
    }
}
