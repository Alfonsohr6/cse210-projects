public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    // Constructor: crea un producto con nombre, ID, precio y cantidad
    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Devuelve el nombre del producto
    public string GetName()
    {
        return _name;
    }

    // Devuelve el ID del producto
    public string GetProductId()
    {
        return _productId;
    }

    // Calcula el costo total según precio y cantidad
    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    // Devuelve etiqueta de embalaje: nombre e ID
    public string GetPackingLabel()
    {
        return $"{_name} ({_productId})";
    }
}