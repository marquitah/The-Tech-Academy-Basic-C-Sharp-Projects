using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayTryCatchDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for his age.
            //2. Display the year user born.
            //3. Exceptions must be handled using "try .. catch".
            //4. Display appropriate error messages if user enters zero or negative numbers.
            
         
                try
                {

                    Console.WriteLine("What is your age?");
                    int age = Convert.ToInt32(Console.ReadLine());


                if (age <= 0)
                {
                    Console.WriteLine("Please do not enter zero or a negative number.");
                    Console.ReadLine();
                    return;
                }


                    int result = DateTime.Parse("07/24/2019").Year;


                    int yearBorn = result - age;

                    Console.WriteLine("You were born in the year {0}.", yearBorn);
                    Console.ReadLine();

                }

                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number.");
                    Console.ReadLine();
                }

                //5. Display a general message if exception caused by anything else.

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();


                }
                

        }        

    }
}
