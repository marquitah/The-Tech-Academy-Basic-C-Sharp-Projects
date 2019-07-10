using System;


namespace ShippingQuoteBranchingExercise
{
    class Program
    {
        static void Main()
        {
            int weight;
            int width;
            int height;
            int length;
            int total;
            int quote;
            

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight...");
            weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped with Package Express. Have a good day.");
                Console.ReadLine();
            }
            else if (weight < 50)
            {

                Console.WriteLine("Enter the width of the package.");
                width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the height of the package.");
                height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the length of the package.");
                length = Convert.ToInt32(Console.ReadLine());
                total = width + height + length;

                if (total > 50)
                {
                    Console.WriteLine("Package is too big to be shipped by Package Express.");
                    Console.ReadLine();
                }

                else if (total < 50)
                {
                    quote = total * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is $" + quote + ".00.");
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }

            }



 
        }
    }
}
