using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StudentAndGrade // there are 3 related Classed in here: CombineStudnetAndGradeList , Student, Grade
{
    public void CombineStudnetAndGradeList(List<Student> students, List<Grade> grades)
    {
        var studentGrades = students.Join(grades, (s) => s.ID, (g) => g.ID,
            (s, g) => new { Name = s.FirstName, grade = g.grade });
        String lol = "lang";
        lol.Reverse();
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
