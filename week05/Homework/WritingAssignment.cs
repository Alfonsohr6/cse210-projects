
public class WritingAssignment : Assignment
{
    // Atributo específico: título de la tarea
    private string _title;

    // Constructor – llama al constructor base para nombre y tema
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Devuelve la información específica de una tarea de escritura
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

    // Como _studentName es privado en la clase base, creamos un método público para acceder
    public string GetStudentName()
    {
        return base.GetType().GetProperty("_studentName", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this) as string;
    }
}