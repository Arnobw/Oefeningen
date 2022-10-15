Dier Hond = new Dier("woefke");


DuizendPoot Duizendpoot = new DuizendPoot("Harry Poten");
Duizendpoot.VoortBeweging();







public class Dier
{

    public Dier(string Name)
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


public class DuizendPoot : Dier
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
