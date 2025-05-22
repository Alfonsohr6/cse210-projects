// Sorry if there are comments in Spanish, but it's so I don't get lost in the code 
// and can understand what I was supposed to do in each part.
public class Fraction
{
    // Atributos privados (encapsulados)
    private int _numerator;
    private int _denominator;

    // Constructor sin parámetros: 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor con un parámetro: x/1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor con dos parámetros: x/y
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter y Setter para el numerador
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int value)
    {
        _numerator = value;
    }

    // Getter y Setter para el denominador
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int value)
    {
        if (value == 0)
            throw new ArgumentException("Denominator cannot be zero.");
        _denominator = value;
    }

    // Método para obtener la fracción como cadena
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Método para obtener el valor decimal
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}