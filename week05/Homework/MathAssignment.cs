
public class MathAssignment : Assignment
{
    // Atributos específicos de MathAssignment
    private string _textbookSection;
    private string _problems;

    // Constructor – llama al constructor base para los valores comunes
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Devuelve la información específica de una tarea de matemáticas
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}