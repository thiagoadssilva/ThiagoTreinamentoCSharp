using System.Runtime.Intrinsics;

Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("**************Seja Bem Vindo***************");
    Console.WriteLine("Informe a operação que deseja fazer");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("-------------------------------------------");

    Console.WriteLine("Sua operação vai ser?");
    short operacao = short.Parse(Console.ReadLine());

    Console.WriteLine("-------------------------------------------");

    Console.WriteLine("Informe um número");
    float number01 = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe outro número");
    float number02 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("-------------------------------------------");

    switch (operacao)
    {
        case 1: Somar(number01, number02); break;
        case 2: Subtracao(number01, number02); break;
        case 3: Multiplicacao(number01, number02); break;
        case 4: Divisao(number01, number02); break;
        default: Menu(); break;
    }


}

static void Somar(float v1, float v2)
{
    float result = v1 + v2;
    Resultado(result, "Soma", v1, v2);
    Console.ReadKey();
    Finalizar();
    Menu();
}

static void Subtracao(float v1, float v2) 
{
    float result = v1 - v2;
    Resultado(result, "Subtração", v1, v2);
    Finalizar();
    Console.ReadKey();
    Menu();
}

static void Multiplicacao(float v1, float v2)
{
    float result = v1 * v2;
    Resultado(result, "Multiplicação", v1, v2);
    Finalizar();
    Console.ReadKey();
    Menu();
}

static void Divisao(float v1, float v2)
{
    float result = v1 / v2;
    Resultado(result, "Divisão", v1, v2);
    Finalizar();
    Console.ReadKey();
    Menu();
}

static void Resultado(float result, string operacao, float v1, float v2)
{
    Console.WriteLine("");
    Console.WriteLine($"A {operacao} desses valores é: " + result);
    Finalizar();
    Console.ReadKey();
    Menu();
}

static void Finalizar()
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Deseja continuar?");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    var result = int.Parse(Console.ReadLine());

    switch (result)
    {
        case 1: Menu(); break;
        case 2: System.Environment.Exit(0); break;
    }
}

