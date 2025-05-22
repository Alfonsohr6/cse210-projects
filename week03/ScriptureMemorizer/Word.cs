// Word.cs
public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    // Oculta la palabra
    public void Hide()
    {
        IsHidden = true;
    }

    // Devuelve la palabra oculta o visible
    public string GetDisplayText()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}