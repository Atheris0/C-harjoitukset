using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanalaskuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the name of the file: ");
            string fileName = Console.ReadLine();
            Checker file1 = new Checker(fileName);

            Console.WriteLine("Words in file: ");
            Console.WriteLine(file1.GetCounter());

            Console.WriteLine("Characters in file: ");
            Console.WriteLine(file1.GetCharacters());

            while (true)
            {
                Console.Write("Give a word (empty word ends): ");
                string searchWord = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(searchWord))
                    break;

                int wordCount = file1.SearchWords(searchWord);
                Console.WriteLine($"Word {searchWord} occurs {wordCount} times.");
            }

            Console.ReadLine();
        }
    }
}
