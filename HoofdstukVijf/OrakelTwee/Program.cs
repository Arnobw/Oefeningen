Random Rngesus = new Random();
Console.WriteLine("Hallo, ben u een man of een vrouw?");
string Geslacht = Console.ReadLine();
Console.WriteLine("En uw leeftijd?");
int Leeftijd = int.Parse(Console.ReadLine());


if (Geslacht.ToLower() == "man")
{
   
    int Leven = Rngesus.Next(4, 121-Leeftijd);
    Console.WriteLine($"U heeft nog {Leven} jaar te gaan, maak er goed gebruik van");
}
else if (Geslacht.ToLower() == "vrouw") {
    int Leven = Rngesus.Next(4, 151-Leeftijd);
    Console.WriteLine($"U heeft nog {Leven} jaar te gaan, maak er goed gebruik van");
} else {
    Console.WriteLine("Wow, u bent onsterfelijk! Proficiat.");
};



