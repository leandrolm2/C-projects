// See https://aka.ms/new-console-template for more information
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("What do you wanna do?");
    Console.WriteLine("1 - open a folder");
    Console.WriteLine("2 - make a new folder");
    Console.WriteLine("3 - delete a folder");
    Console.WriteLine("0 - exit");

    short option = short.Parse(Console.ReadLine());

    switch(option)
    {
        case 0: Environment.Exit(0); break;
        case 1: Open(); break;
        case 2: Edit(); break;
        case 3: Delete(); break;
        default: Menu(); break;
            
    }
}

static void Delete()
{
    Console.Clear();
    Console.WriteLine("What's the file path you wanna delete?");
    string path = Console.ReadLine();

    if (path == null) Menu();


    File.Delete(path);

    Console.WriteLine($"file from path {path} deleted!");
    Console.ReadLine();

    Menu();
}
static void Open()
{
    Console.Clear();
    Console.WriteLine("What's the file path?");
    string path = Console.ReadLine();

    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }

    Console.WriteLine("");
    Console.ReadLine();

    Menu();
}

static void Edit()
{
    Console.Clear();
    Console.WriteLine("Type your text below. (ESC TO EXIT!)");
    Console.WriteLine("---------------------");

    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while(Console.ReadKey().Key != ConsoleKey.Escape);
    
    Save(text);
}

static void Save(string text)
{
    Console.Clear();
    Console.WriteLine(" Type here the file path");
    var path = Console.ReadLine();

    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }

    Console.WriteLine($"File {path} successfully saved!");
    Console.ReadLine();
    Menu();
}