using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Oriented Programming - objects are items that can be represented by a computer program. They are often meant to represent real-world things.
            //In the world around you, you are surrounded by objects: your dog, the tv, etc. 
            //Objects have state and behavior. The state of an object could be the size, color, etc. at any point in time.

            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck: deck, out timesShuffled, 3);//calling the function or method
           

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffle: {0}", timesShuffled);
            Console.ReadLine();
            

        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)//Method (function, routine)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }

            
            return deck;

        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
