int Totaal = 0;

for (int i=0; i<5; i++){
Console.WriteLine("voer bedrag in");
Totaal += int.Parse(Console.ReadLine());

};
int Afbetaling = Totaal / 10;
Console.WriteLine($"Het totaal is {Totaal} Euro en zal {Afbetaling} weken duren om af te betalen!");