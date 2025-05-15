public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response, string date = null)
    {
        Prompt = prompt;
        Response = response;
        Date = date ?? DateTime.Now.ToShortDateString();
    }

    public string ToCsvString()
    {
        return $"{Date}~|~{Prompt}~|~{Response}";
    }

    public static Entry FromCsvLine(string line)
    {
        string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
        if (parts.Length == 3)
        {
            return new Entry(parts[1], parts[2], parts[0]);
        }
        return null;
    }
}