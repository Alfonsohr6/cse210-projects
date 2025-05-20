using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Pedimos el nombre
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // 2. Pedimos el apellido
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // 3. Mostramos el mensaje formateado
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
    }
}