using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
            TwoParameters twoParameters = new TwoParameters();

            // 3.Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.

            Console.WriteLine("Enter in first number.");
           int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter in another number (if you want to, don't have to).");
            string b = Console.ReadLine();

            bool answer = string.IsNullOrEmpty(b);


            if (answer == true)
            {
               
                int c = twoParameters.parametersTwo(a);
                Console.WriteLine("The number or numbers you entered equals " + c + ".");
                Console.ReadLine();
          
            }
            else if (answer == false)
            {
                int c = twoParameters.parametersTwo(a, Convert.ToInt32(b));
                Console.WriteLine("The number or numbers you entered equals " + c + ".");
                Console.ReadLine();
               
            }

         //4. Call the method in the class, passing in the one or two numbers entered.


            twoParameters.parametersTwo(a: 0);

           //5. Try various combinations of numbers on the code, including having no second number.
            //input 1st number: 5, input 2nd number: 3, output: 8
            //input 1st number: 8, input 2nd number: (blank), output: 8

        }
    }
}
