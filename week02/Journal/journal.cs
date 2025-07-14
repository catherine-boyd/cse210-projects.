using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromptGenerator;

namespace journal
{
    internal class Journal
    {
        private List<entry.Entry> entries = new List<entry.Entry>();
        private PromptGenerator.PromptsGenerator _promptGenerator = new PromptGenerator.PromptsGenerator();
        public void DisplayAll()
        {
            Console.WriteLine(entries.Count);
            foreach (entry.Entry entry in entries)
            {
                Console.WriteLine($"Entry: {entry._promptText}, {entry._date}, {entry._entryText}");
            }
        }
        public void AddEntry(entry.Entry newEntry)
        {
            entries.Add(newEntry);
        }
        public void SaveToFile(string file)
        {
            using (StreamWriter writer = new StreamWriter(file + ".csv"))
            {
                // Write header row
                writer.WriteLine("PromptText,EntryText,Date");
                foreach (entry.Entry entry in entries)
                {
                    writer.WriteLine($"{(entry._promptText)},{(entry._entryText)},{(entry._date)}");
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
}
