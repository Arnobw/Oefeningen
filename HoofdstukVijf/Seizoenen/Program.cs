using Seasons;

bool Hot = false;
Console.WriteLine("Geef aan welke maand uw favoriet is, 1 voor Januari etc...");
int input = int.Parse(Console.ReadLine());

months season = new months();


void getMonth() {
    switch (input)
    {
        case 1:
        case 2:
        case 3:

            Console.WriteLine("Dat is de winter");
            Hot = false;
            break;


        case 4:
        case 5:
        case 6:
            Console.WriteLine("Een fan van de lente?");
            Hot = true;
            break;
        case 7:
        case 8:
        case 9:
            Console.WriteLine("ohla, de zomer. Verschrikkelijk");
            Hot = true;
            break;
        case 10:
        case 11:
        case 12:
            Console.WriteLine("Aha, een herfstliefhebber");
            Hot = false;
            break;
    }

    Console.WriteLine($"Uw favoriete maand is dus {(months)input}? Geweldig.");
    if (Hot == false)
    {
        Console.WriteLine("Lekker fris!");
    }
    else
    {
        Console.WriteLine("Lekker warm");
    };

};




getMonth();