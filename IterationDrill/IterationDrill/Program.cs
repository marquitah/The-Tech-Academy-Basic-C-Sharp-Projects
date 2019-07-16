using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace IterationDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1. Create a one-dimensional Array of strings. Ask the user to input some text. 
            ////Create a loop that goes through each string in the Array, adding the user’s text to the string. Then create a loop that prints off each string in the Array on a separate line.

            string[] denverparks = { "city park", "sloan's lake park", "cheesman park" };
            List<string> addeddenverpark = denverparks.ToList();

            Console.WriteLine("add a park to the list.");
            string addpark = Convert.ToString(Console.ReadLine());

            addeddenverpark.Add(addpark);

            for (int p = 0; p < 4; p++)
            {
                Console.WriteLine(addeddenverpark[p]);
                Console.ReadLine();
            }


            //2. Create an infinite loop.
            //3. Fix the infinite loop so it will execute.

            while (true)
            {
                Console.WriteLine("It will never end unless there is a break.");
                Console.ReadLine();
                break;
            }



            //4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            int[] carYear = { 1998, 2000, 2019, 1975, 2014 };

            for (int i = 0; i < carYear.Length; i++)
            {
                if (carYear[i] < 2000)
                {
                    Console.WriteLine("Cars older than 2000: " + carYear[i]);
                    Console.ReadLine();
                }
            }


            //5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

            for (int i = 1; i <= 10; i++)
            {
                if (i <= 5)
                {
                    Console.WriteLine("These numbers are less than or equal to 5.");
                }
                else if (i >= 6)
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                }

            }

                //6. Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. 
                //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.

                //7. Add code to that above loop that tells a user if they put in text that isn’t in the List.

                //8. Add code to that above loop that stops it from executing once a match has been found.



                List<string> colors = new List<string>();
                colors.Add("purple");
                colors.Add("green");
                colors.Add("yellow");



                Console.WriteLine("Please type in either purple, green, or yellow.");
                string chosenColor = Console.ReadLine();

                foreach (string color in colors)
                {
                    if (colors.Contains(chosenColor))
                    {
                        Console.WriteLine(colors.IndexOf(chosenColor));
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose purple, green, or yellow.");
                        Console.ReadLine();
                    }

                }


                //9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. 
                //Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.

                //10. Add code to that above loop that tells a user if they put in text that isn’t in the List.


                List<string> twinsInList = new List<string>();
                twinsInList.Add("same");
                twinsInList.Add("different");
                twinsInList.Add("same");

                Console.WriteLine("Please type in the word \"same\".");
                string same = Console.ReadLine();

                foreach (string twins in twinsInList)
                {

                    if (same == "same")
                    {
                        Console.WriteLine("That word appears at index " + twinsInList.IndexOf(same) + " and " + twinsInList.LastIndexOf(same));
                        Console.ReadLine();
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Please type in the word \"same\".");
                        Console.ReadLine();
                        break;
                    }

                }



                //11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, 
                //and displays a message showing the string and whether or not it has already appeared in the list.

                List<string> cars = new List<string>();
                cars.Add("Toyota");
                cars.Add("Dodge");
                cars.Add("Ford");
                cars.Add("Scion");
                cars.Add("Toyota");

                foreach (string car in cars)
                {
                    if (cars.Contains("Toyota"))
                    {
                        Console.WriteLine("This has appeared in the list twice.");
                        Console.ReadLine();
                        break;
                    }
                }


            }

        }

    }
