public class Reference
{
    private string _book;

    private int _chapter;

    private string _verseNumber;

    public Reference()
    {
    }

    public Reference(int firstVerseNumber, int lastVerseNumber)
    {
        _verseNumber = $"{firstVerseNumber}-{lastVerseNumber}";
    }

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public string GetVerseNumber()
    {
        return _verseNumber;
    }

    public void SetVerseNumber(int verseNumber)
    {
        _verseNumber = $"{verseNumber}";
    }

    public string CompileReference()
    {
       return $"{_book} {_chapter}:{_verseNumber}";
    }

}




