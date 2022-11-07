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
            // makes a list and assigns values to each element
            // Runs max & min on the list

            int[] intArray1 = new int[5];
            
            Random rng = new Random();

            for (int i = 0; i < intArray1.Length; i++)
            {
                intArray1[i] = rng.Next(0, 99);
            }
            int[] intArray2 = new int[5];


            try
            {
                intArray2 = m.Copy(intArray1, intArray2);
                m.Print(intArray2.ToList());
            }
            catch (NonMatchingLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            
            Console.WriteLine("The list to be shuffled:");
            m.Print(intArray1.ToList());
            intArray1 = m.Shuffle(intArray1);
            Console.WriteLine("The list was shuffled to: ");
            m.Print(intArray1.ToList());


        }
    }
}