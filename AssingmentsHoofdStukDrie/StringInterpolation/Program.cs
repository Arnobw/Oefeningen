string DollarBill = @"
||====================================================================||
||//$\\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//$\\||
||(100)==================| FEDERAL RESERVE NOTE |================(100)||
||\\$//        ~         '------========--------'                \\$//||
||<< /        /$\              // ____ \\                         \ >>||
||>>|  12    //L\\            // ///..) \\         L38036133B   12 |<<||
||<<|        \\ //           || <||  >\  ||                        |>>||
||>>|         \$/            ||  $$ --/  ||        One Hundred     |<<||
||<<|      L38036133B        *\\  |\_/  //* series                 |>>||
||>>|  12                     *\\/___\_//*   1989                  |<<||
||<<\      Treasurer     ______/Franklin\________     Secretary 12 />>||
||//$\                 ~|UNITED STATES OF AMERICA|~               /$\\||
||(100)===================  ONE HUNDRED DOLLARS =================(100)||
||\\$//\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\$//||
||====================================================================||";
string Munt = @"
                 ______________ 
    __,.,---'''''               '''''---..._
 ,-'             .....:::''::.:            '`-.
'           ...:::.....       '                l
            ''':::'''''       .               ,
|'-.._           ''''':::..::':          __,,-
 '-.._''`---.....______________.....---''__,,-
      ''`---.....______________.....---''
";
Console.WriteLine($"\tHallo en welkom bij de bank \n {Munt}");
Console.BackgroundColor= ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Wat is uw naam aub");
Console.ResetColor();
string Naam = Console.ReadLine();
Console.WriteLine("\n");
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine($"Dag {Naam}, hoeveel Euro wilt u omzetten naar Dollar?");
Console.ResetColor();
double Euro = Double.Parse(Console.ReadLine());
double Dollar = Euro * 1.05;
Console.Clear();
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;
Console.Write($"\t\tFantastisch gedaan {Naam}, u ontvangt {Dollar} Dollar\t{DollarBill}");
Console.ResetColor();