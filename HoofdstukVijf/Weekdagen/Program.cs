namespace Kalender
{
    enum Weekdagen
    {
        Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag
    }
    class Program
    {
        static void Main(string[] args)
        {
            Weekdagen Dag = Weekdagen.Dinsdag;
            Console.WriteLine(Dag);
        }
    }
}