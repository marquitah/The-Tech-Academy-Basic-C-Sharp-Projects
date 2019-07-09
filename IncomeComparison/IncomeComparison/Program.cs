using System;


namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program must start by printing “Anonymous Income Comparison Program” to the screen

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();


            //It must then print “Person 1” to the screen and get the following details: Hourly Rate Hours worked per week

            string hourlyRate1;
            string hoursWorked1;
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            hoursWorked1 = Console.ReadLine();


            //It must then print “Person 2” to the screen and then get the following details: Hourly rate Hours worked per week

            string hourlyRate2;
            string hoursWorked2;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            hoursWorked2 = Console.ReadLine();

            //It must then print to the screen “Weekly salary of Person 1:” and write the exact salary below it.

            int weeklySalary1;
            Console.WriteLine("Weekly salary of Person 1:");
            int hourRate1 = Convert.ToInt32(hourlyRate1);
            int hourWork1 = Convert.ToInt32(hoursWorked1);

            weeklySalary1 = hourRate1 * hourWork1;

            Console.WriteLine(weeklySalary1);
            Console.ReadLine();

            //It must then print to the screen “Weekly salary of Person 2:” and write the exact salary below it.

            int weeklySalary2;
            Console.WriteLine("Weekly salary of Person 2:");
            int hourRate2 = Convert.ToInt32(hourlyRate2);
            int hourWork2 = Convert.ToInt32(hoursWorked2);

            weeklySalary2 = hourRate2 * hourWork2;

            Console.WriteLine(weeklySalary2);
            Console.ReadLine();

            //It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it.


            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();

            if (hourRate1 > hourRate2)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
        }
    }
}
