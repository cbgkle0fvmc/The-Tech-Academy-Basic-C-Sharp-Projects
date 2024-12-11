using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            //Below is constructor, first thing it does is instantiate empty list of cards
            //Deck of cards has 13 faces of cards (2-10, jack, king, queen, ace)
            //Each card has four suits (heart, club, spade, diamonds)
            //4 suits * 13 faces each suit = 52 cards

            //Nested for each loop

            Cards = new List<Card>(); //Card is referring to property of class, doesn't need data type specified
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //instantiate list of suits
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //Each loop creates a card
                    card.Suit = suit; //Each loop assigns value of suit to card
                    card.Face = face; //Each loop assigns value of face to card
                    Cards.Add(card); //Add value of new card to Cards list at top of class
                }
            }

        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0,Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }

        }
    }

}
