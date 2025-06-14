public class Customer
{
    private string _name;
    private Address _address;

    // Constructor: recibe nombre y dirección del cliente
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Devuelve el nombre del cliente
    public string GetName()
    {
        return _name;
    }

    // Devuelve la dirección del cliente
    public Address GetAddress()
    {
        return _address;
    }

    // Verifica si el cliente vive en USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Devuelve toda la dirección como cadena
    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
}