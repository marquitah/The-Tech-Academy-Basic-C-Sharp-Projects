using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a number.");
            string numberEntered = Convert.ToString(Console.ReadLine());

            
            File.WriteAllText(@"C:\Users\Marquita\Documents\log.txt", numberEntered);
            string readText = File.ReadAllText(@"C:\Users\Marquita\Documents\log.txt");


            Console.WriteLine("The number you entered was " + readText + ".");
            Console.ReadLine();
            
            

        }
    }
}
