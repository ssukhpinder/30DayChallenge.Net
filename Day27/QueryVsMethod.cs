using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day27
{

    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
    public static class QueryVsMethod
    {
        static List<Item> items = new List<Item>
        {
            new Item { Id = 1, Name = "Item1", IsActive = true },
            new Item { Id = 2, Name = "Item2", IsActive = false },
            new Item { Id = 3, Name = "Item3", IsActive = true }
        };
        public static void QuerySyntax()
        {
            // Method Syntax
            var methodSyntaxQuery = items.Where(item => item.IsActive)
                                          .Select(item => new { item.Name, item.Id });
            Console.WriteLine("Method Syntax Results:");
            foreach (var item in methodSyntaxQuery)
            {
                Console.WriteLine($"Name: {item.Name}, Id: {item.Id}");
            }
        }
        public static void MethodSyntax()
        {
            // Query Syntax
            var querySyntaxQuery = from item in items
                                   where item.IsActive
                                   select new { item.Name, item.Id };
            Console.WriteLine("\nQuery Syntax Results:");
            foreach (var item in querySyntaxQuery)
            {
                Console.WriteLine($"Name: {item.Name}, Id: {item.Id}");
            }
        }
    }
}
