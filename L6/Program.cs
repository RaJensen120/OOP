// See https://aka.ms/new-console-template for more information
using System;

namespace L6
{
    public class Program 
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                intList.Add(i);
            }
            intList.Add(2);
            intList.Add(-1);

            HandyMethods m = new HandyMethods();

            m.Print(intList);
            
            Console.WriteLine("The max value is: " + m.Max(intList));
            Console.WriteLine("The min value is: " + m.Min(intList));
            
            // The code so far:

            int[] intArray1 = new int[12];
            
            Random rng = new Random();

            for (int i = 0; i < intArray1.Length; i++)
            {
                intArray1[i] = rng.Next(0, 30);
            }
            int[] intArray2 = new int[11];

            
            
            try
            {
                intArray2 = m.Copy(intArray1, intArray2);
                m.Print(intArray2.ToList());
            }
            catch (NonMatchingLengthException e)
            {
                Console.WriteLine(e.Message);
            }

            

        }
    }
}