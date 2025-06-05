
public class Assignment
{
    // Atributos privados (encapsulamiento)
    private string _studentName;
    private string _topic;

    // Constructor – recibe nombre y tema
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Método compartido: devuelve un resumen con nombre y tema
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}