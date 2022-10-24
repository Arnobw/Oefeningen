Animal Hond = new Animal("woefke");


DuizendPoot Duizendpoot = new DuizendPoot("Harry Poten");
Duizendpoot.VoortBeweging();




List<Animal> animals = new List<Animal>();

animals.Add(Duizendpoot);
animals.Add(Hond);

foreach (Animal x in animals)
{
    Console.WriteLine(x.Name);
}

public class Animal
{

    public Animal(string Name)
    {
        this.Name = Name;
    }
    protected int poten;

    public string Name { get; }

    public virtual void VoortBeweging()
    {
        poten += 4;

    }
    public void Eet()
    {
        Console.WriteLine("nom nom nom");
    }



}


public class DuizendPoot : Animal
{
    public DuizendPoot(string Name) : base(Name)
    {
    }

    public override void VoortBeweging()
    {
        base.VoortBeweging();
        poten += 996;
        Console.WriteLine($"{this.Name} beweegt zich voort met {poten} aantal poten");
    }
}

