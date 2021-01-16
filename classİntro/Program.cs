using System;

namespace classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.eğitmen = "engin demirdog";
            kurs1.IzlenOrani = 37;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.eğitmen = "gökhan";
            kurs2.IzlenOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.eğitmen = "ali emre";
            kurs3.IzlenOrani = 41;

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.eğitmen);


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var i in kurslar)
            {
                Console.WriteLine(i.KursAdi + " " + i.IzlenOrani);
            }

        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }

        public string eğitmen { get; set; }

        public int IzlenOrani { get; set; }



    }
}
