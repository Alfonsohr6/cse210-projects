using System;

class Program
{
    static void Main(string[] args)
    {
        // Probar la clase base
        Console.WriteLine("Base Class Test:");
        Assignment simpleAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());

        // Probar la clase MathAssignment
        Console.WriteLine("\nMath Assignment Test:");
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Probar la clase WritingAssignment
        Console.WriteLine("\nWriting Assignment Test:");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}