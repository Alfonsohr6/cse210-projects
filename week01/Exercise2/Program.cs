using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedimos el porcentaje de calificación
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter;
        string sign = "";

        // Determinamos la letra de la calificación
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determinamos el signo (+ o -), excepto para A+, F+, F-
        if (letter != "A" && letter != "F")
        {
            int lastDigit = grade % 10; // Obtenemos el último dígito

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Mostramos el resultado final
        Console.WriteLine($"Your grade is {letter}{sign}.");

        // Verificamos si pasó el curso
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You didn't pass this time. Keep trying next time!");
        }
    }
}