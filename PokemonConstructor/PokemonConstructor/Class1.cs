using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonConstructor
{
    public class Pokemon
    {
        public string Name { get; set; }
        public List<Type> Types { get; set; } = new List<Type>();
        public int HP { get; set; }
        public Pokemon(string name, Type type, params Type[] secondaryTypes)
        {
            Types.Add(type);
            Types.AddRange(secondaryTypes);
            Name = name;
            switch (type)
            {
                case Type.WATER: HP = 50; break;
                case Type.GROUND: HP = 70; break;
                case Type.ICE: HP = 60; break;
                case Type.DARK: HP = 40; break;
                case Type.FAIRY: HP = 35; break;
                default: HP = 50; break;
            }
        }
        public void Display()
        {
            Console.Write($"{Name} - {HP}HP | Types: ");
            foreach (Type type in Types)
            {
                Console.Write($"{type} ");
            }
        }
    }
}
