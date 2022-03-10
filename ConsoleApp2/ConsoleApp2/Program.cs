using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product_1 = new Product()
            {
                Name = "Corey",
                BrandName = "Nomre 1",
                Price = 0.5
            };
            Product Product_2 = new Product()
            {
                Name = "Seker Tozu",
                BrandName = "Azer Seker",
                Price = 1.35
            };
            Product Product_3 = new Product()
            {
                Name = "Yumurta",
                BrandName = "Gilezi",
                Price = 0.17
            };
            Product Product_4 = new Product()
            {
                Name = "Cay",
                BrandName = "Azer Cay",
                Price = 5.50
            };
            Product Product_5 = new Product()
            {
                Name = "Makaron",
                BrandName = "Sarelle",
                Price = 0.90
            };
            Product Product_6 = new Product()
            {
                Name = "Salfetka",
                BrandName = "Sun",
                Price = 1.20
            };
            Product[] vitrin = {Product_1,Product_2,Product_3,Product_4,Product_5,Product_6};
            Selective(ref vitrin);
            foreach (var item in vitrin)
            {
                Console.WriteLine($"Name: {item.Name}\nBrandName: {item.BrandName}\nPrice: {item.Price} Azn");
                Console.WriteLine("===================");
            }
        }
        public static void Selective(ref Product[] vitrin, double minPrice = 0.90,double maxPrice = 1.35)
        {
            int total=0;
            for (int i = 0; i < vitrin.Length; i++)
            {
                if (vitrin[i].Price >= minPrice && vitrin[i].Price <= maxPrice)
                    total++;
            }
            Product[] vitrin2 = new Product[total];
            int a = 0;
            for (int i = 0; i < vitrin.Length; i++)
            {
                if (vitrin[i].Price >= minPrice && vitrin[i].Price <= maxPrice)
                {
                    vitrin2[a] = vitrin[i];
                    a++;
                }         
            }
            vitrin = vitrin2;
        }
    }
}
