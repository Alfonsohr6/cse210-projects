using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        // Validar que la lista no esté vacía
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // Calcular suma
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Calcular promedio
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Encontrar el número más grande
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        // (Stretch Challenge) Menor número positivo
        List<int> positiveNumbers = numbers.FindAll(n => n > 0);
        if (positiveNumbers.Count > 0)
        {
            int minPositive = positiveNumbers.Min();
            Console.WriteLine($"The smallest positive number is: {minPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers.");
        }

        // (Stretch Challenge) Ordenar y mostrar la lista
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}