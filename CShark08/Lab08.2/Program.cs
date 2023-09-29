using Lab08._2;

internal class Program
{
    private static void Main(string[] args)
    {
        var customers = new Customer[]
        {
            new Customer{Id = 5, Name = "Chicken"},
            new Customer{Id = 4, Name = "Kraken"},
            new Customer{Id = 3, Name = "ScaletKing"},
            new Customer{Id = 2, Name = "TheVoid"},
            new Customer{Id = 1, Name = "TheFlame"},

        };

        var orders = new Order[]
        {
            new Order{Id = 1, Product = "chicken"},
            new Order{Id = 2, Product = "ga"},
            new Order{Id = 3, Product = "Cat"},
            new Order{Id = 4, Product = "meo"},
            new Order{Id = 5, Product = "voi"},
        };

        var query = from c in customers join o in orders on c.Id equals o.Id select new { c.Name, o.Product };

        foreach(var e in query)
        {
            Console.WriteLine("{0} bought {1}", e.Name, e.Product);
        }
    }
}