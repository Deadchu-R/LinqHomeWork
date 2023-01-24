using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SentenceAverage
{

    public void GiveMeAverage()
    {
        Console.WriteLine("Write me a sentance and i'll give you the average word count");
        string inputString = Console.ReadLine();
        Console.WriteLine(inputString.Split(" ").ToList().Average(s => s.Length));

    }
}
