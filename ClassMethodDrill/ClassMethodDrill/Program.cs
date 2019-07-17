using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.

            VoidClass void1 = new VoidClass();

            //3. Call the method in the class, passing in two numbers.

            void1.voidMethod(3,5);

            //4. Call the method in the class, specifying the parameters by name.

            void1.voidMethod(a:3, b:5);

            //Console.WriteLine(5);
            //Console.ReadLine();
        }


    }
}
