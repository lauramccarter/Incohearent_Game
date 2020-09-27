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
                string input = ""; 

                while (input != "g")
                {
                    input = Console.ReadLine();

                    if (input == card.Answer)
                    {
                        // user picked the right answer
                        Console.WriteLine("You got it right!");
                        input = "g";
                    }
                    else if (input == "h")
                    {
                        // user wants a hint
                        Console.WriteLine("Hint: " + card.Hint);
                    }
                    else if (input == "g")
                    {
                        // user gives up
                        Console.WriteLine("Answer: " + card.Answer);
                        break;
                    }
                    else
                    {
                        // user entered wrong answer
                        Console.WriteLine("Wrong. Try again");
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
           foreach (string line in lines)
            {
                Card mycard = new Card(line);
                cards.Add(mycard);
            }

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
                string[] mystring = line.Split(';');
                Question = mystring[0];
                Hint = mystring[1];
                Answer = mystring[2];
            }
        }



    }
}
