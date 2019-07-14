using System;
using System.Collections.Generic;
using System.Linq;


namespace ArraysAndListsExercise
{
    class Program
    {
        static void Main()
        {
            //1. Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

            string[] selectIndex = { "firewood", "hamburgers", "tent", "rain gear" };

            Console.WriteLine("Select an index of the array between 0 and 3");
            int selectedArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You selected " + selectIndex[selectedArray]);
            Console.ReadLine();


            //2. Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

            int[] selectNumber = { 0, 1, 1, 2, 3, 5, 8, 13, 21 };


            Console.WriteLine("Select an index of the array between 0 and 8.");
            int indexSelected = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You selected (hit enter to reveal)");
            Console.ReadLine();

            //3.Add in a message that displays when the user selects an index that doesn’t exist.

            if (indexSelected > 8)
            {
                Console.WriteLine("That index does not exist.");

            }
            else
            {
                Console.WriteLine(selectNumber[indexSelected]);
            }
            Console.ReadLine();


            //4. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

            List<string> candyList = new List<string>();
            candyList.Add("Reese's");
            candyList.Add("Snickers");
            candyList.Add("M&M's");

            Console.WriteLine("Select an index between 0 and 2.");
            int candySelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You selected " + candyList[candySelection]);
            Console.ReadLine();

        }




    }
}
