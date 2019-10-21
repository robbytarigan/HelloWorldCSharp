using System;
using System.Collections.Generic;

namespace UsingDeclaration
{
    class Program
    {
        static int WriteLinesToFile(IEnumerable<string> lines)
        {
            using var file = new System.IO.StreamWriter("WriteLines2.txt");
            // Notice how we declare skippedLines after the using statement.
            int skippedLines = 0;
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }
            // Notice how skippedLines is in scope here.
            return skippedLines;
            // file is disposed here
        }

        static void Main(string[] args)
        {
            WriteLinesToFile(new[] { "Naruto", "Uzumaki", "Boruto", "Hinata", "Mawari", "Second", "Seventh"});

            Console.WriteLine("Write to WriteLines2.txt");
        }
    }
}
