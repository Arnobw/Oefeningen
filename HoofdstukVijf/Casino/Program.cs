Random RNG = new Random();
int Getal = RNG.Next(0, 7);
Console.WriteLine("Welkom bij het gokfestijn, geef een nummer van 1 t.e.m 6 in en zie of je gewonnen hebt!");
int Antwoord = int.Parse(Console.ReadLine());


if (Antwoord == Getal)
{
    Console.WriteLine($"Goed gegokt! Het getal was inderdaad {Getal}");
}
else if (Antwoord > 6 || Antwoord < 1) {
    Console.WriteLine("leer lezen");
}
else
{
    Console.WriteLine($"Helaas! Het juiste getal is {Getal}, en niet {Antwoord}!");
};