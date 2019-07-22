using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDrill
{
    class Program : DaysOfWeek
    {

        static void Main(string[] args)
        {
            //2. Prompt the user to enter the current day of the week.
            Console.WriteLine("Please enter the current day of the week.");

            //3. Assign the value to a variable of that enum data type you just created.
            //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
            try
            {
                string currentDay = Console.ReadLine();
                DaysOfWeek.DaysOfTheWeek day = (DaysOfWeek.DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), currentDay);

                Console.WriteLine("The current day is " + day + ".");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }



        }

        


    }




}
