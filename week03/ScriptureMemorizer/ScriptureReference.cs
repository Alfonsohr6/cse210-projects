// ScriptureReference.cs
public class ScriptureReference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; } // Nullable para versículos únicos

    // Constructor para versículo único (ej: John 3:16)
    public ScriptureReference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = null;
    }

    // Constructor para rango de versículos (ej: Proverbs 3:5-6)
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (!EndVerse.HasValue)
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
        return $"{Book} {Chapter}:{StartVerse}-{EndVerse.Value}";
    }
}