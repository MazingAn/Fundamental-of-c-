using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fundamental.Cardlib
{
    public class Deck
    {

        private Cards cards = new Cards();

        public Deck()
        {
            for(int suitVal = 0; suitVal < 4; suitVal++)
            {
                for(int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        public Card GetCard(int cardnum)
        {
            if (cardnum >= 0 && cardnum <= 51)
            {
                return cards[cardnum];
            }
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardnum", cardnum,
                    "Value must be between 0 and 51"));
            }
        }

        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for(int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while(foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if(assigned[sourceCard] == false)
                    {
                        foundCard = true;
                    }
                }
                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            newDeck.CopyTo(cards);
        }

        public void Display()
        {
            foreach(Card card in cards)
            {
                Console.WriteLine(card);
            }
        }



    }
}