namespace Speelkaarten
{
    public class GameEngine : IGameEngine
    {
        public void KaartVerbranden(IList<Kaart> deck)
        {
            int Totalcards = GetAmountOfCards(deck);
            if (Totalcards == 0)
            {
                Console.WriteLine("Gedaan met de pret!");
            }
            else
            {
                Kaart kaart = DrawCard(deck);
                Totalcards = GetAmountOfCards(deck);
                PrintDrawnCard(Totalcards, kaart);
                Console.ReadKey();
                KaartVerbranden(deck);
            }
        }

        public IList<Kaart> GenerateDeckOfCards()
        {
            var deck = new List<Kaart>();
            for (int i = 1; i <= 13; i++)
            {
                foreach (Kleur item in Enum.GetValues(typeof(Kleur)))
                {
                    deck.Add(new Kaart(i, item));
                }
            }

            return deck;
        }

        private void PrintDrawnCard(int Totalcards, Kaart kaart)
        {
            Console.WriteLine($"{kaart.Kleur} {kaart.Getal} wordt uit het deck verwijderd, er zijn nog {Totalcards} over");
            Console.WriteLine("Druk op enter voor een nieuwe kaart");
        }

        private Kaart DrawCard(IList<Kaart> deck)
        {
            Random rng = new Random();
            int deleteAt = rng.Next(deck.Count);

            Kaart kaart = deck[deleteAt];
            deck.RemoveAt(deleteAt);

            return kaart;
        }

        private int GetAmountOfCards(IList<Kaart> deck)
        {
            return deck.Count();
        }
    }
}