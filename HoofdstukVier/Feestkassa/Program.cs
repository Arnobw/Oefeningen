int Totaal = 0;

Console.WriteLine("Hoeveel porties mosselen met friet wilt u aub");
Totaal += int.Parse(Console.ReadLine())*20;

Console.WriteLine("Hoeveel porties koninginnenhapjes wilt u aub");
Totaal += int.Parse(Console.ReadLine()) * 10;

Console.WriteLine("Hoeveel ijsjes wilt u aub");
Totaal += int.Parse(Console.ReadLine()) * 3;

Console.WriteLine("hoeveel dranken wilt u aub");
Totaal += int.Parse(Console.ReadLine()) * 2;

Console.WriteLine($"Uw totaal bedrag is {Totaal} euro");