using System;


namespace CSharpAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            string Course = "What course are you on?";
            Console.WriteLine(Course);
            Console.ReadLine();

            string PageNumber = "What page number are you on?";
            Console.WriteLine(PageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
            bool studentHelp = Convert.ToBoolean(help);
            Console.ReadLine();

            string positive = "Were there any positive experiences you'd like to share? Please give specifics.";
            Console.WriteLine(positive);
            Console.ReadLine();

            string feedback = "Is there any other feedback you'd like to provide? Please be specific.";
            Console.WriteLine(feedback);
            Console.ReadLine();

            string hours = "How many hours did you study today?";
            Console.WriteLine(hours);
            Console.ReadLine();

            string thankYou = "Thank you for your answers. An instructor will respond to this shortly. Have a great day!";
            Console.WriteLine(thankYou);
            Console.ReadLine();
        }
    }
}
