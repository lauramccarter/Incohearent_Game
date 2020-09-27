using System;
using System.Collections.Generic;
using System.IO;

namespace Incohearent_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Incohearent Game");
            Console.WriteLine("Controls: h for hint, g for give up");

            List<Card> cards = ReadCards();

            foreach( Card card in cards)
            {
                Console.WriteLine(Environment.NewLine + card.Question);
                string input = Console.ReadLine();

                while (input != "g")
                {
                    if (input == card.Answer)
                    {
                        // user picked the right answer
                    }
                    else if (input == "h")
                    {
                        // user wants a hint
                    }
                    else if (input == "g")
                    {
                        // user gives up
                    }
                    else
                    {
                        // user entered wrong answer
                    }
                }
            }
        }

        private static List<Card> ReadCards()
        {
            string filename = "Cards.txt";
            string[] lines = File.ReadAllLines(filename);
            List<Card> cards = new List<Card>();

            // Write a for loop here to loop through all the Card objects in cars, create
            // card objects and add them to the list
           

            return cards;
        }

        public class Card
        {
            public string Question;
            public string Hint;
            public string Answer;

            public Card(string line)
            {
               // write code here to get question, hint, and answer strings assigned
            }
        }



    }
}
