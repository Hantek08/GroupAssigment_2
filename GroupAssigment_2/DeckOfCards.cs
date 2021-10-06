using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssigment_2
{
    class DeckOfCards
    {
        const int MaxNrOfCards = 52;

        PlayingCard[] cards = new PlayingCard[MaxNrOfCards];

        public PlayingCard this[int idx]
        {
            get
            {
                return cards[idx];
            }
        }

        /// <summary>
        /// Number of Cards in the deck
        /// </summary>
        public int Count => cards.Length;

        /// <summary>
        /// Overriden and used by for example Console.WriteLine()
        /// </summary>
        /// <returns>string that represents the complete deck of cards</returns>
        public override string ToString()
        {

            string sRet = "";
            for (int i = 0; i < Count; i++)
            {
                sRet += cards[i].ToString() + "\n";
            }
            return sRet;
        }

        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void Shuffle()
        {
            //PlayingCard tmp;
            Random rand = new Random(); //rnd is now a random generator - see .NET documentation

            for (int unsortedStart = cards.Length - 1; unsortedStart > 0; unsortedStart--)
            {
                var tmp = cards[unsortedStart];
                var index = rand.Next(0, unsortedStart + 1);
                cards[unsortedStart] = cards[index];
                cards[index] = tmp;

            }

            //YOUR CODE
            //to shuffle the deck.
            //Hint: pick two cards in the deck randomly and swap them. Do this 1000 times

        }
        /// <summary>
        /// Initialize a fresh deck consisting of 52 cards
        /// </summary>
        public void FreshDeck()
        {
            int cardNr = 0;
            for (PlayingCardColor color = PlayingCardColor.Clubs; color <= PlayingCardColor.Spades; color++)
            {
                for (PlayingCardValue value = PlayingCardValue.Two; value <= PlayingCardValue.Ace; value++)
                {
                    cards[cardNr] = new PlayingCard { Color = color, Value = value };
                    //Console.WriteLine(cards[cardNr].ToString());

                    cardNr++;
                }

            }
        }

        /// <summary>
        /// Removes the top card in the deck and 
        /// </summary>
        /// <returns>The card removed from the deck</returns>
        public PlayingCard GetTopCard()
        {

            //YOUR CODE
            //to return the Top card of the deck and reduce the nr of cards in the deck
            return null;
        }

        public DeckOfCards()
        {
            FreshDeck();
            //YOUR CODE
            //to write a constructor that generates a fresh deck of cards
        }
    }
}
