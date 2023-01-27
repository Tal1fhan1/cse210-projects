using System.IO;

public class Save
{
    public string _filename = "";

    public Save()
    {
    }

    public void SaveToFile(List<string> _list1, List<string> _list2)
    {
       Console.WriteLine("What is the file name?");
       _filename = Console.ReadLine();
       Console.WriteLine("");

       using (StreamWriter outputFile = new StreamWriter(_filename))
       {
        {
            foreach(string entry1 in _list1)
            {
                outputFile.WriteLine($"{entry1}");
            }
            foreach(string entry2 in _list2)
            {
                outputFile.WriteLine($"{entry2} \n ");
            }
        }
       } 
    }
}