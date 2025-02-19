using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Name = "Laptop", Price = 1200 },
                new Product { Name = "Phone", Price = 800 }
            };
        }
    }
}