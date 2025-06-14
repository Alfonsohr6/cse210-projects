public class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        // Este método puede ser sobreescrito por las clases derivadas
        return 0;
    }
}