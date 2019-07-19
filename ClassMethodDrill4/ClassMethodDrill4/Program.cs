using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, instantiate that class.

            VoidMethod v = new VoidMethod();
            

            //3. Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.


            
            Console.WriteLine("Enter a number and I'll divide it by two.");
            int b = Convert.ToInt32(Console.ReadLine());
            v.voidMethod(out int output, b);

            Console.WriteLine("The answer is " + output + ".");
            Console.ReadLine();

           



        }
    }
}
