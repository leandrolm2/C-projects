// See https://aka.ms/new-console-template for more information

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = seconds: ");
    Console.WriteLine("M = seconds: ");
    Console.WriteLine("0 = exit: ");
    Console.WriteLine("How much time do you want to count? ");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplayer = 1;

    if (type == 'm')
        multiplayer = 60;

    if (time == 0)
        Environment.Exit(0);

    Start(time * multiplayer);
}

static void Start(int time)
{
    int currrentTime = 0;

    while (currrentTime != time)
    {
        Console.Clear();
        currrentTime++;
        Console.WriteLine(currrentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Finished time!");    
    Thread.Sleep(2500);
    Menu();
}