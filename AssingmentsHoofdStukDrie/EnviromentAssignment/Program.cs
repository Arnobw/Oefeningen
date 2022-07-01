using System.IO;
long cdriveinbytes = (long)(DriveInfo.GetDrives()[0].AvailableFreeSpace / Math.Pow(1024,3));
long totalsize = (long)(DriveInfo.GetDrives()[0].TotalSize / Math.Pow(1024, 3));
double Geheugen = Environment.SystemPageSize;
string Gebruiker = Environment.UserName;
string MooiLaptop = @"   

   +--------------+
   |.------------.|
   ||            ||
   ||            ||
   ||            ||
   ||            ||
   |+------------+|
   +-..--------..-+
   .--------------.
  / /============\ \
 / /==============\ \
/____________________\
\____________________/";

Console.WriteLine(MooiLaptop);
Console.Write("Hallo ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(Gebruiker);
Console.ResetColor();
Console.WriteLine("! \n");    
Console.Write("U heeft momenteel ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{cdriveinbytes}GB");
Console.ResetColor();
Console.Write(" van uw ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{totalsize}GB");
Console.ResetColor();
Console.Write(" aan geheugen over. Misschien is het tijd om wat \"huiswerk\"-folders te verwijderen?\n");

