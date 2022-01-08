using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var id = Guid.NewGuid(); //criar identificador global aleatório
            //id.ToString();
            //id = new Guid();
            Console.WriteLine(id);
            Console.WriteLine(id.ToString().Substring(0, 8));

            var price = 10.2;
            //var texto = "O preço do produto é " + price;
            //var texto = string.Format("O preço do produto é {0}", price);
            var texto = $"O preço da promoção é {price}";

            Console.WriteLine(texto);

            var textoDois = "Testandoe, alguma, coisa";
            Console.WriteLine(textoDois.CompareTo("Testando")); // 0 se tiver

            Console.WriteLine(textoDois.Contains("ando")); // true se tiver

            Console.WriteLine(textoDois.StartsWith("Tes"));

            Console.WriteLine(textoDois.EndsWith("Tes"));

            Console.WriteLine(textoDois.EndsWith("ando"));

            Console.WriteLine(textoDois.Equals("Testando"));

            Console.WriteLine(textoDois.IndexOf("t")); //busca o índice
            Console.WriteLine(textoDois.LastIndexOf("e")); //busca o índice da ultima ocorrência

            Console.WriteLine(textoDois.ToLower());
            Console.WriteLine(textoDois.ToUpper());
            Console.WriteLine(textoDois.Insert(5, "AQUI")); //INSERE O TEXTO na posição

            Console.WriteLine(textoDois.Remove(1, 2));

            Console.WriteLine(textoDois.Length);

            Console.WriteLine(textoDois.Replace("ando", "novo"));

            var divisao = textoDois.Split(",");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);

            var resultado = textoDois.Substring(5, 3);
            Console.WriteLine(resultado);

            var textoTres = " Olá ";
            Console.WriteLine(textoTres.Trim()); //limpa os espaços

            var textoQuatro = new StringBuilder();
            textoQuatro.Append("Esse texto é legal!");
            textoQuatro.Append("...");
            textoQuatro.Append("mesmo!");
            //textoQuatro.ToString();
            Console.WriteLine(textoQuatro);


        }
    }
}
