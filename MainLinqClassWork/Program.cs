
using System.ComponentModel;
using System.Runtime.InteropServices;




class Program
{

    static public void Main(String[] args)
    {
        DistinctAndAcendingTest();
        AverageCharCountTest();
        PrintStringStartWithCharTest();
        StudentsTest();

    }

    public static void DistinctAndAcendingTest()
    {
        DistinctAndAscending distinctAndAscending = new DistinctAndAscending();
        distinctAndAscending.Testing();
    }

    public static void AverageCharCountTest()
    {
        SentanceAverage senAverage = new SentanceAverage();
        senAverage.Testing();
    }

    public static void PrintStringStartWithCharTest()
    {
        PrintAllStringsWithThatChar printStringWithChar = new PrintAllStringsWithThatChar();
        printStringWithChar.Testing();
    }
   public static void StudentsTest()
    {
        StudentAndGrade studentsAndGrades = new StudentAndGrade();
        studentsAndGrades.Testing();
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
       var distinctAscendingCollection = _listInt1.OrderBy(l => l).Distinct().ToList();
       foreach (var number in distinctAscendingCollection)
       {
           Console.WriteLine(number);
       }
   }
}

public class SentanceAverage
{
    private string sAvegrage = "i am going to the mall today you are assholes";
    private List<string> listString1 = new List<string>();

   public void Testing()
    {
        Console.WriteLine(sAvegrage.Split(" ").ToList().Average(s => s.Length));

    }
}

public class PrintAllStringsWithThatChar
{
    char a = 'A';
    char b = 'B';
    private List<string> sList = new List<string>()
    {
        "Hello", "Mom" ,"Crack", "Phone", "About", "Banana"
    };

   public void Testing()
    {
        List<string> listAB = sList.Where(s => s.StartsWith(a) || s.StartsWith(b)).ToList();
        foreach (var item in listAB)
        {
            Console.WriteLine(item);
        }
    }
}

public class StudentAndGrade
{
    public void Testing()
    {
       
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