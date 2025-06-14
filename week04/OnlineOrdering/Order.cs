using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Agrega un producto a la lista
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calcula el costo total de todos los productos + envío
    public double GetTotalCost()
    {
        double total = 0;

        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        // Determinar costo de envío según si vive en USA o no
        double shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    // Genera una etiqueta con nombre e ID de cada producto
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"- {product.GetPackingLabel()}\n";
        }
        return label.Trim(); // Elimina el último salto de línea
    }

    // Devuelve la información de envío con nombre y dirección
    public string GetShippingLabel()
    {
        return $"Customer: {_customer.GetName()}\n{_customer.GetFullAddress()}";
    }
}