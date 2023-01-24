using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class IEnumarableExtensions // there are two related Classes here: IEnumarableExtensions And Enemy
{

    public static IEnumerable PrintAll(this IEnumerable e)
    {
        foreach (var item in e)
        {
            Console.WriteLine(item);

        }
        return e;
    }


    public static IEnumerable<T> GetHighestWithIComparable<T>(this IEnumerable<T> iEnum, Func<T, int> func) where T : IComparable<T>
    {
        List<int> dList = new List<int>();
        foreach (T item in iEnum)
        {
            dList.Add(func.Invoke(item));
        }


        var orderedList = dList.OrderBy(d => d).Reverse().ToList();

        int largest = orderedList[0];
        foreach (int item in orderedList)
        {
            Console.Write(item + ",");
        }


        return iEnum.Where(x => func(x) == largest);

    }

    public static IEnumerable<T> GetHighest<T>(this IEnumerable<T> iEnum, Func<T, int> func)
    {



        List<int> dList = new List<int>();
        foreach (T item in iEnum)
        {
            dList.Add(func.Invoke(item));
        }

        var orderedList = dList.OrderBy(d => d).Reverse().ToList();

        int largest = orderedList[0];
        foreach (int item in orderedList)
        {
            Console.Write(item + ",");
        }


        return iEnum.Where(x => func(x) == largest);

    }


}

public class Enemy : IComparable<Enemy>
{
    public int Damage = 10;


    public int CompareTo(Enemy? other)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"Enemy with {Damage} damage";
    }
}