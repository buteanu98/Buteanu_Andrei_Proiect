using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buteanu_Andrei_Proiect.Models;


namespace Buteanu_Andrei_Proiect.Data
{
    public class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            context.Database.EnsureCreated();
            if (context.Games.Any())
            {
                return; // BD a fost creata anterior
            }
            var Games = new Game[]
            {
            new Game{Title="Cyberpunk 2077",Developer="CD Project Red",Price=Decimal.Parse("69.99")},
            new Game{Title="Assassin's Creed Valhalla",Developer="Ubisoft",Price=Decimal.Parse("59.99")},
            new Game{Title="God of War",Developer="Santa Monica",Price=Decimal.Parse("39.99")}
            };
            foreach (Game s in Games)
            {
                context.Games.Add(s);
            }
            context.SaveChanges();
            var customers = new Customer[]
            {
            new Customer{CustomerID=1050,Name="Popescu Marcela",BirthDate=DateTime.Parse("1979-09-01")},
            new Customer{CustomerID=1045,Name="Mihailescu Cornel",BirthDate=DateTime.Parse("1969-07-08")},
 };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
            var orders = new Order[]
            {
 new Order{GameID=1,CustomerID=1050},
 new Order{GameID=3,CustomerID=1045},
 new Order{GameID=1,CustomerID=1045},
 new Order{GameID=2,CustomerID=1050},
            };
            foreach (Order e in orders)
            {
                context.Orders.Add(e);
            }
            context.SaveChanges();
        }
    }
}
