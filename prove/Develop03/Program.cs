using System;

class Program
{
    //My program exceeds the core requirements because it works with a library of scrptures rather than a single one. 
    //It also chooses scriptures at random to present to the user.
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.GetScriptureVerses();
        scripture.GetScriptureReferences();

        Word word = new Word();
        word.GetVersesToSplit();
        word.GetWordsInVerse();
        word.GetUsedIndexes();

        Reference reference1 = new Reference();
        reference1.SetBook("Moses");
        reference1.SetChapter(1);
        reference1.SetVerseNumber(39);
        scripture.GetScriptureReferences().Add(reference1.CompileReference());

        Reference reference2 = new Reference();
        reference2.SetBook("2 Nephi");
        reference2.SetChapter(2);
        reference2.SetVerseNumber(25);
        scripture.GetScriptureReferences().Add(reference2.CompileReference());

        Reference reference3 = new Reference();
        reference3.SetBook("1 Nephi");
        reference3.SetChapter(3);
        reference3.SetVerseNumber(7);
        scripture.GetScriptureReferences().Add(reference3.CompileReference());

        Reference reference4 = new Reference(40, 41);
        reference4.SetBook("Mosiah");
        reference4.SetChapter(2);
        reference4.GetVerseNumber();
        scripture.GetScriptureReferences().Add(reference4.CompileReference());

        Reference reference5 = new Reference();
        reference5.SetBook("Matthew");
        reference5.SetChapter(10);
        reference5.SetVerseNumber(39);
        scripture.GetScriptureReferences().Add(reference5.CompileReference());

        Reference reference6 = new Reference(28, 30);
        reference6.SetBook("Matthew");
        reference6.SetChapter(11);
        reference6.GetVerseNumber(); 
        scripture.GetScriptureReferences().Add(reference6.CompileReference());                       

        Console.Clear();

        scripture.DisplayScripture();
        Console.WriteLine();
        
        Console.Write("Press enter to continue or type 'quit' to finish: ");
        string answer = Console.ReadLine();
        
        Console.Clear();
        word.GetVersesToSplit().Add(scripture.GetRandomVerse());
        word.SplitWords();
        
        while (answer != "quit")
        {
            Console.Write($"{scripture.GetReferenceToVerse()} ");
            word.HideRandomWords();
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();
            Console.Clear();
            if (word.GetUsedIndexes().Count() == word.GetWordsInVerse().Count())
            {
                answer = "quit";
            }
        }

    }
}