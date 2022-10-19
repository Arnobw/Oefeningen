namespace Speelkaarten
{
    public interface IGameEngine
    {
        void KaartVerbranden(IList<Kaart> deck);

        IList<Kaart> GenerateDeckOfCards();
    }
}