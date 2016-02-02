using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh3_PlayCardsShuffler
{
    class Deck
    {
        private List<Card> cards = new List<Card>();
        public string Name { get; set; }


        string selectSuit;
        public Deck(string name)
        {
            Name = name;
            
            for(int s=0; s<3; s++)
            {
                switch (s)
                {
                    case 0:
                        selectSuit = "Clubs";
                        break;
                    case 1:
                        selectSuit = "Diamonds";
                        break;
                    case 2:
                        selectSuit = "Hearts";
                        break;
                    case 3:
                        selectSuit = "Spades";
                        break;
                }
                for(int r=0; r<13; r++)
                {
                    cards.Add(new Card(selectSuit, r));
                }
            }
        }

        public void PrintCards()
        {
            Console.WriteLine("Cards in order of appearance in deck \"{0}\":", Name);
            foreach (Card card in cards)
            {
                Console.WriteLine(" - " + card.ToString());
            }
        }


    }
}
