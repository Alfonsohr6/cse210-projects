// Sorry if there are comments in Spanish, but it's so I don't get lost in the code 
// and can understand what I was supposed to do in each part.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Usar cada constructor y mostrar resultados
        Console.WriteLine("Testing constructors:");

        Fraction f1 = new Fraction();           // 1/1
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);          // 5/1
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);       // 3/4
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);       // 1/3
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Probar getters y setters
        Console.WriteLine("\nTesting getters and setters:");

        Fraction f5 = new Fraction();
        Console.WriteLine("Initial value: " + f5.GetFractionString());

        f5.SetNumerator(6);
        f5.SetDenominator(7);
        Console.WriteLine("New value: " + f5.GetFractionString());
        Console.WriteLine("Decimal value: " + f5.GetDecimalValue());
    }
}