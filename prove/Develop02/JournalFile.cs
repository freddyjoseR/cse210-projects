using System;
using System.IO;

class JournalFile
{
    public string _filename;
    
    public void LoadFile(List<string> listofentries) {

        Console.WriteLine("Enter file name ");
        string newFile = Console.ReadLine(); 
        _filename = newFile;
        listofentries.Clear();
        string[] lines = System.IO.File.ReadAllLines(_filename); 
        foreach (string line in lines) 
        {

            listofentries.Add(line);

        }
    }

    public void saveFile(List<string> entries)
    {

        Console.WriteLine("Enter file name");
        string filename = Console.ReadLine();
        _filename = filename;

        
        using (StreamWriter textfile = new StreamWriter(_filename, true))
        {
            foreach (string line in entries)
                textfile.WriteLine(line);
            textfile.Flush(); 
            
        }
    }
}
