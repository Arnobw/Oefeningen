for (int i = 0; i < 60; i++)
{
    string klok = DateTime.Now.ToString("HH:mm:ss");
    Console.WriteLine(klok);
    Thread.Sleep(1000);
    Console.Clear();
}

Console.ReadKey();