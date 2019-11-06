using System;
using System.Collections.Generic;
using System.Linq;

namespace Roboto_VideoMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            new UserInput();
            Console.ReadKey();
        }

        class UserInput
        {
            public UserInput()
            {
                SearchTerm = AskAndReturnSearchTerm();
                SearchPrefix = AskAndReturnSearchPrefix();
            }

            private Dictionary<string, string> prefixes = new Dictionary<string, string>()
            {
                { "0", "Who is" },
                { "1", "What is" },
                { "2", "The History of" }

            };
            private string AskAndReturnSearchTerm()
            {
                Console.Write("Type a Wikipedia Search Term: ");
                var searchTerm = Console.ReadLine();
                return searchTerm;
            }
            private string AskAndReturnSearchPrefix()
            {
                foreach (var prefix in prefixes)
                {
                    Console.WriteLine(string.Format("\t{0}:{1}", prefix.Key, prefix.Value));
                }
                Console.WriteLine("Press any of the folowing prefix keys to proceed, and any other key will cancel the operation");

                var selectedPrefixKey = Console.ReadKey().KeyChar.ToString();
                var selectedPrefix = (prefixes.Keys.Contains(selectedPrefixKey)) ? prefixes[selectedPrefixKey] : throw new KeyNotFoundException("\n\n\nNo valid prefix key was pressed, please press a valid one !\n\n\n"); 
                return selectedPrefix;

            }

            public string SearchTerm { get; private set; }
            public string SearchPrefix { get; private set; }
        }

    }
}
