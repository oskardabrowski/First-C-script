// See https://aka.ms/new-console-template for more information

static string Function(string name)
{
    string hello = "Hello ";
    string text = hello + name.ToString();
    return text;
}

static void StartProgram()
{
    Console.WriteLine("Hello, what's your name?");
    string name = Console.ReadLine();
    if (!String.IsNullOrEmpty(name))
    {
        Console.WriteLine(Function(name));
    }
    else
    {
        Console.WriteLine("Please write your name!");
        StartProgram();
    }
}
StartProgram();
