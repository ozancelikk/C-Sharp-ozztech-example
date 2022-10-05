using System;

namespace ClassIntro2
{
    class Program
    {
        static void Main(string[] args)
        {

            Products product1 = new Products();
            product1.urunad = "Telefon";
            product1.aciklama = "Iphone 13";
            product1.fiyat = 56000;

            Products product2 = new Products();
            product2.urunad = "Bilgisayar";
            product2.aciklama = "Monster";
            product2.fiyat = 20000;

            Products product3 = new Products();
            product3.urunad = "Televizyon";
            product3.aciklama = "LG QLED";
            product3.fiyat = 32000;


            Products[] product = new Products[] {product1,product2,product3 };




            foreach (var urun in product)
            {
                Console.WriteLine(urun.urunad+" : "+urun.fiyat);
            }




        }


        class Products
        {
            public string urunad { get; set; }
            public string aciklama { get; set; }
            public int fiyat { get; set; }
        }
    }
}
