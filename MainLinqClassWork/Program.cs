// ---- C# II (Dor Ben Dor) ----
//         Roee Tal
// -----------------------------
class Program
{
    static public void Main(String[] args)
    {
     
        while (true)
        {

            Console.WriteLine("choose which part to test");
            Console.WriteLine("1) DistinctAndAscending");
            Console.WriteLine("2) SentenceAverage");
            Console.WriteLine("3) PrintAllStringsThatStartWithChosenChars");
            Console.WriteLine("4) CombineStudentsAndGradeLists and PrintAllExtensionMethod");
            Console.WriteLine("5) BothExtensions that return T (first with no IComparable then with)");
            Console.WriteLine("6) Exit");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    DistinctAndAscending distinctAndAscending = new DistinctAndAscending();
                    distinctAndAscending.MakeListDistinctAndAscending();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 2:
                    SentenceAverage sentenceAverage = new SentenceAverage();
                    sentenceAverage.GiveMeAverage();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 3:
                    PrintAllStringsWithThatChar printStringWithChar = new PrintAllStringsWithThatChar();
                    printStringWithChar.PrintWordsThatStartWithThatLetters();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 4:
                    StudentAndGrade studentsAndGrades = new StudentAndGrade();

                    List<Student> students = new List<Student>
        {
        new Student { FirstName = "Daniel", ID = 101 },
         new Student { FirstName = "Amit", ID = 0 },
          new Student { FirstName = "Roee", ID = 206697450 }
        };

                    List<Grade> grades = new List<Grade>
        {
            new Grade { ID = 101, grade = 99 },
            new Grade { ID = 0, grade = 1 },
            new Grade { ID = 206697450, grade = 110 }
        };
                    studentsAndGrades.CombineStudnetAndGradeList(students, grades);
                    students.PrintAll();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 5:
                    List<Enemy> eList = new();
                    for (int i = 0; i < 150; i++)
                    {
                        eList.Add(new Enemy() { Damage = Random.Shared.Next(1, 1500) });
                    }
                    
                  
                    Console.WriteLine(eList.GetHighest(e => e.Damage));
                    Console.WriteLine(eList.GetHighestWithIComparable());
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 6:
                    Console.WriteLine("closing....");
                    return;


                default:
                    Console.WriteLine("you didn't choose correctly ");
                    Console.ReadLine();
                    Console.Clear();
                   break;
            }
        }

    }

}







