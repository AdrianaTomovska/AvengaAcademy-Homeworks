using System.Text.RegularExpressions;
using Task1.Interfaces;

namespace Task1.Models;

internal class WebPage : ISearchable
{
    public string Url { get; set; }
    public string Html { get; set; }

    public bool Search(string word)
    {
        string plainText = Regex.Replace(Html, "<.*?>", "");
        return plainText.Contains(word, StringComparison.OrdinalIgnoreCase);
    }
}
