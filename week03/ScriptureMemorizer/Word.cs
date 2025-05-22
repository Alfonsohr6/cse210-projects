// Word.cs
// Sorry if there are comments in Spanish, but it's so I don't get lost in the code 
// and can understand what I was supposed to do in each part.
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