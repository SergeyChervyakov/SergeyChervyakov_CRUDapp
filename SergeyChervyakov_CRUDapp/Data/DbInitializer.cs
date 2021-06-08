using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SergeyChervyakov_CRUDapp.Models;

namespace SergeyChervyakov_CRUDapp.Data
{
    public class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            if (context.Clients.Any())
            {
                return;   // DB has been seeded
            }

            var clients = new Client[]
            {
                new Client{Name = "Sergey Chervyakov", Email = "sc@gmail.com", BirthDate = DateTime.Parse("2000-05-28"), Gender = Gender.Programmer},
                new Client{Name = "Roman Pushnitskij", Email = "rp@inbox.lv", BirthDate = DateTime.Parse("2002-10-01"), Gender = Gender.Male},
                new Client{Name = "Daniel Provejs", Email = "dp@mail.ru", BirthDate = DateTime.Parse("2001-09-03"), Gender = Gender.Male}

            };
            foreach (Client c in clients)
            {
                context.Clients.Add(c);
            }
            context.SaveChanges();

            var products = new Product[]
            {
                new Product{Code = 111, Title = "Apple", Price = 0.50M},
                new Product{Code = 222, Title = "Banana", Price = 0.70M},
                new Product{Code = 333, Title = "Pumpkin", Price = 2.15M},
                new Product{Code = 444, Title = "Cherry", Price = 1.20M},
                new Product{Code = 555, Title = "Water", Price = 0.80M},
                new Product{Code = 666, Title = "Bread", Price = 1.00M},
                new Product{Code = 777, Title = "Milk", Price = 0.99M},
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();

            var orders = new Order[]
            {
                new Order{
                    ClientId = clients.Single(c => c.Name == "Sergey Chervyakov").ID,
                    ProductId = products.Single(p => p.Code == 555).ID,
                    Quantity = 6,
                    Status = Status.Paid
                },
            };
            foreach (Order o in orders)
            {
                context.Orders.Add(o);
            }
            context.SaveChanges();
        }
    }
}
