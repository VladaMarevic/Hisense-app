using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Interfaces // govori koje funkcije imamo
{
    public interface IRepository
    {
        List<Product>? GetAll();
        Product? GetBySifra(string sifra);
        bool Create(Product product);
        bool Update(Product product);
        bool Delete(string sifra);
    }
}
