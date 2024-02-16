using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Product> _products1 = new List<Product>
        {
            new Product("Headphones", 0, 65.25f, 2),
            new Product("Laptop", 1, 1200.25f, 1),
            new Product("Keyboard", 2, 650.99f, 1),
        };
        List<Product> _products2 = new List<Product>
        {
            new Product("Headphones", 3, 65.25f, 1),
            new Product("Mouse", 4, 59.99f, 1),
            new Product("Monitor", 5, 500.25f, 2)
        };

        Customer _customer1 = 
        new Customer("John Doe", new Address("123 Main St", "Idaho Falls", "Idaho", "USA"));
        Order order1 = new Order(_products1, _customer1);
        order1.ShowShippingLabel();
        order1.ShowPackingLabel();

        Customer _customer2 = 
        new Customer("Frank Smith", new Address("456 Elm St", "Mexico City", "Mexico City", "Mexico"));
        Order order2 = new Order(_products2, _customer2);
        order2.ShowShippingLabel();
        order2.ShowPackingLabel();
    }
}