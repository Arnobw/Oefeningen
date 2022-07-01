Console.WriteLine("Welkom bij Brantano, hoeveel schoenen wilt u kopen");
int AantalSchoenen = int.Parse(Console.ReadLine());
Console.WriteLine("vanaf hoeveel schoenen telt de korting");
int Korting = int.Parse(Console.ReadLine());
int Totaal = 0;
if (AantalSchoenen > Korting) {
    int Rest = AantalSchoenen - 9;
    AantalSchoenen -= Rest;
    Totaal = AantalSchoenen * 20 + Rest * 10;
        }
else{
    Totaal = AantalSchoenen * 20;
};

Console.WriteLine(Totaal);
