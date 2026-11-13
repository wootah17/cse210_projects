public class Reference
{
    public string Book{ get; set; }
    public int Chapter{ get; set; }
    public int Verse{ get; set; }

    public int EndVerse{ get; set; }

    public Reference(string _book, int _chapter, int _verse)
{
    this.Book = _book;
    this.Chapter = _chapter;;
    this.Verse = _verse;

}

    public Reference(string _book, int _chapter, int _verse, int _endVerse)
    {
        this.Book = _book;
        this.Chapter = _chapter;
        this.Verse = _verse;
        this.EndVerse = _endVerse;
    }

    public string GetDisplayText()
    {
        if (Verse == EndVerse)
        {
            return $"{Book} {Chapter}:{Verse}";
        }
        return $"{Book} {Chapter}:{Verse}-{EndVerse}";
    }
}