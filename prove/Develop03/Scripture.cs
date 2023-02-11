public class Scripture
{
    private List<string> _scriptureVerses = new List<string>();
    private List<string> _scriptureReferences = new List<string>();
    private string _randomVerse;
    private string _referenceToVerse;

    public Scripture()
    {
    }

    public Scripture(string verse)
    {
        _randomVerse = verse;
    }

    public Scripture(string verse, string reference)
    {
        _randomVerse = verse;
        _referenceToVerse = reference;
    }
    public List<string> GetScriptureVerses()
    {
        return _scriptureVerses;
    }
    public List<string> GetScriptureReferences()
    {
        return _scriptureReferences;
    }

    public string GetRandomVerse()
    {
        return _randomVerse;
    }
    public void SetRandomVerse(int indexNumber)
    {
        _randomVerse = _scriptureVerses[indexNumber];
    }
    public string GetReferenceToVerse()
    {
        return _referenceToVerse;
    }
    public void SetReferenceToVerse(int indexNumber)
    {
        _referenceToVerse = _scriptureReferences[indexNumber];
    }

    public void DisplayScripture()
    {
        _scriptureVerses.Add("For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
        _scriptureVerses.Add("Adam fell that men might be; and men are, that they might have joy.");
        _scriptureVerses.Add("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        _scriptureVerses.Add("O, all ye old men, and also ye young men, and you little children who can understand my words, for I have spoken plainly unto you that ye might understand, I pray that ye should awake to a remembrance of the awful situation of those that have fallen into transgression. And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");
        _scriptureVerses.Add("He that findeth his life shall lose it: and he that loseth his life for my sake shall find it.");
        _scriptureVerses.Add("Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.");
        
        Random randomNumbergenerator = new Random();
        int _commonIndex = randomNumbergenerator.Next(6);
        _randomVerse = _scriptureVerses[_commonIndex];
        _referenceToVerse = _scriptureReferences[_commonIndex];
        Console.WriteLine($"{_referenceToVerse} {_randomVerse}");
        SetRandomVerse(_commonIndex);
    }
}