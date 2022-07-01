void Berekenaar() {
    Console.WriteLine("Hallo dit is de BMI berekenaar");
    Console.WriteLine("Geef aub uw lengte in centimeter in");
    double Lengte = double.Parse(Console.ReadLine()) / 10;
    Console.WriteLine("oke top, nu uw gewicht in kg graag");
    int Gewicht = int.Parse(Console.ReadLine());
    double Berekening = Gewicht / (Lengte * Lengte) * 100;
    double BMI = (Math.Round(Berekening, 2));

    if (BMI < 18.5)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"uw BMI is {BMI}, ondergewicht");
    }
    else if (BMI > 18.5 && BMI < 25)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"uw BMI is {BMI}, gezond gewicht!");
    }

    else if (BMI > 25 && BMI < 30)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"uw BMI is {BMI}, overgewicht!");
    }

    else if (BMI > 18.5 && BMI < 25)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"uw BMI is {BMI}, gezond gewicht!");
    };
};


Berekenaar();