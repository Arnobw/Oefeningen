namespace ConsoleMusicPlayer
{
    internal class FrontEnd
    {
        public void PrintHeader()
        {
            string playerHeader = @"
               _ _           _                    __ ___
  _ __  ___ __| (_)__ _ _ __| |__ _ _  _ ___ _ _ / // _ \
 | '  \/ -_) _` | / _` | '_ \ / _` | || / -_) '_/ _ \_, /
 |_|_|_\___\__,_|_\__,_| .__/_\__,_|\_, \___|_| \___//_/
                       |_|          |__/
The ultimate console app for playing your music songs!!1!1!!
"; Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(playerHeader);
        }

        public void PrintMenu()
        {
            Console.ResetColor();
            PrintHeader();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("| 1 > Geef een nummer in om af te spelen");
            Console.WriteLine("| 2 > Pauzeer of hervat");
            Console.WriteLine("| 3 > Volume omhoog/omlaag");
            Console.WriteLine("| 4 > Stop de muziek");
            Console.WriteLine("| 9 > Sluit de speler af");
            Console.ResetColor();
            Console.WriteLine("\n");
        }

        public int GetSong()
        {
            Console.WriteLine("Kies een nummer om af te spelen");
            int userInput = int.Parse(Console.ReadLine());
            StoreSelectedSong(userInput);
            return userInput;
        }

        private int StoreSelectedSong(int selectedSong = 0)
        {
            return selectedSong;
        }

        public void DisplaySongs(string[] musicFiles)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Beschikbare nummers:");
            Console.ResetColor();
            for (int i = 0; i < musicFiles.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int paddingSize = i.ToString().Length;
                    if (i < 10)
                        Console.Write($"|{i + 1} - {Path.GetFileNameWithoutExtension(musicFiles[i]).PadRight(25 + paddingSize)}");
                    else
                    {
                        Console.Write($"|{i + 1} - {Path.GetFileNameWithoutExtension(musicFiles[i]).PadRight(25)}");
                    }
                }
                else
                {
                    Console.WriteLine($"|{i + 1} - {Path.GetFileNameWithoutExtension(musicFiles[i])}");
                }
            }
            Console.ResetColor();
            Console.WriteLine("\n");
        }

        public void PrintMetadata(MetadataDTO dto)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("| NOW PLAYING:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"| {dto.Title} by {dto.Artist} from {dto.Album}({dto.Genre})");
            Console.ResetColor();
        }

        public Commands GetUserAction()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|Geef aub een keuze in:");

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
            Console.WriteLine($"[HUIDIG VOLUME: {volume}%]");
            Console.WriteLine(" ");
            Console.Write("[");

            string[] volumeBar = new string[11];

            for (int i = 0; i < volumeBar.Length; i++)
            {
                volumeBar[i] = "--";
            }
            int slider = volume / 10;
            volumeBar[slider] = "||";

            foreach (string value in volumeBar)
            {
                Console.Write(value);
            }
            Console.Write("]");
            Console.ResetColor();
            Console.WriteLine("\n");
        }

        private string penta = @"

MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMds+:--------:+sdNMMMMMMMMMMM
MMMMMMMMms:-+sdNMMMMMMMMNdy+--omMMMMMMMM
MMMMMMh:` /mMMMMMMMMMMMMMMMMm+ `-yMMMMMM
MMMMd--hN``--sNMMMMMMMMMMNy:..`md:.hMMMM
MMM+`yMMMy hd+./hMMMMMMh/.+dd sMMMh`/MMM
MM:.mMMMMM:.NMMh/.+dd+./hMMM--MMMMMm--NM
M+`mMMMMMMN`+MMMMm-  .dMMMMo mMMMMMMN.:M
d yMMMMMMMMy dNy:.omNs--sNm oMMMMMMMMh h
/`MMMMMMMMMM.`.+dMMMMMMm+.``NMMMMMMMMM-:
.:MMMMMMMd+./`oMMMMMMMMMMs /.+dMMMMMMM/`
.:MMMMmo.:yNMs dMMMMMMMMm`oMNy:.omMMMM/`
/`MNy:.omMMMMM--MMMMMMMM:.MMMMMNs--sNM.:
d -` :++++++++: /++++++/ :++++++++:  : h
M+ yddddddddddd+ yddddy /dddddddddddy`/M
MM/.mMMMMMMMMMMM.-MMMM/.NMMMMMMMMMMm.:NM
MMMo`sMMMMMMMMMMd sMMy hMMMMMMMMMMy`+MMM
MMMMd--hMMMMMMMMM+`mN`/MMMMMMMMMh--hMMMM
MMMMMMh:.omMMMMMMN.:/`NMMMMMMms.:hMMMMMM
MMMMMMMMNs:./shmMMh  yMMNds/.:smMMMMMMMM
MMMMMMMMMMMMdy+/---``---:+sdMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
";

        public void printPenta()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(penta);
        }
    }
}