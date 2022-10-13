//Het dierenrijk

//Maak bovenstaande klassenhierarchie na. Animal is de parentklasse , mammal en reptile zijn childklassen van Animal en zo voort.

//Verzin voor iedere klasse een property die de parent klasse niet heeft. (bv Animal heeft “BeweegVoort”, Reptile heeft “AantalSchubben”, etc).

//Voorzie in de klasse Animal een virtual methode ToonInfo die alle properties van de klasse op het scherm zet. De overgeërfde klassen overriden deze methode door de extra properties ook te tonen (maar gebruik base.ToonInfo om zeker de parentklasse werking te bewaren).

//Maak nu van iedere klasse een object en roep de ToonInfo methode van ieder object aan.



public class Animal
{
    public string Name { get; set; }
    public string Description { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name}, {Description}");
    }
    public void Movemement() {
        Console.WriteLine($"the {Name} goes fest men))))");
    }
}

public class Mammal : Animal
{
}

public class Bird : Animal
{
    public bool CanFly { get; set; }  
}

public class Reptile : Animal
{
}

public class Amphibian : Animal
{
}

public class Fish : Animal
{
}

public class Invertebrates : Animal
{
}

//Plaats deze dieren nu in een List<Animal> en kijk wat er gebeurt als je deze met een foreach aanroept om alle ToonInfo-methoden van ieder dier te gebruiken.
//Ziekenhuis
//Deel 1

//Maak een basisklasse Patient die een programma kan gebruiken om de doktersrekening te berekenen. Een patiënt heeft:

//    een naam
//    het aantal uur dat hij in het ziekenhuis heeft gelegen

//Een virtual methode BerekenKost zal de totaalkost berekenen. Deze bestaat uit 50euro+ 20euro per uur dat de patiënt in het ziekenhuis lag.

//Maak een methode ToonInfo die steeds de naam van de patiënt toont gevolgd door het aantal uur en z’n kosten.
//Deel 2

//Maak een specialisatieklasse VerzekerdePatient. Deze klasse heeft alles dat een gewone Patient heeft, echter de berekening van de kosten zal steeds gevolgd worden door een 10% reductie.

//Toon de werking aan van deze klasse.