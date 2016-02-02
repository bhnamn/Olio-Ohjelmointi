using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh3_PlayCardsShuffler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Deck> decks = new List<Deck>();
            Deck deck1 = new Deck("Deck 1");

            decks.Add(new Deck("Deck 1"));
            deck1.PrintCards();

        }
    }
}
