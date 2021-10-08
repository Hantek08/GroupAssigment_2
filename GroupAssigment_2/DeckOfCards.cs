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
                if (cards[i] != null)
                {
                    sRet += cards[i].ToString() + "\n";
                }
                
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
            // assign the second element value to the first element value
            PlayingCard cardDrawn = cards[0];
            Console.WriteLine($"==== Card {cards[0]} has been drawn and replaced with {cards[1]}");
            cards[0] = null;

            // sort the deck so clubs three takes position of clubs two then shift all cards

            int length = Count;
            for (int i = 0; i < length; i++)
            {
                if (cards[i] == null)
                {
                    for (int j = i; j < length - 1; j++)
                    {
                        if (cards[i] == cards[j])
                        {
                            PlayingCard tmp = cards[length - 1];
                            cards[length - 1] = cards[j];
                            cards[j] = tmp;
                            length--;
                            j--;
                        }
                    }
                }
            }

            return cardDrawn;
         

            //YOUR CODE
            //to return the Top card of the deck and reduce the nr of cards in the deck
            

        }

        public DeckOfCards()
        {
            FreshDeck();
            
            //YOUR CODE
            //to write a constructor that generates a fresh deck of cards
        }

        public int CardCounter()
        {
            int counter = 0;
            for (int i = 0; i < MaxNrOfCards; i++)
            {
                if(cards[i] != null)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
