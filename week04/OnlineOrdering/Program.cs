using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear clientes con sus direcciones
        var address1 = new Address("Main St", "Salt Lake City", "UT", "USA");
        var customer1 = new Customer("Carlos Mendoza", address1);

        var address2 = new Address("Queen St", "Auckland", "Auckland", "New Zealand");
        var customer2 = new Customer("Lucas Burton", address2);

        // Crear pedido 1
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LT-202", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS-012", 19.99, 2));

        // Crear pedido 2
        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "TB-887", 299.99, 1));
        order2.AddProduct(new Product("Charger", "CH-001", 25.00, 1));

        // Mostrar información de los pedidos (ahora en inglés)
        Console.WriteLine("📦 Order Details 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine("📦 Order Details 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}