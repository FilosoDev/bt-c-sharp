using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int idade;
            //int idade = 25;
            //Console.WriteLine(idade);

            //var outraIdade = 22;
            //Console.WriteLine(outraIdade);

            //var texto = "testando";
            // Console.WriteLine(texto);

            // CONSTANTE
            //const int IDADE_MINIMA = 25;
            //Console.WriteLine(IDADE_MINIMA);

            Product mouse = new Product(1, "Mouse Gamer", 333.45, EProductType.Product);
            // ou var mouse = new Product(1, "Mouse Gamer", 333.45);

            var manutencaoEletrica = new Product(2, "Manutenção Eletrética Residencial", 300, EProductType.Service);

            mouse.Id = 44;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);

            Console.WriteLine(manutencaoEletrica);


        }

        struct Product
        {
            public Product(int id, string name, double price, EProductType type)
            {
                Id = id;
                Name = name;
                Price = price;
                Type = type;
            }

            public int Id;
            public string Name;
            public double Price;
            public EProductType Type;
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
}
