void PrintTitle(string Input)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Hou films bij met naam, speelduur, en genre");
    Console.ForegroundColor = ConsoleColor.White;
};

string getTitle()
{
    Console.WriteLine("Voer een filmnaam in");
    string userInput = Console.ReadLine();
    return userInput;
};
