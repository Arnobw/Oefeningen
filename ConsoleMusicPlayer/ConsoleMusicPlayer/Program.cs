using ConsoleMusicPlayer;
using WMPLib;

FrontEnd frontEnd = new FrontEnd();
WindowsMediaPlayer player = new WindowsMediaPlayer();
BackEnd backEnd = new BackEnd(player, frontEnd);
backEnd.RunApplication();