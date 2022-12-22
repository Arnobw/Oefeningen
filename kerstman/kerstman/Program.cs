

List<string> names = new List<string> {"Arno", "Tom", "Willem", "Katrijn", "Steven", "Juul", "Margit", "Fleur", "Margo", "Hannelore" };
List<string> names2 = new List<string> { "Arno", "Tom", "Willem", "Katrijn", "Steven", "Juul", "Margit", "Fleur", "Margo", "Hannelore" };

Random rng = new Random();  
foreach (string name in names) 
{
    int length = names2.Count;
    int num = rng.Next(length);   
    Console.WriteLine($"{name} -> {names2[num]}");
    names2.RemoveAt(num);
}