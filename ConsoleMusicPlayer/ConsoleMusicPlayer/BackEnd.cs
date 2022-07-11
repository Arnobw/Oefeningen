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

        private void PlaySong()
        {
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            Console.WriteLine("Kies een nummer om af te spelen");
            string userInput = Console.ReadLine();
            _player.URL = Path.Combine(musicFolder, userInput);
            _player.controls.play();
            RunApplication();
        }

        public void RunApplication()
        {
            GetFiles();
            _frontEnd.PrintMenu();
            string userInput = Console.ReadLine();
            HandleUserInput(userInput);
            Console.ReadKey();
        }

        private void HandleUserInput(string userInput)
        {
            switch (userInput)
            {
                case "p":
                    TogglePause(_isPlaying);
                    break;

                case "vol":
                    SetVolume();
                    break;

                case "s":
                    StopMusic();
                    break;

                case "play":
                    PlaySong();
                    break;
            };
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

        private void SetVolume()
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
            Console.WriteLine($"Huidig volume: {_player.settings.volume}");
            RunApplication();
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
            foreach (string song in musicFiles)
            {
                Console.WriteLine(song);
            }
            return musicFiles;
        }
    }
}