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
            GetFiles();
            _frontEnd.PrintMenu();
            _frontEnd.DisplayVolumeBar(GetCurrentVolume());
            Commands userInput = _frontEnd.GetUserAction();
            HandleUserInput(userInput);
        }

        private void PlaySong(int userInput)
        {
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string[] musicFiles = GetFiles();
            _player.URL = Path.Combine(musicFolder, musicFiles[userInput+1]);
            _player.controls.play();
            RunApplication();
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
                    DisplaySongs(GetFiles());
                    break;

                default:
                    _frontEnd.PrintErrorMessage("Ongeldige keuze, kies opnieuw");
                    break;
            };
        }

        //TODO dit moet naar frontend maar dan werkt de recursie niet meer :(
        public void DisplaySongs(string[] musicFiles)
        {
            int songNumber = 0;
            foreach (string song in musicFiles)
            {

                songNumber++;
                Console.WriteLine($"{songNumber}-{Path.GetFileNameWithoutExtension(song)}");
            }
            RunApplication();
        }

        private void ExitPlayer()
        {
            Environment.Exit(0);
        }

        private void TogglePause(bool isPlaying)
        {
            switch (isPlaying)
            {
                case true:
                    _player.controls.pause();
                    _isPlaying = false;
                    break;

                case false:
                    _player.controls.play();
                    _isPlaying = true;
                    break;
            };

            RunApplication();
        }

        /// <summary>
        /// TODO setvolume moet input parameter opvragen (int volume)
        /// TODO volume opvragen verhuizen naar frontend
        /// TODO check if int
        ///
        /// </summary>
        /// <returns></returns>
        ///

        private int GetCurrentVolume()
        {
            int currentVolume = _player.settings.volume;
            return currentVolume;
        }

        private int SetVolume()
        {
            Console.WriteLine("Geef het gewenste volume in");
            int userVolume = int.Parse(Console.ReadLine());
            //TODO check on int
            if (userVolume > 100 || userVolume < 0)
            {
                Console.WriteLine("Geef enkel een waarde tussen 0 en 100 in aub");
                SetVolume();
            }
            else
            {
                _player.settings.volume = userVolume;
            }
            RunApplication();
            return userVolume;
        }

        //TODO remove duplicate code
        // input parameter + frontend

        private void StopMusic()
        {
            _player.controls.stop();
            RunApplication();
        }

        //nice to have: nummers in folder in array zetten en na elkaar afspelen
        private string[] GetFiles()
        {
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string[] musicFiles = Directory.GetFiles(musicFolder, "*.mp3");
            //frontend
            return musicFiles;
        }
    }
}