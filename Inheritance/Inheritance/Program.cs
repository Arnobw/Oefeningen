Dier Hond = new Dier();
Paard Paard = new Paard();

Hond.IsHetEenDier = true;
Hond.Eet();
Paard.DierCheck();




class Dier
{
    public void Eet()
    {
        Console.WriteLine("nom nom nom");
    }
    public bool IsHetEenDier { get; set; }
    public virtual void DierCheck()
    {
        Console.WriteLine(IsHetEenDier);
    }

}


class Paard : Dier
{

    public string Name = "paart";
    public override void DierCheck()
    {
        Console.WriteLine("het is een paard");
    }


}
