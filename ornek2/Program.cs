using System;

namespace ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - kendini tekrarlama!
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGiris = true;
            double dolardun = 7.35;
            double dolarbugun = 7.45;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("eşittir butonu");
            }


            if (sistemeGiris== true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);



        }
    }
}
