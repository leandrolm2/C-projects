// See https://aka.ms/new-console-template for more information
Menu();
static void Menu()
{
    Console.Clear();

    Console.WriteLine("Which operation do you want to execute: ");
    
    Console.WriteLine("1 - some.");
    Console.WriteLine("2 - subtraction");
    Console.WriteLine("3 - division");
    Console.WriteLine("4 - multiplication");
    Console.WriteLine("5 - exit");

    Console.WriteLine("--------------------");
    Console.WriteLine("Select one of the 4 number above: ");

    short res = short.Parse(Console.ReadLine());

    switch(res)
    {
        case 1: sum(); break;
        case 2: subtraction(); break;
        case 3: division(); break;
        case 4: multiplication(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void sum()
{
    Console.Clear();

    Console.WriteLine("first value: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("second value: ");
    float v2 = float.Parse(Console.ReadLine());
    
    float result = v1 + v2;

    Console.WriteLine($"The result is: {result}");

    Console.ReadKey();
    Menu();
}

static void subtraction()
{
    Console.Clear();

    Console.WriteLine("first value: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("second value: ");
    float v2 = float.Parse(Console.ReadLine());
    
    float result = v1 - v2;

    Console.WriteLine($"The result is: {result}");
    Console.ReadKey();
    Menu();
}

static void division()
{
    Console.Clear();

    Console.WriteLine("first value: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("second value: ");
    float v2 = float.Parse(Console.ReadLine());

    float result = v1 / v2;

    Console.WriteLine($"The result is: {result}");
    Console.ReadKey();
    Menu();
}

static void multiplication()
{
    Console.Clear();
    Console.WriteLine("first value: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("second value: ");
    float v2 = float.Parse(Console.ReadLine());

    float result = v1 * v2;

    Console.WriteLine($"The result is: {result}");
    Console.ReadKey();
    Menu();
}