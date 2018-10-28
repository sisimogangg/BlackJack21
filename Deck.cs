using System;
using System.Collections.Generic;

namespace blackjack21
{
    class Deck
    {
        public List<Card> Cards { get; }

        // For each deck there is 20 cards per suit, J, Q, K will be last cards on the deck (cards number 20, 19, 18) and Ace ill be the first

        int numberOfCardsPerSuit = 13;
        

        //using the static method GetNames to get number of items defined in enum
        int suits = Enum.GetNames(typeof(Suits)).Length;
        public Deck()
        {
            Cards = new List<Card>();
            Card card;
            for (int j = 0; j < suits; j++)
            {
                 for (int i=1; i <= numberOfCardsPerSuit; i++)
                 {
                     if (i == 1) card = new Card{Value = "A", Suit = (Suits)j};
                     else if ( i == 11) card = new Card {Value = "J", Suit = (Suits)j};
                     else if ( i == 12) card = new Card {Value = "Q", Suit = (Suits)j};
                     else if (i == 13) card  = new Card {Value = "K", Suit = (Suits)j};
                     else card = new Card{Value = ""+i, Suit = (Suits)j};
                     Cards.Add(card);
                 }
            }
        }

    }
}