
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar um novo arquivo");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("-----------------------------------------------------");

    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break;
    }
    
}

static void Abrir()
{

}

static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo e para finalizar click em ESC");
    Console.WriteLine("-----------------------------------------------------");

    string texto = "";

    do
    {
        texto += Console.ReadLine();
        texto += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    Console.WriteLine("-----------------------------------------------------");
    Console.Write(texto);

}