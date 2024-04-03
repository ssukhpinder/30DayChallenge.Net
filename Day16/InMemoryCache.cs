using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day16
{

    public static class InMemoryCache
    {
        private static MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());
        private static ProductRepository _productRepository = new ProductRepository();
        public static Product GetProductById(int id)
        {
            if (!_cache.TryGetValue(id, out Product product))
            {
                Console.WriteLine("Fetching from database...");
                product = _productRepository.GetProductById(id);
                _cache.Set(id, product, TimeSpan.FromMinutes(30)); // Cache for 30 minutes
            }
            else
            {
                Console.WriteLine("Fetching from cache...");
            }

            return product;
        }
    }

    // Simulating a product repository
    public class ProductRepository
    {
        public Product GetProductById(int id)
        {
            // Simulate database access
            return new Product { Id = id, Name = $"Product {id}" };
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
