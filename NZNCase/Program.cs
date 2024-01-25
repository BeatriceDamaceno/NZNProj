using NZNCase;
using System;
using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Aguarde, o programa está sendo executado. A busca de palavras é baseada no dicionário da IME USP, versão sem acentos.");

        List<string> wordsFound = new List<string>();
        wordsFound = WordHandler.FindWords(Globals.targetString);
        wordsFound = WordHandler.RemoveRepeats(wordsFound);
        wordsFound = WordHandler.OrderWords(wordsFound);

        Console.WriteLine("As seguintes palavras foram encontradas:");
        foreach (string word in wordsFound)
        {
            Console.WriteLine(word);
        }
        Console.ReadLine();
    }

}