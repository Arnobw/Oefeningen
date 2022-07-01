Console.WriteLine("gebruik je wildste fantasie om een hoek te bedenken van een bepaald aantal graden");
int Hoek = int.Parse(Console.ReadLine());
double Pi = Math.PI;
double Rad = Math.PI * Hoek /180.0;
double S = Math.Sin(Rad);    
double C = Math.Cos(Rad);
double T = Math.Tan(Rad);
Console.WriteLine($"{S} {C} {T}");
