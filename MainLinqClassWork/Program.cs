
using System.ComponentModel;
using System.Runtime.InteropServices;




class Program
{
    static public void Main(String[] args)
    {
       // DistinctAndAscending distinctAndAscending = new DistinctAndAscending();
      //  distinctAndAscending.MakeListDistinctAndAscending();

       // SentanceAverage sentanceAverage = new SentanceAverage();
       // sentanceAverage.GiveMeAverage();

        PrintAllStringsWithThatChar printStringWithChar = new PrintAllStringsWithThatChar();
        printStringWithChar.PrintWordsThatStartWithThatLetters();

        StudentAndGrade studentsAndGrades = new StudentAndGrade();

        List<Student> students = new List<Student>
        {
        new Student { FirstName = "Daniel", ID = 101 }, // annoymous object
         new Student { FirstName = "Amit", ID = 0 }, // annoymous object,
          new Student { FirstName = "Roee", ID = 206697450 } // annoymous object
        };

        List<Grade> grades = new List<Grade>
        {
            new Grade { ID = 101, grade = 99 }, // annoymous object
            new Grade { ID = 0, grade = 1 }, // annoymous object,
            new Grade { ID = 206697450, grade = 110 } // annoymous object
        };
        studentsAndGrades.CombineStudnetAndGradeList(students, grades);

       

    }





   
       

}



public class DistinctAndAscending
{
    List<int> _listInt1 = new List<int>()
    {
        1,2,7000,5,7,100,10,13
    };

    
   public void MakeListDistinctAndAscending()
   {
       Console.WriteLine("Please give me a list of numbers seperated by space, i will order them by ascending");
        string userString = Console.ReadLine();
        
        List<string> userList = new (userString.Split(' '));
        List<int> listInt = new List<int>();
        foreach (string item in userList)
        {
            int UserNum = int.Parse(item);
            listInt.Add(UserNum);
        }

        var distinctAscendingCollection = listInt.OrderBy(l => l).Distinct().ToList();
       foreach (var number in distinctAscendingCollection)
       {
           Console.WriteLine(number);
       }
   }
}

public class SentanceAverage
{
    
   public void GiveMeAverage()
    {
        Console.WriteLine("Write me a sentance and i'll give you the average word count");
       string inputString = Console.ReadLine();
        Console.WriteLine(inputString.Split(" ").ToList().Average(s => s.Length));

    }
}

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
        List<string> listAB =  sentance.Where(s => s.StartsWith(a) || s.StartsWith(b)).ToList();
        foreach (var item in listAB)
        {
            Console.WriteLine(item);
        }
    }
}

public class StudentAndGrade
{
    public void CombineStudnetAndGradeList(List<Student> students, List<Grade> grades)
    {
        var studentGrades = students.Join(grades, (s) => s.ID, (g) => g.ID,
            (s, g) => new { Name = s.FirstName , grade = g.grade });

        foreach (var item in studentGrades)
        {
            Console.WriteLine(item);
        }
    }
}

public class Student
{
    public string FirstName;
    public int ID;

}

public class Grade
{
    public int ID;
    public int grade;
}