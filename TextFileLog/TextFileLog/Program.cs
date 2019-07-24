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

            string Text = numberEntered;
            File.WriteAllText(@"C:\Users\Marquita\Documents\Log.txt", Text);

            Console.WriteLine("The number you entered was " + Text + ".");
            Console.ReadLine();
            
            

        }
    }
}
