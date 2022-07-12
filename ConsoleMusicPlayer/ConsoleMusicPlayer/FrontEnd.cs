namespace ConsoleMusicPlayer
{
    internal class FrontEnd
    {
        public void PrintHeader()
        {
            //TODO maak een mooie header
        }

        public void PrintMenu()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("1 > Geef een nummer in om af te spelen");
            Console.WriteLine("2 > Pauzeer of hervat");
            Console.WriteLine("3 > Volume omhoog/omlaag");
            Console.WriteLine("4 > Stop de muziek");
            Console.WriteLine("5 > Toon alle muziek");
            Console.WriteLine("9 > Sluit de speler af");
            Console.ResetColor();
        }

        public int GetSong()
        {
            Console.WriteLine("Kies een nummer om af te spelen");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }

        public Commands GetUserAction()
        {
            Console.WriteLine("Geef aub een keuze in");
            bool canConvert;
            int userInput = 0;
            canConvert = int.TryParse(Console.ReadLine(), out userInput);

            if (canConvert)
            {
                return (Commands)userInput;
            }
            else
            {
                PrintErrorMessage("Ongeldig getal");
                return GetUserAction();
            }
        }

        public void PrintErrorMessage(string message, ConsoleColor color = ConsoleColor.Red)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void DisplayVolumeBar(int volume)
        {
            Console.WriteLine($"Huidig volume: {volume}");
            string[] volumeBar = new string[11];

            for (int i = 0; i < volumeBar.Length; i++)
            {
                volumeBar[i] = "-";
            }
            int slider = volume / 10;
            volumeBar[slider] = "||";

            foreach (string value in volumeBar)
            {
                Console.Write(value);
            }
            Console.WriteLine("\n");
        }
    }
}