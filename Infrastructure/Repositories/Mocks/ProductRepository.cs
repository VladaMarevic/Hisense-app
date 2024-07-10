using Infrastructure.Entities;
using Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Mocks
{
    public class ProductRepository : IRepository
    {
        public List<Product> GetAll()
        {
            return StaticDB.Products;
        }

        public Product? GetBySifra(string sifra)
        {
            return StaticDB.Products.FirstOrDefault(product => product.SifraProizvoda.Equals(sifra));
        }// za svaki element tipa prozivod proveri da li taj proizvod ima sifru = sifri koja mi je data
         // dohvata se samo prvi proizvod ako ih vrati vise

        public bool Create(Product product)
        {
            try
            {
                StaticDB.Products.Add(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Product data)
        {
            Product? product = GetBySifra(data.SifraProizvoda);
            // dohvati proizvod tj product ako postoji

            if (product == null)
            {
                return false;
            }
            try
            {
                StaticDB.Products.Remove(product);
                StaticDB.Products.Add(data);
                return true;
                //izbaci stari proizvpd dodaj novi
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(String sifra)
        {
            Product? product = GetBySifra(sifra);

            if (product == null)
            {
                return false;
            }
            try
            {
                StaticDB.Products.Remove(product);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
