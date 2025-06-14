public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor: crea una nueva dirección
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Verifica si la dirección es de USA
    public bool IsInUSA()
    {
        string lowerCountry = _country.ToLower();
        return lowerCountry == "usa" || 
               lowerCountry == "united states" || 
               lowerCountry == "united states of america";
    }

    // Devuelve toda la dirección como cadena
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}