using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 static class IEnumarableExtensions // there are two related Classes here: IEnumarableExtensions And Enemy
{

    public static void PrintAll(this IEnumerable enumrable)
    {
        foreach (var item in enumrable)
        {
            Console.WriteLine(item);
          
        }
       
    }



    public static T GetHighestWithIComparable<T>(this IEnumerable<T> collection) where T : IComparable
    {
        
        T classWithHighestValue = collection.ToList()[0];

        foreach (T item in collection)
        {
         
            if (classWithHighestValue.CompareTo(item) < 0)
            {
                
                classWithHighestValue = item;
            }
        }

        return classWithHighestValue;

    }


    public static T GetHighest<T>(this IEnumerable<T> collection, Func<T, int> func)
    {
        int highestValue = 0;
        T classWithHighestValue = default;

        foreach (T item in collection)
        {
            if (highestValue < func.Invoke(item))
            {
                highestValue = func.Invoke(item);
                classWithHighestValue = item;
            }
        }

        return classWithHighestValue;

    }

}

public class Enemy : IComparable
{
    public int Damage = 10;




    public int CompareTo(object? obj)
    {
        
            return this.Damage - ((Enemy)obj).Damage;
   
    }

    public override string ToString()
    {
        return $"Enemy with {Damage} damage";
    }
}