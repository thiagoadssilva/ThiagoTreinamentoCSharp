double peso, altura;

Console.Clear();
Console.WriteLine("******************Sistema para Calcular seu IMC******************");

Console.WriteLine("Informe seu Peso");
peso = double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Informe sua Altura");
altura = double.Parse(Console.ReadLine());
Console.WriteLine("");

CalcularImc(peso, altura);


static void CalcularImc(double altura, double peso)
{
    double resultado = peso / Math.Pow(altura, 2);
    Console.WriteLine($"Seu IMC é de: {resultado}");
    Console.ReadKey();
}