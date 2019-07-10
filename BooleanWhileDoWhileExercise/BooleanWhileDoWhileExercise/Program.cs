using System;


namespace BooleanWhileDoWhileExercise
{
    class Program
    {
        static void Main()
        {
            //1. Do a boolean comparison using a while statement.

            Console.WriteLine("What is my favorite plant?");
            string input = Convert.ToString(Console.ReadLine());

            bool favePlant = input == "snake plant";

            while (!favePlant)
                switch (input)
                {
                    default:
                        Console.WriteLine("Nope! Guess again.");
                        input = Convert.ToString(Console.ReadLine());
                        break;

                    case "flowers":
                        Console.WriteLine("Flowers are beautiful! But not my favorite. Guess again!");
                        input = Convert.ToString(Console.ReadLine());
                        break;

                    case "succulents":
                        Console.WriteLine("So cute! But I kill those. Guess again!");
                        input = Convert.ToString(Console.ReadLine());
                        break;

                    case "snake plant":
                        Console.WriteLine("Correct! Couldn't kill it if I tried.");
                        Console.ReadLine();
                        favePlant = true;
                        break;
                }


            //2. Do a boolean comparison using a do while statement.

            Console.WriteLine("What is the temperature?");
            int temp = Convert.ToInt32(Console.ReadLine());

            bool currentTemp = temp == 82;

            do
            {
                switch (temp)
                {
                    default:
                        Console.WriteLine("That is incorrect.");
                        temp = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 32:
                        Console.WriteLine("Brrr!! It's July. That is incorrect.");
                        temp = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 100:
                        Console.WriteLine("Close! But not that hot.");
                        temp = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 82:
                        Console.WriteLine("That is correct.");
                        temp = Convert.ToInt32(Console.ReadLine());
                        currentTemp = true;
                        break;

                }

            }
            while (!currentTemp);
        }
    }
}
