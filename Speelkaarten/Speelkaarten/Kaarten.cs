namespace Speelkaarten
{
    public class Kaart
    {
        public int Getal { get; set; }
        public Kleur Kleur { get; set; }

        public Kaart(int getal, Kleur kleur)
        {
            Getal = getal;
            Kleur = kleur;
        }
    }
}