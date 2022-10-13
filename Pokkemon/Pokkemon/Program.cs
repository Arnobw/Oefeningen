using Pokkemon;




Random rnd = new Random();
int num = rnd.Next(0,101);
Pokemon pokemon1 = new Pokemon("pikeachu", "dom", num);
Pokemon pokemon2 = new Pokemon("diglet", "grond", num);




Console.WriteLine($"uw dom beest heeft een level van { pokemon1.Level} en heet { pokemon1.Name} met een HP van {pokemon1.HP_Full}" );