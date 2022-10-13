using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokkemon
{
    class Pokemon
    {
    public Pokemon(string pName, string pType, int pLevel)
        {
            Name = pName;
            TypeP = pType;
            Level = pLevel;
            HP_Full = 2*pLevel+5;    
        }

    public string Name;
    public string TypeP;
    public int Level;

        public int HP_Full;
    //    public string Name { get; set; }
    //    public string Type { get; set; }
    //    public int Level { get; set; }

    //    public int Hp_Base { get; set; }
    //    public int Attack_Base { get; set; }
    //    public int Defense_Base { get; set; }
    //    public int SpecialAttack_Base { get; set; }

    //    public int SpecialDefense_Base { get; set; }
    //    public int Speed_Base { get; set; }

    //    public int Hp_Full { get { return (Hp_Base + 50) * Level / 50; } }
    //    public int Attack_Full { get { return (Attack_Base* Level / 50) + 5; } }
    //    public int Defence_Full { get { return (Defense_Base* Level / 50) + 5; } }  
    //    public int Speed_Full { get { return (Speed_Base* Level / 50) + 5; } }
    }


}


//HP_Base
//Attack_Base
//Defense_Base
//SpecialAttack_Base
//SpecialDefense_Base
//Speed_Base