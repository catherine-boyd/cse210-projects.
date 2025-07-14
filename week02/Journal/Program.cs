using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
       
        Journal journal = new Journal();
        PromptsGenerator prompts = new PromptsGenerator();
        Menu menu = new Menu();
        while (true)
        {
            menu.showMenu();
            Console.Write("Choose an option: ");
            int option = int.Parse(Console.ReadLine());
            if (option == 0)
            {
                break;
            }
            switch (option)
            {
                case 1:
                    string promptText = prompts.GetRandomPrompt();
                    Console.Write($"{promptText}");
                    string entryText = Console.ReadLine();
                    Entry entry = new Entry();
                    entry._promptText = promptText;
                    entry._entryText = entryText;
                    entry._date = new DateOnly().ToString();
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry successfully added.");
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Provide a file name to save your entry: ");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    break;
                case 4:
                    Console.WriteLine("Provide a file name to load your journal: ");
                    string file = Console.ReadLine();
                    journal.LoadFromFile(file);
                    journal.SaveToFile(file);
                    break;
                    
            }
        }
   
    }
}
class Menu
{
    public void showMenu()
    { 
        Console.WriteLine("1. Add new Entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("0. Quit program");
    }
    
}
class Journal
{
    private List<Entry> entries = new List<Entry>();
    private PromptsGenerator _promptGenerator = new PromptsGenerator();
    public void DisplayAll()
    {
        Console.WriteLine(entries.Count);
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Entry: {entry._promptText}, {entry._date}, {entry._entryText}");
        }
    }
    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file + ".csv"))
        {
            // Write header row
            writer.WriteLine("PromptText,EntryText,Date");
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{(entry._promptText)},{(entry._date)},{(entry._entryText)}");
            }
        }
        Console.WriteLine("File saved successfully.");
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                foreach (string field in fields)
                {
                    Console.Write(field + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
class Entry
{
   public string _entryText;
   public string _date;
   public string _promptText;
}
public class PromptsGenerator
{
    List<String> _prompts = new List<String>();
    public PromptsGenerator()
    {
        _prompts.AddRange([
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
         ]);
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count); //0 to 5(excluded)
        return _prompts[index];
    }
}
