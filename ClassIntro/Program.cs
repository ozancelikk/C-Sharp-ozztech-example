using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Ozan";
            int yas = 20;

            kurs kurs1 = new kurs();
            kurs1.kursadi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeorani = 68;

            kurs kurs2 = new kurs();
            kurs2.kursadi = "C++";
            kurs2.Egitmen = "Necla Çaylak";
            kurs2.izlenmeorani = 98;

            kurs kurs3 = new kurs();
            kurs3.kursadi = "Java";
            kurs3.Egitmen = "Ozan Çelik";
            kurs3.izlenmeorani = 77;

            // Console.WriteLine(kurs1.kursadi+" : "
            // +kurs1.Egitmen);
            kurs[] kurslar = new kurs[]
            {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursadi+" : "+ kurs.Egitmen);
            }


        }
    }

    class kurs
    {
        public string kursadi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeorani { get; set; }
    }
}
