public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        //Adding the newEntry to the _entries list.
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {   
        //Iterating through the _entries list
        foreach (Entry i in _entries)
        {   
            //Calling the Display function in Entry
            i.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            //Iterating through each Entry in _entries and writing it in the file
            foreach (Entry i in _entries)
            {
                outputFile.WriteLine($"{i._date}|{i._promptText}|{i._entryText}|{i._dayRating}");
            }
        }
    }

    public List<Entry> LoadFromFile(string file)
    {   
        List<Entry> newEntries = new List<Entry>();

        //Collecting the strings from the file
        string[] lines = System.IO.File.ReadAllLines(file);

        //Separate the strings and set them as variables
        foreach (string line in lines)
        {
            //Separating the strings into variables
            string[] parts = line.Split("|");

            Entry newEntry = new Entry();

            //Setting the new variables
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            newEntry._dayRating = int.Parse(parts[3]);

            //Adding newEntry to the newEntries list
            newEntries.Add(newEntry);
        }

        //Return the newEntries list as an List<Entry> object
        return newEntries;
    }
}