
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear primera instancia de Job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Crear segunda instancia de Job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Crear una instancia de Resume
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // Agregar los trabajos
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Mostrar el currículum completo
        myResume.Display();
    }
}