using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, write a method to total the odd numbers

            //    int[] arr = new int[100];
            //    int i, num, evennum, oddnum;

            //    Console.WriteLine("Enter size of the array: ");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter " + num + " elements in the array. Please press enter after each number entered.");

            //    for(i=0; i<num; i++)
            //    {
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    evennum = 0;
            //    oddnum = 0;

            //    for (i=0; i<num; i++)
            //    {
            //        if (arr[i] % 2 == 0)
            //        {
            //            evennum++;
            //        }
            //        else
            //        {
            //            oddnum++;
            //        }
            //    }
            //    Console.WriteLine("Total odd numbers: " + oddnum + ".");
            //    Console.ReadLine();
            //}


            //Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers

            //int[] arr = { 1, 3, 5, 7 };

            //Console.WriteLine("The array is {1 ,3 ,5, 7}");
            //Console.ReadLine();
            //Console.WriteLine("I will add them together.");
            //Console.ReadLine();

            //int sum = arr.Sum();
            //Console.WriteLine("The total is " + sum + ".");
            //Console.ReadLine();


            //Given a string, reverse it

            //string myString = "Marquita";
            //string rev = "";

            //int len;
            //len = myString.Length - 1;

            //while (len >= 0)
            //{
            //    rev = rev + myString[len];
            //    len--;
            //}
            //Console.WriteLine("The reversed string is {0}", rev);
            //Console.ReadLine();


            //Given a string, remove any repeated letters

            //string repeatLetters = "marquita";
            //Console.WriteLine("Initial string: " + repeatLetters);

            //var removeLetters = new HashSet<char>(repeatLetters);

            //Console.WriteLine("New string after repeat letters are removed: ");
            //foreach (char c in removeLetters)
            //    Console.WriteLine(c);
            //Console.ReadLine();


            //FizzBuzz (Look this one up and try it out)

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                }
            }
        }
    }
}