using System;


namespace BranchingExample
{
    class Program
    {
        static void Main()
        {

            int roomTemperature = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            int currentTemperture = Convert.ToInt32(Console.ReadLine());

            if (currentTemperture == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
                Console.ReadLine();
            }
            else if (currentTemperture > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
                Console.ReadLine();
            }
            else if (roomTemperature > currentTemperture)
            {
                Console.WriteLine("It is colder than room temperature.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Uhhh..something went wrong.");
                Console.ReadLine();
            }



            //--Ternory Example---(shortcut for if/else statements)--//
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number!" : "You do not have an awesome favorite number...";

            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
