using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); //criar identificador global aleatório
            //id.ToString();
            //id = new Guid();
            Console.WriteLine(id);
            Console.WriteLine(id.ToString().Substring(0, 8));

        }
    }
}
