using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && false); //output False
            Console.WriteLine(true && true); //output True
            Console.WriteLine(false && false); //output False


            Console.WriteLine(true || true); //output True
            Console.WriteLine(true || false); //output True
            Console.WriteLine(false || false); //output False

            Console.WriteLine(true == true); //output True
            Console.WriteLine(true == false); //output False
            Console.WriteLine(false == false); //output True

            Console.WriteLine(true != true); //output False
            Console.WriteLine(true != false); //output True
            Console.WriteLine(false != false); //output False

            Console.WriteLine(true ^ true); //output False
            Console.WriteLine(true ^ false); //output True
            Console.WriteLine(false ^ false); //output False
            //Result will be true if one is true but not both


            Console.ReadLine();



        }
    }
}
