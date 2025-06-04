using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear lista de videos
        List<Video> videos = new List<Video>();

        // Primer video
        Video video1 = new Video();
        video1.Title = "Cómo programar en C#";
        video1.Author = "Tutoriales CSharp";
        video1.LengthInSeconds = 600;

        video1.AddComment(new Comment("Carlos", "¡Excelente explicación!"));
        video1.AddComment(new Comment("Luis", "Muy útil, gracias."));
        video1.AddComment(new Comment("Ana", "Me ayudó mucho."));

        // Segundo video
        Video video2 = new Video();
        video2.Title = "Aprende POO en 10 minutos";
        video2.Author = "DevTips";
        video2.LengthInSeconds = 620;

        video2.AddComment(new Comment("Juan", "Buen resumen."));
        video2.AddComment(new Comment("María", "Demasiado rápido, pero interesante."));
        video2.AddComment(new Comment("Pedro", "Lo recomiendo."));
        video2.AddComment(new Comment("Sofia", "Gracias por el contenido"));

        // Tercer video
        Video video3 = new Video();
        video3.Title = "Top 5 Frameworks en C#";
        video3.Author = "TechTalk";
        video3.LengthInSeconds = 480;

        video3.AddComment(new Comment("Lucas", "Faltó mencionar MAUI."));
        video3.AddComment(new Comment("Eduardo", "Buena comparativa."));
        video3.AddComment(new Comment("Daniela", "Interesante. Gracias"));

        // Cuarto video (opcional)
        Video video4 = new Video();
        video4.Title = "Cómo usar GitHub con Visual Studio";
        video4.Author = "CodeAndShare";
        video4.LengthInSeconds = 720;

        video4.AddComment(new Comment("Camila", "Me ayudó mucho."));
        video4.AddComment(new Comment("Mario", "Muy claro."));
        video4.AddComment(new Comment("Valeria", "Ahora entiendo mejor Git."));

        // Agregar videos a la lista
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        // Descomenta esta línea si usaste el video4
        // videos.Add(video4);

        // Mostrar información de los videos
        foreach (var video in videos)
        {
            Console.WriteLine($"\nTítulo: {video.Title}");
            Console.WriteLine($"Autor: {video.Author}");
            Console.WriteLine($"Duración: {video.LengthInSeconds} segundos");
            Console.WriteLine($"Número de comentarios: {video.GetCommentCount()}");
            Console.WriteLine("Comentarios:");

            video.DisplayComments();

            Console.WriteLine(new string('-', 40)); // Separador
        }
    }
}