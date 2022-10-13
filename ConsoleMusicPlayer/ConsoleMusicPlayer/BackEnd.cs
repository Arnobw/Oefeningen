using WMPLib;

namespace ConsoleMusicPlayer

{
    internal class BackEnd
    {
        private WindowsMediaPlayer _player;
        private FrontEnd _frontEnd;
        private bool _isPlaying = true;

        public BackEnd(WindowsMediaPlayer player, FrontEnd frontEnd)
        {
            _player = player;
            _frontEnd = frontEnd;
        }

        public void RunApplication()
        {
            Console.Clear();
            GetFiles();

            _frontEnd.PrintMenu();
            _frontEnd.DisplaySongs(GetFiles());
            _frontEnd.DisplayVolumeBar(GetCurrentVolume());
            PrintMetadata();
            Commands userInput = _frontEnd.GetUserAction();
            HandleUserInput(userInput);
        }

        private void PlaySong(int userInput)
        {
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string[] musicFiles = GetFiles();
            _player.URL = Path.Combine(musicFolder, musicFiles[userInput - 1]);
            _player.controls.play();

            RunApplication();
        }

        private void PrintMetadata()
        {
            Thread.Sleep(100);
            MetadataDTO metadata = GetMetadata(_player.currentMedia);
            _frontEnd.PrintMetadata(metadata);
        }

        public MetadataDTO GetMetadata(IWMPMedia media)
        {
            MetadataDTO metadata = new MetadataDTO();
            if (media != null)
            {
                metadata.Artist = media.getItemInfo("Artist");
                metadata.Title = media.getItemInfo("Title");
                metadata.Genre = media.getItemInfo("Genre");
            }

            return metadata;
        }

        private void HandleUserInput(Commands command)
        {
            switch (command)
            {
                case Commands.PlaySong:
                    int song = _frontEnd.GetSong();
                    PlaySong(song);
                    break;

                case Commands.TogglePause:
                    TogglePause(_isPlaying);
                    break;

                case Commands.SetVolume:
                    SetVolume();
                    break;

                case Commands.StopSong:
                    StopMusic();
                    break;

                case Commands.ExitPlayer:
                    ExitPlayer();
                    break;

                case Commands.SongList:
                    _frontEnd.DisplaySongs(GetFiles());
                    break;

                case Commands.Penta:
                    _frontEnd.printPenta();
                    break;

                case Commands.Hela:
                    _frontEnd.PrintErrorMessage("foei", ConsoleColor.Magenta);
                    break;

                default:
                    _frontEnd.PrintErrorMessage("Ongeldige keuze, kies opnieuw");
                    RunApplication();
                    break;
            };
        }

        private void ExitPlayer()
        {
            Environment.Exit(0);
        }

        private void TogglePause(bool isPlaying)
        {
            if (isPlaying)
            {
                _player.controls.pause();
            }
            else
            {
                _player.controls.play();
            }

            _isPlaying = !_isPlaying;

            RunApplication();
        }

        private int GetCurrentVolume()
        {
            Thread.Sleep(100);
            int currentVolume = _player.settings.volume;
            return currentVolume;
        }

        private int SetVolume()
        {
            Console.WriteLine("Geef het gewenste volume in");
            int userVolume;

            bool canConvert;
            canConvert = int.TryParse(Console.ReadLine(), out userVolume);
            if (canConvert)
            {
                if (userVolume > 100 || userVolume < 0)
                {
                    Console.WriteLine("Geef enkel een waarde tussen 0 en 100 in aub");
                    SetVolume();
                }
                else
                {
                    _player.settings.volume = userVolume;
                }
            }
            else
            {
                _frontEnd.PrintErrorMessage("Ongeldig getal");
                return SetVolume();
            }

            RunApplication();
            return userVolume;
        }

        private void StopMusic()
        {
            _player.controls.stop();
            RunApplication();
        }

        private string[] GetFiles()
        {
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string[] musicFiles = Directory.GetFiles(musicFolder, "*.mp3");
            //frontend
            return musicFiles;
        }
    }
}