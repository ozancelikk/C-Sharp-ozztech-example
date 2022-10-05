using System;

namespace _13._09._2022ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ana ekrana hoşgeldin eleman girecek misin evet/hayır");
            string eleman = Console.ReadLine();
            if (eleman == "evet" || eleman == "Evet" || eleman == "EVET") 
            {
                int toplam = 0;
            etiket:
                Console.WriteLine("kaç adet eleman gireceksin");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam =toplam +sayi;
                for (int i = 1; i <= sayi; i++)
                {
                    Calisan calisan = new Calisan();
                    Console.WriteLine("Çalışan adını giriniz");
                    calisan.calisanad = Console.ReadLine();
                    Console.WriteLine("Çalışan soyadını giriniz");
                    calisan.calisansoyad = Console.ReadLine();
                    Console.WriteLine("Çalışan yaşını giriniz");
                    calisan.yas =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Çalışan bolumunu giriniz giriniz");
                    calisan.bolum = Console.ReadLine();
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("--------------------------------------");
                    Calisan[] calisans = new Calisan[] { calisan };

                }
                Console.WriteLine("Yeni eleman girmek istiyor musunuz evet/hayır");
                string cevap = Console.ReadLine();
                if (cevap=="evet")
                {
                    goto etiket;
                }
                else if(cevap=="hayir")
                {                 
                Console.WriteLine("elinizdeki eleman sayısı: "+toplam);
                }
            }
            else
            {
                Console.WriteLine("Programdan çıkış yaptınız"); 
            }
        }
        class Calisan
        {
            public string calisanad { get; set; }
            public string calisansoyad { get; set; }
            public int yas { get; set; }
            public string bolum { get; set; }
        } 
    }
}
