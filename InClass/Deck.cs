using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();

            string[] suits = {"Hearts","Spades","Diamonds","Clubs" };

            int suitNumber = 0, deckNumber = 0;

            //1 2 3 4 ...11 12 13 14 15 

            //card creation loop
            for (int i = 0; i < 52; i++)
            {
                Card c = new Card();
                c.Suit = suits[deckNumber];

                suitNumber = (i + 1) % 13;

                if (suitNumber == 1)
                    c.CardName = "Ace";
                else if (suitNumber == 11)
                    c.CardName = "Jack";
                else if (suitNumber == 12)
                    c.CardName = "Queen";
                else if (suitNumber == 0)
                {
                    c.CardName = "King";
                    deckNumber++;
                }
                else
                    c.CardName = suitNumber.ToString();

            }

        }

        public void DisplayCards()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
