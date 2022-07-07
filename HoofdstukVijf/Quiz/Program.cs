//beter een functie schrijven die een vraag met antwoord aanmaakt en in een array/lijst steekt ipv een hoop switch cases
int Score = 0;


int Vraag1()
{
    Console.ResetColor();
    Console.WriteLine("Wat zegt een hond?\n A. woef \nB. wif\nC. miauw");
    string Answer = Console.ReadLine();
    Answer = Answer.ToUpper();
       switch (Answer) {
        case "A":
            Score += 2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct! Uw score is nu {Score}");
            break;
        default:
            Score--;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Niet correct, het juiste antwoord was A");
            break;
    }
    Console.WriteLine("Druk op enter voor de volgende vraag");
    Console.ReadLine();
    Console.Clear();
    return Score;

};


int Vraag2()
{
    Console.ResetColor();
    Console.WriteLine("Wie heeft de elektronenmicroscoop uitgevonden ?\nA. Einstein \nB. Ernst Ruska\nC. Rudy Niet");
    string Answer = Console.ReadLine();
    Answer = Answer.ToUpper();
    switch (Answer)
    {
        case "B":
            Console.ForegroundColor = ConsoleColor.Green;
            Score += 2;
            Console.WriteLine($"Correct! Uw score is nu {Score}!");
            break;
        default:
            Score--;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Niet correct, het juiste antwoord was B");
            break;
    }
    Console.WriteLine("Druk op enter voor de volgende vraag");
    Console.ReadLine();
    Console.Clear();
    return Score;
};

int Vraag3()
{
    Console.ResetColor();
    Console.WriteLine("Hoe heet het laatste album van The Chariot, uitgebracht in 2012?\nA. Selected Ambient Works \nB. Detrimentalist\nC. One Wing");
    string Answer = Console.ReadLine();
    Answer = Answer.ToUpper();
    switch (Answer)
    {
        case "C":
            Console.ForegroundColor = ConsoleColor.Green;
            Score += 2;
            Console.WriteLine($"Correct! Uw score is nu {Score}!");
            break;
        default:
            Score--;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Niet correct, het juiste antwoord was B");
            break;
    }


    Console.Clear();
    return Score;
};

void Total() {
    if (Score < 0)
    {
        Console.WriteLine($"Wat pijnlijk, uw score is {Score}. Tijd voor wat bijscholing");
    }
    else {
        Console.WriteLine($"Goed gespeeld, uw score is {Score}");
    }
};

void makeQuestion(string question, string choice1, string choice2, string choice3, string correct) {
    Console.WriteLine($"{question}\nA.{choice1}\nB.{choice2}\nC.{choice3}");
    Console.WriteLine("Bevestig uw keuze met A, B, of C in de console");
    string Answer = Console.ReadLine();
        if (Answer == correct)
    {
        Score += 2;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Correct! Uw score is nu {Score}");

    }
    else {
        Score--;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Fout, het juiste antwoord was ");
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.Write(correct);
        Console.ResetColor();
    };
  
};

makeQuestion("wat zegt een hond?", "woef", "miauw", "blub", "woef");
//Vraag1();
//Vraag2();
//Vraag3();
//Total();