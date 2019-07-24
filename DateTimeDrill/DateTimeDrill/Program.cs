using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The date and time is " + DateTime.Now + ". Please enter in a number.");
            string numberEntered = Convert.ToString(Console.ReadLine());
            double newNumber = Convert.ToDouble(numberEntered);


            DateTime dt = DateTime.Now;
            DateTime newTime = dt.AddHours(newNumber);

            
            

            Console.WriteLine(newTime);
            Console.ReadLine();
            

        }
    }
}
