using Task1.Interfaces;

namespace Task1.Models;

public class Document : ISearchable
{
    public string Title { get; set; }
    public string Content { get; set; }

    public bool Search(string word)
    {
        var isFound = Content.Contains(word,StringComparison.OrdinalIgnoreCase);
        return isFound;
    }
}
