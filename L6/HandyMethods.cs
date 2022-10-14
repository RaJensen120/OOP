using System.Runtime.CompilerServices;

namespace L6;

public class HandyMethods
{
    public T Max<T>(List<T> list) where T : IComparable<T>
    {
        T tempMax = list[0];

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].CompareTo(tempMax) > 0)
            {
                tempMax = list[i];
            }
            
        }

        return tempMax;
    }
    
    public T Min<T>(List<T> list) where T : IComparable<T>
    {
        T tempMin = list[0];

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].CompareTo(tempMin) < 0)
            {
                tempMin = list[i];
            }
            
        }

        return tempMin;
    }

    public T[] Copy<T>(T[] t1, T[] t2)
    {
        if (t1.Length != t2.Length)
        {
            throw new NonMatchingLengthException();
        }

        for (int i = 0; i < t1.Length; i++)
        {
            t2[i] = t1[i];
        }

        return t2;

    }

    public T[] Shuffle<T>(T[] t1)
    {
        Random rng = new Random();
        int j, k;

        for (int i = 0; i < t1.Length; i++)
        {
            j = rng.Next(0, t1.Length);
            k = rng.Next(0, t1.Length);

            (t1[j], t1[k]) = (t1[k], t1[j]);
        }

        return t1;

    }
    
    public void Print<T>(List<T> list)
    {
        

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("Element {0} is: {2}", i , nameof(list), list[i]);
        }
    }
}