using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDrill
{
    class VoidClass
    {
        //1. Create a class. In that class, create a void method that takes two integers as parameters. 
        //Have the method do a math operation on the first integer and display the second integer to the screen.

        public void voidMethod(int a, int b)
        {
            int output = a + 10;
            {
                Console.WriteLine(b + ", " + output);
                Console.ReadLine();
            }
            
        }
     
    }
    

}
