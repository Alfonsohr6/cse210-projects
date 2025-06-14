using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear listado de formas
        List<Shape> shapes = new List<Shape>();

        // Agregar cuadrados, rectángulos y círculos
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 6, 4));
        shapes.Add(new Circle("Green", 3));

        // Mostrar información de todas las formas
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Área: {shape.GetArea()}\n");
        }
    }
}