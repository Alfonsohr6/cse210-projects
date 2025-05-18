
public class Job
{
    // Atributos
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Método que devuelve la información como cadena
    public string Display()
    {
        return $"{_jobTitle} ({_company}) {_startYear}-{_endYear}";
    }
}