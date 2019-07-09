using System;


namespace CarInsuranceBooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            string age;
            Console.WriteLine("What is your age?");
            age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);

            string DUI;
            Console.WriteLine("Have you ever had a DUI? Enter \"yes\" or \"no\".");
            DUI = Console.ReadLine();

            string speedingTickets;
            Console.WriteLine("How many speeding tickets do you have?");
            speedingTickets = Console.ReadLine();
            int speedingTickets1 = Convert.ToInt32(speedingTickets);


            Console.WriteLine("Qualified?");
            Console.WriteLine(age1 > 15 && DUI == "no" && speedingTickets1 <= 3);
            Console.ReadLine();

            


        }
    }
}
