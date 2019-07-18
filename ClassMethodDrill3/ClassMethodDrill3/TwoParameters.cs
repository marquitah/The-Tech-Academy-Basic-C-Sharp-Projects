using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDrill3
{
    class TwoParameters
    {
        //1. Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. 
        //Have the method do a math operation and return a integer result.
        //3. Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
        

        

        public int parametersTwo(int a, int b = 0)
        {
            
            
            Console.WriteLine("Enter in first number.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter in another number (if you want to, don't have to).");
            b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            if (b == 0)
            {
                c = a + 0; 
            }
            
            Console.WriteLine("The number or numbers you entered equals " + c + ".");
            Console.ReadLine();
            return c;

            
        }

       

        

    }
}
