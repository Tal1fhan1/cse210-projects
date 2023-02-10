public class Word
{
    public List<string> _versesToSplit;
    public List<string> _wordsInVerse;
    public List<int> _usedIndexes;
    private string _hiddenWord1;
    private string _hiddenWord2;
    private string _hiddenWord3;
    private string _randomWord1;
    private string _randomWord2;
    private string _randomWord3;


    public Word()
    {
    }

    public Word(string word1, string word2, string word3)
    {
        _randomWord1 = word1;
        _randomWord2 = word2;
        _randomWord3 = word3;
    }
    public string GetHiddenWord1()
    {
        return _hiddenWord1;
    }
    public void SetHiddenWord1(string word)
    {
        _hiddenWord1 = word;
    }
    public string GetHiddenWord2()
    {
        return _hiddenWord2;
    }
    public void SetHiddenWord2(string word)
    {
        _hiddenWord2 = word;
    }    
    public string GetHiddenWord3()
    {
        return _hiddenWord3;
    }
    public void SetHiddenWord3(string word)
    {
        _hiddenWord3 = word;
    }
    public string GetRandomWord1()
    {
        return _randomWord1;
    }
    public void SetRandomWord(int indexNumber)
    {
        int _randomIndex = indexNumber;
        _randomWord1 = _wordsInVerse[indexNumber];
    }
    public string GetRandomWord2()
    {
        return _randomWord2;
    }
    public void SetRandomWord2(int indexNumber)
    {
        int _randomIndex = indexNumber;
        _randomWord2 = _wordsInVerse[indexNumber];
    }
    public string GetRandomWord3()
    {
        return _randomWord3;
    }
    public void SetRandomWord3(int indexNumber)
    {
        int _randomIndex = indexNumber;
        _randomWord3 = _wordsInVerse[indexNumber];
    }
    public void SplitWords()
    {
        string[] words = _versesToSplit[0].Split(" ");
        foreach (string word in words)
        {
            _wordsInVerse.Add(word);   
        }
    }
    public void HideRandomWords()
    {   
        
        Random randomNumbergenerator1 = new Random();
        int indexNumber1 = randomNumbergenerator1.Next(_wordsInVerse.Count());
        _randomWord1 = _wordsInVerse[indexNumber1];
        if (_usedIndexes.Contains(indexNumber1) == false)
        {
            _usedIndexes.Add(indexNumber1);
        }
        else
        {
            while (_usedIndexes.Contains(indexNumber1) == true)
            {
                indexNumber1 = randomNumbergenerator1.Next(_wordsInVerse.Count());
                _randomWord1 = _wordsInVerse[indexNumber1];
            }
            _usedIndexes.Add(indexNumber1);
        }
        

        Random randomNumbergenerator2 = new Random();
        int indexNumber2 = randomNumbergenerator2.Next(_wordsInVerse.Count());
        _randomWord2 = _wordsInVerse[indexNumber2];
        if (_usedIndexes.Count() != _wordsInVerse.Count()-2)
        {
            if (_usedIndexes.Contains(indexNumber2) == false)
            {
                _usedIndexes.Add(indexNumber2);
            }
            else
            {
                while (_usedIndexes.Contains(indexNumber2) == true)
                {
                    indexNumber2 = randomNumbergenerator2.Next(_wordsInVerse.Count());
                    _randomWord2 = _wordsInVerse[indexNumber2];
                }
                _usedIndexes.Add(indexNumber2);
            }
        }
        
        foreach(char letter in _randomWord1)
        {
            string underscore = "_";
            _hiddenWord1 += underscore;
        }
        _wordsInVerse.RemoveAt(indexNumber1);
        _wordsInVerse.Insert(indexNumber1, _hiddenWord1);
        SetHiddenWord1("");     
        
        if (_usedIndexes.Count() != _wordsInVerse.Count()-1)
        {
            foreach(char letter in _randomWord2)
            {
                string underscore = "_";
                _hiddenWord2 += underscore;
            }
            _wordsInVerse.RemoveAt(indexNumber2);
            _wordsInVerse.Insert(indexNumber2, _hiddenWord2);
            SetHiddenWord2("");
        }

        foreach (string word in _wordsInVerse)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine("");
    }
}