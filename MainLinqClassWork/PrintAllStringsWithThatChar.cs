using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PrintAllStringsWithThatChar
{
    public void PrintWordsThatStartWithThatLetters()
    {
        Console.WriteLine("write me a sentance and later i print the words that start with letters of your choosing");
        List<string> sentance = Console.ReadLine().Split(' ').ToList();
        Console.WriteLine("give me two letters and i'll give you all the words that start with them, seperate them by space");
        List<string> letterList = Console.ReadLine().Split(' ').ToList();
        List<char> charLetterList = new List<char>();
        foreach (string letter in letterList)
        {
            char letterChar = char.Parse(letter);
            charLetterList.Add(letterChar);
        }
        char a = charLetterList[0];
        char b = charLetterList[1];
        List<string> listAB = sentance.Where(s => s.StartsWith(a) || s.StartsWith(b)).ToList();
        foreach (var item in listAB)
        {
            Console.WriteLine(item);
        }
    }
}