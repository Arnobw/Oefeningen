Random RNG = new Random();
int Number = RNG.Next(1, 6);
int Response = 0;
int Counter = 0;
int Hp = 3;

Console.WriteLine("Welkom op het gokfestijn!\nRaad 3 maal op rij een getal van 1 t.e.m 6 voor een geweldige prijs!");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Geef aub uw eerste getal in:");
Console.ResetColor();
Vraag();
void Vraag() {
    Number = RNG.Next(1, 6);
    Response = int.Parse(Console.ReadLine());
    Check();
};

void Check() {
    if (Counter == 3)
    {
        Console.WriteLine("Geweldig, u wint een auto");
    }
    else {
        if (Response == Number)
        {
            
            Counter++;
            Console.WriteLine($"Correct antwoord! Het was inderdaad {Number}, \n Dat is al {Counter} op rij.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Raad nu het volgende getal:");
            Console.ResetColor();
            Vraag();

        }
        else {
            Console.ForegroundColor = ConsoleColor.Red;
            Hp--;
            Console.WriteLine("Helaas, hier stopt de pret");
        };
    };


};