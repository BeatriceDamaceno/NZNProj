using NZNCase;
using System;
using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Aguarde, o programa está sendo executado. A busca de palavras é baseada no dicionário da IME USP, versão sem acentos." + Environment.NewLine);

        List<string> foundWords = new List<string>();
        foundWords = WordHandler.FindWords(Globals.targetString);
        foundWords = WordHandler.RemoveRepeats(foundWords);
        foundWords = WordHandler.OrderWords(foundWords);

        Console.WriteLine("As seguintes palavras foram encontradas:");
        foreach (string word in foundWords)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("A maior palavra dessa lista é: " + WordHandler.FindLargestWord(foundWords) + ", com " + WordHandler.FindLargestWord(foundWords).Length + " caracteres." + Environment.NewLine);
        Console.WriteLine("A execução terminou, essa janela pode ser fechada.");

        Console.ReadLine();
    }

}