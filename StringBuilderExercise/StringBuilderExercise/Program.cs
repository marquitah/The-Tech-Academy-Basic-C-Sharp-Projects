using System;
using System.Text;


namespace StringBuilderExercise
{
    class Program
    {
        static void Main()
        {
            //1. Concatenate three strings.

            string dogName = "Sammy";
            string dogBreed = "Mini Aussie";
            string dogIntelligence = "\"not the brightest crayon in the box.\"";

            Console.WriteLine("My dog " + dogName + " is a " + dogBreed + " and his intelligence can be described as..." + dogIntelligence);
            Console.ReadLine();

            //2. Convert a string to uppercase.

            dogIntelligence = dogIntelligence.ToUpper();
            Console.WriteLine(dogIntelligence);
            Console.ReadLine();

            //3. Create a Stringbuilder and build a paragraph of text, one sentence at a time.

            StringBuilder stringParagraph = new StringBuilder("\"All Too Well\" - ");
            stringParagraph.Append("I walked through the door with you. ");
            stringParagraph.Append("The air was cold. ");
            stringParagraph.Append("But something 'bout it felt like home somehow, \n and I ");
            stringParagraph.Append("left my scarf there, at your sister's house. ");
            stringParagraph.Append("And you still got it in your drawer, even now.");

            Console.WriteLine(stringParagraph);
            Console.ReadLine();
        }
    }
}
