using System;

namespace TreinamentoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Leite", 2.55, EProductType.Product);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.EProductType);
            Console.WriteLine((int)mouse.EProductType);

        }

    }

    struct Product{

        public Product(int id, string name, double price, EProductType eProductType) {
            Id = id;
            Name = name;
            Price = price;
            EProductType = eProductType;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType EProductType;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}


