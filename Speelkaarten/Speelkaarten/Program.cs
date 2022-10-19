using Speelkaarten;

IGameEngine engine = new GameEngine();
IList<Kaart> deck = engine.GenerateDeckOfCards();

engine.KaartVerbranden(deck);