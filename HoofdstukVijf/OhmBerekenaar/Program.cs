Console.WriteLine("Wat wenst u te berekenen? (spanning, weerstand, stroomsterkte");
string Invoer = Console.ReadLine();
Invoer = Invoer.ToLower();
if (Invoer == "spanning")
{
    Console.WriteLine("U koos spanning");
}
else if (Invoer == "weerstand")
{
    Console.WriteLine("U koos weerstand");
}
else if (Invoer == "stroomsterkte") {
    Console.WriteLine("U koos stroomsterkte");
};
