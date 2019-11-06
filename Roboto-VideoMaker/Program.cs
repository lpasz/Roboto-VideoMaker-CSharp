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
                    Console.WriteLine(string.Format("{0}:{1}", prefix.Key, prefix.Value));
                }
                Console.Write("Press any of the folowing keys to proceed, ");
                prefixes.Keys.ToList().ForEach(p => Console.Write(string.Format("{0} ", p)));
                Console.WriteLine();

                var selectedPrefixKey = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine();
                while (!prefixes.Keys.Contains(selectedPrefixKey))
                {
                    Console.Write("Not a valid key. Try");
                    prefixes.Keys.ToList().ForEach(p => Console.Write(string.Format("{0} ",p)));
                    Console.WriteLine();
                    selectedPrefixKey = Console.ReadKey().KeyChar.ToString();
                }

                var selectedPrefix = prefixes[selectedPrefixKey]; 
                return selectedPrefix;
            }

            public string SearchTerm { get; private set; }
            public string SearchPrefix { get; private set; }
        }

    }
}
