using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    public enum Kleur
    {
        Harten,
        Ruiten,
        Schoppen,
        Klaveren
    }


}



