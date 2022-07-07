using WMPLib;

WindowsMediaPlayer player = new WindowsMediaPlayer();
bool isPlaying = true;
string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
Console.WriteLine(musicFolder);
player.URL = Path.Combine(musicFolder, "supermarkt.mp3");
player.controls.play();
ShowMenu();

bool Pause()
{
    switch (isPlaying)
    {
        case true:
            player.controls.pause();
            isPlaying = false;
            break;

        case false:
            player.controls.play();
            isPlaying = true;
            break;
    };
    return isPlaying;
    ShowMenu();
};

void VolumeControl()
{
    Console.WriteLine("Geef het gewenste volume in");
    int userVolume = int.Parse(Console.ReadLine());

    Console.WriteLine($"Huidig volume: {player.settings.volume}");
    if (userVolume > 100 || userVolume < 0)
    {
        Console.WriteLine("Geef enkel een waarde tussen 0 en 100 in aub");
        VolumeControl();
    }
    else
    {
        player.settings.volume = userVolume;
    }
    ShowMenu();
};

void ShowMenu()
{
    Console.WriteLine("Maak een keuze uit het menu of geniet van de muziek");
    Console.WriteLine("P > pauzeren");
    Console.WriteLine("vol > volume omhoog/omlaag");
    Console.WriteLine("s > stop de muziek :(");
    Console.WriteLine("speed > stel de afspeelsnelheid in");
    string userInput = Console.ReadLine();
    switch (userInput)
    {
        case "p":
            Pause();
            break;

        case "vol":
            VolumeControl();
            break;

        case "s":
            player.controls.stop();
            break;
    };
    Console.ReadKey();
};