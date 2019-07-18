using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDrill2
{
    //1. Create a class. In that class, create a method that will take in an integer, do a math operation to it and then return the answer as an integer.
    class Class1
    {
        public int mathOne(int x)
        {
            int output = x + 10;
            Console.WriteLine(output);
            Console.ReadLine();
            return output;
        }

        //3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer.

        public int mathOne(decimal y)
        {
            decimal answer = y * 20;
            {
                Console.WriteLine(answer);
                int newAnswer = Convert.ToInt32(answer);
                Console.ReadLine();
                return newAnswer;
            }

        }

        //5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it and 
        //then return the answer as an integer.

        public int mathOne(string a)
        {
            int newA = Convert.ToInt32(a);
            int newAnswerTwo = newA + 50;
            Console.WriteLine(newAnswerTwo);
            Console.ReadLine();
            return newAnswerTwo;
        }
        
    }
}
