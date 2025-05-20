using System;

class Program
{
    // 1. Función: Muestra un mensaje de bienvenida
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // 2. Función: Pide y devuelve el nombre del usuario
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // 3. Función: Pide y devuelve el número favorito del usuario
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // 4. Función: Devuelve el cuadrado de un número
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // 5. Función: Muestra el resultado final
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

    // Función principal: llama a todas las funciones
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared);
    }
}