using System;
using System.Collections.Generic;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to iterate over an array. 1st condition is starting values, 2nd is how long you want to iterate (until what is false), 3rd is what you want to do after the for loop runs.

            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            for (int i = 0; i < testScores.Length; i++)
            {
                //what you want the for loop to do.
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }
            Console.ReadLine();



            //How to iterate through a string array.

            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j]);

            }
            Console.ReadLine();



            //How to iterate through a list.

            List<int> testScores = new List<int>();

            testScores.Add(98);
            testScores.Add(99);
            testScores.Add(81);
            testScores.Add(72);
            testScores.Add(70);

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test scores: " + score);
                }
            }
            Console.ReadLine();



            List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            foreach (string name in names)
            {
                if (name == "Jesse")
                {
                    Console.WriteLine(name);
                    Console.ReadLine();
                }
            }

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>(); //Creates a blank list.

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
