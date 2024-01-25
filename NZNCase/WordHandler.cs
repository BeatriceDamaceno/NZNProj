using System;
using System.IO; 

namespace NZNCase
{
    public class WordHandler
    {
        public static List<String> FindWords(string source)
        {
            string[] dictionary = { }; 
            dictionary = ConfigDictionary(dictionary);

            List<string> validWords = new List<string>();

            for (int i = 0; i < source.Length; i++)
            {
                for (int j = i + 1; j <= source.Length; j++)
                {
                    string substring = source.Substring(i, j - i);

                    if (dictionary.Contains(substring))
                    {
                        validWords.Add(substring);
                    }
                }
            }
            return validWords;
        }

        public static string[] ConfigDictionary (string[] dictionary)
        {
            dictionary = File.ReadAllLines(Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName).ToString(), "portuguese.txt"));
            dictionary = dictionary.Where(word => word.Length > 1 && !word.Contains("-")).ToArray();

            return dictionary;
        }

        public static List<string> OrderWords(List<string> wordsFound)
        {
            wordsFound = wordsFound.OrderByDescending(word => word.Length).ToList();
            return wordsFound;
        }

        public static List<string> RemoveRepeats(List<string> wordsFound)
        {
            wordsFound = wordsFound.GroupBy(word => word)
                .Where(group => group.Count()  > 0)
                .Select(group => group.Key)
                .ToList();

            return wordsFound;
        }

        public static string FindLargestWord(List<string> foundWords)
        {
            foundWords = foundWords.OrderByDescending(word => word.Length).ToList();
            return foundWords.FirstOrDefault().ToString();
        }
    }
}