using System;
using System.Collections.Generic;
using Infrastructure.Entities;

namespace Infrastructure
{
    public static class StaticDB
    {
        public static List<Product> Products { get; set; } = new List<Product>();
        // pravimo InMemory DB

        static StaticDB()
        {
            //LoadData();
            Product p1 = new Product("HLKDFJLJ", "Model 1", 123, 123, 123);
            Products.Add(p1);
        }

        public static void LoadData()
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < 10; i++)
            {
                var productCode = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());

                var product = new Product(productCode, "Model" + random.Next(1, 100), random.Next(50, 200), random.Next(50, 200), random.Next(50, 200));
                //{
                //    productCode,
                //    ModelProizvoda = "Model" + random.Next(1, 100),
                //    SirinaUredjaja = random.Next(50, 200),
                //    VisinaUredjaja = random.Next(50, 200),
                //    DubinaUredjaja = random.Next(20, 100)
                //};

                Products.Add(product);
            }
        }
    }
}

