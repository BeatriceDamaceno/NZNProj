using NZNCase;
using System;
using System.Linq;

internal class Program
{

    
    public static void Main(string[] args)
    {
        string[] wordsFound;
        Console.WriteLine("Hello, World!");
        wordsFound = WordFinder.FindWords(Globals.targetString);
    }

}