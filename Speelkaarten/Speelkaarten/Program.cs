using Speelkaarten;

List<Kaart> deck = new List<Kaart>();
for (int i = 1; i <= 13; i++)
{
    foreach (var item in Enum.GetValues(typeof(Kleur)))
    {
        deck.Add(new Kaart(i, (Kleur)item));
    }
}

void KaartVerbranden()
{

    int Totalcards = deck.Count();
    if (Totalcards == 0)
    {
        Console.WriteLine("Gedaan met de pret!");
    }
    Random rng = new Random();
    int deleteAt = rng.Next(deck.Count);
    Kaart kaart = deck[deleteAt];
    deck.RemoveAt(deleteAt);
    Totalcards = deck.Count();

    Console.WriteLine($"{kaart.Kleur} {kaart.Getal} wordt uit het deck verwijderd, er zijn nog {Totalcards} over");
    Console.WriteLine("Druk op enter voor een nieuwe kaart");
    Console.ReadKey();
    KaartVerbranden();
    if (Totalcards == 0)
    {
        Console.WriteLine("Gedaan met de pret!");
    }

}


KaartVerbranden();
