using System;
using System.Collections.Generic;
using System.IO;

namespace FileManipulationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @".\List.txt";
            List<string> notes = new List<string>();
            string userInput = "";
            string addedNote = "";

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            do
            {
                Console.WriteLine("Would you like to add any notes (Y/N) ?");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "y")
                {
                    Console.WriteLine("Please enter your note:");
                    addedNote = Console.ReadLine();
                    notes.Add(addedNote);

                    using (StreamWriter writer = File.AppendText(path))
                    {
                        notes.ForEach(writer.WriteLine);
                    }
                }
                else
                {
                    Console.WriteLine("These are the notes from yor file");
                    foreach (string line in File.ReadAllLines(path))
                    {
                        Console.WriteLine(line);
                    }

                    Console.WriteLine("Thank you! Goodbye!");
                    Console.ReadLine();
                    break;
                }

            } while (true);



        }
    }
}
